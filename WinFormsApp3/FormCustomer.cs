using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WinFormsApp3
{
    public partial class FormCustomer : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        private string mail;
        private int mechanicID;
        private int customerID;

        public FormCustomer(string mail, string name)
        {
            this.mail = mail;
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
            this.Text = name;
            this.Tag = name + "Ana Sayfa ";
            customerID = userManager.GetCustomerID(mail);

        }


        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ShowCars();
            LoadMessages();
        }
        private void ShowCars()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = $"SELECT c.name,c.surname,cars.plate, m.name as mechanicName ,m.surname, m.mail,m.phoneNumber,cars.deliveryDate,cars.description,cars.fixCost as price ,c.id FROM customercars as cc inner join customers as c on cc.customerID = c.id inner join cars on cc.carID=cars.id inner join mechanics as m on cars.mechanicID= m.id where c.mail ='{mail}' and cars.inMechanic=1 and cars.status=1";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dbConnection.CloseConnection();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { dbConnection.CloseConnection(); }
        }


        private void ReplyMessages(int messageID)
        {
            string query = $"select m.id , m.mail,timestamp,text from messagemechanic inner join mechanics as m on senderID=m.id where messageID=@messageID";
            try
            {
                dbConnection.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@messageID", messageID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBoxFrom.Text = reader["mail"].ToString();
                            textBox1.Text = reader["timestamp"].ToString();
                            txtBoxMail.Text = reader["text"].ToString();
                            mechanicID = Convert.ToInt32(reader["id"]);

                        }
                        else
                        {
                            MessageBox.Show("Mesaj bulunamadı");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        private void LoadMessages()
        {

            string query = $"SELECT msg.messageID,m.name as SenderName, msg.text, msg.timestamp FROM messagemechanic AS msg INNER JOIN mechanics AS m ON msg.senderID = m.id INNER JOIN customers AS c ON msg.receiverID = c.id WHERE c.mail = '{mail}'";
            dbConnection.OpenConnection();

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string senderName = reader["SenderName"].ToString();
                        string messageText = reader["text"].ToString();
                        DateTime messageTimestamp = Convert.ToDateTime(reader["timestamp"]);
                        int messageID = Convert.ToInt32(reader["messageID"]);

                        RichTextBox richTextBox = new RichTextBox();
                        richTextBox.Text = $"From: {senderName}\n{messageText}\nSent at: {messageTimestamp}";
                        richTextBox.BorderStyle = BorderStyle.Fixed3D;
                        richTextBox.ScrollBars = RichTextBoxScrollBars.None;
                        richTextBox.BackColor = Color.FromArgb(57, 20, 94);
                        richTextBox.ForeColor = Color.White;
                        richTextBox.RightMargin = 0;
                        richTextBox.Width = flowLayoutPanelMessages.ClientSize.Width - 30;
                        richTextBox.WordWrap = true;

                        IconButton okunduButton = new IconButton();
                        okunduButton.FlatStyle = FlatStyle.Popup;
                        okunduButton.ForeColor = Color.Cornsilk;
                        okunduButton.FlatAppearance.BorderColor = Color.Cornsilk;
                        okunduButton.Size = new Size(121, 44);
                        okunduButton.Text = "Okundu";
                        okunduButton.Tag = reader["messageID"];
                        okunduButton.Click += OkunduButton_Click;

                        IconButton replyButton = new IconButton();
                        replyButton.FlatStyle = FlatStyle.Popup;
                        replyButton.ForeColor = Color.Cornsilk;
                        replyButton.FlatAppearance.BorderColor = Color.Cornsilk;
                        replyButton.Size = new Size(121, 44);
                        replyButton.Text = "Cevapla";
                        replyButton.Tag = reader["messageID"];
                        replyButton.Click += ReplyButton_Click;

                        flowLayoutPanelMessages.Controls.Add(richTextBox);
                        flowLayoutPanelMessages.Controls.Add(replyButton);
                        flowLayoutPanelMessages.Controls.Add(okunduButton);

                    }
                }
            }

        }

        private void DeleteMessages(int messageID)
        {
            string deleteQuery = $"DELETE FROM messagemechanic WHERE messageID=@messageID";

            try
            {

                dbConnection.OpenConnection();

                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, dbConnection.GetConnection()))
                {
                    deleteCommand.Parameters.AddWithValue("@messageID", messageID);
                    deleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { }
            finally { dbConnection.CloseConnection(); }
            // Mesajları tekrar yükle
            flowLayoutPanelMessages.Controls.Clear();
            LoadMessages();
        }
        private void ReplyButton_Click(object? sender, EventArgs e)
        {
            Button replyButton = (Button)sender;
            int messageID = Convert.ToInt32(replyButton.Tag);
            ReplyMessages(messageID);
            DeleteMessages(messageID);


        }

        private void OkunduButton_Click(object sender, EventArgs e)
        {
            Button okunduButton = (Button)sender;
            int messageID = Convert.ToInt32(okunduButton.Tag);
            DeleteMessages(messageID);

        }

        private void SendMsgToMec()
        {
            try
            {
                string msg = txtBoxRepyl.Text;
                dbConnection.OpenConnection();
                string query = "INSERT INTO messagecustomer (senderID,recieverID,text) VALUES (@customerID, @mechanicID, @text)";

                using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@mechanicID", mechanicID);
                    command.Parameters.AddWithValue("@text", msg);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi");
                    txtBoxRepyl.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Önce Mesaj Varsa Cevapla Butonuna Tıklayın. ");
            }
        }

        private void btnSendMsgToMec_Click(object sender, EventArgs e)
        {
            SendMsgToMec();
            mechanicID = 0;
            txtBoxFrom.Clear();
            txtBoxMail.Clear();
            txtBoxRepyl.Clear();
        }


    }
}
