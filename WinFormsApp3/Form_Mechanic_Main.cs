using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;
using System.Net;
using FontAwesome.Sharp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp3
{
    public partial class Form_Mechanic_Main : Form
    {
        private DatabaseConnection dbConnection;
        private string mail;
        private int customerID;
        private int mechanicID;
        private int carID;
        private UserManager userManager;
        public Form_Mechanic_Main(string mail, string name)
        {
            InitializeComponent();
            this.mail = mail;
            this.Text = name;
            this.Tag = name + " Ana Sayfa";
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            mechanicID = userManager.GetMechanicID(mail);
        }
        private void Form_Mechanic_Main_Load(object sender, EventArgs e)
        {
            ShowJobs();
            LoadMessages();
        }


        private void ShowJobs()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = $"SELECT c.name as CustomerName, c.surname as CustomerSurname,c.mail,c.phoneNumber,cars.plate,cars.description, cars.arrivalDate,cars.deliveryDate ,cars.id,m.id,c.id from cars inner join mechanics as m on cars.mechanicID=m.id inner join customercars as cc on cars.id=cc.carID inner join customers as c on cc.customerID = c.id where m.mail='{mail}' and cars.status = 1";
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id1"].Visible = false;
                dataGridView1.Columns["id2"].Visible = false;

            }
            catch { MessageBox.Show("Hata"); }
            finally
            {
                dbConnection.CloseConnection();

            }

        }
        private void DecraseJobCount()
        {
            try
            {
                dbConnection.OpenConnection();
                string query ="UPDATE mechanics SET jobCount = jobCount - 1 WHERE id = @mechanicID";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@mechanicID", mechanicID);
                cmd.ExecuteNonQuery();
                ShowJobs();

            }
            catch
            {
                MessageBox.Show("İşlem Tamamlanmadı Tekrar Deneyiniz..");
            }
            finally { dbConnection.CloseConnection(); }
        }

        private void UpdateMechanicStatus()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "UPDATE mechanics\r\nSET status = CASE\r\n                WHEN jobCount >= 4 THEN 1\r\n                ELSE 0\r\n              END;";
                MySqlCommand cmd = new MySqlCommand(sql, dbConnection.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
            finally { dbConnection.CloseConnection(); }
        }

        private void FinishJob(DateTime date , int fixCost)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "UPDATE cars SET status = 2,deliveryDate = @deliveryDate , fixCost = @fixCost where cars.id=@CarID ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@deliveryDate", date);
                cmd.Parameters.AddWithValue("@fixCost", fixCost);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Tamamlandı");
                ShowJobs();
                DecraseJobCount();
                UpdateMechanicStatus();

            }
            catch
            {
                MessageBox.Show("İşlem Tamamlanmadı Tekrar Deneyiniz..");
            }
            finally { dbConnection.CloseConnection(); }
        }
        private void dtgMechanicJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtBoxName.Text = row.Cells[0].Value.ToString();
                    txtBoxSurname.Text = row.Cells[1].Value.ToString();
                    txtBoxDesc.Text = row.Cells[5].Value.ToString();
                    txtBoxPlate.Text = row.Cells[4].Value.ToString();
                    dateTimePickerArrival.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    txtBoxMail.Text = row.Cells[2].Value.ToString();
                    carID = Convert.ToInt32(row.Cells[8].Value);

                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }
        }
        private void SendMessage(string mail)
        {
            try
            {
                int customerID = userManager.GetCustomerID(mail);
                string msg = txtBoxMailDesc.Text;
                dbConnection.OpenConnection();
                string query = "INSERT INTO messagemechanic (senderID,receiverID,text) VALUES (@mechanicID, @customerID, @text)";

                using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@mechanicID", mechanicID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@text", msg);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi");
                    txtBoxMailDesc.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Hata Oluştu Bilgileri Kontrol Ediniz");
            }
        }
        private void ReplyMessages(int messageID)
        {
            string query = $"select  c.mail,timestamp,text from messagecustomer inner join customers as c on senderID=c.id where messageID=@messageID";
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
                            txtBoxMail.Text = reader["mail"].ToString();
                            txtBoxDate.Text = reader["timestamp"].ToString();
                            txtBoxRMail.Text = reader["text"].ToString();
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

            string query = $"SELECT msg.messageID,c.name as SenderName, msg.text, msg.timestamp FROM messagecustomer AS msg INNER JOIN mechanics AS m ON msg.recieverID = m.id INNER JOIN customers AS c ON msg.senderID = c.id WHERE m.mail = '{mail}'";

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
                        okunduButton.Size = new Size(136, 53);
                        okunduButton.Text = "Okundu";
                        okunduButton.Tag = reader["messageID"];
                        okunduButton.Click += OkunduButton_Click;

                        IconButton replyButton = new IconButton();
                        replyButton.FlatStyle = FlatStyle.Popup;
                        replyButton.FlatAppearance.BorderColor = Color.Cornsilk;
                        replyButton.ForeColor = Color.Cornsilk;
                        replyButton.Size = new Size(136, 53);
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
            string deleteQuery = $"DELETE FROM messagecustomer WHERE messageID=@messageID";

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


        private void btnCompleteJob_Click(object sender, EventArgs e)
        {
            try { 
            DateTime date = dateTimePickerArrival.Value;
            int fixCost = Convert.ToInt32(textBoxFixCost.Text);
            FinishJob(date,fixCost);
            }
            catch { MessageBox.Show("Fiyat Bilgisini Kontrol Ediniz"); }

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string mail = txtBoxMail.Text;
            SendMessage(mail);
        }

  
    }
}



