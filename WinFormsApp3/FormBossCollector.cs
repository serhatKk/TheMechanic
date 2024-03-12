using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FormBossCollector : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        private int collectorID;

        public FormBossCollector()
        {
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
        }
        private void UpdateCollector()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = $"update carcollector set name = @name ,surname=@surname,mail=@mail,phoneNumber=@phoneNumber,password=@password where id =@id";
                MySqlCommand command = new MySqlCommand(sql, dbConnection.GetConnection());

                command.Parameters.AddWithValue("@name", txtUName.Text);
                command.Parameters.AddWithValue("@surname", txtUSurname.Text);
                command.Parameters.AddWithValue("@mail", txtUMail.Text);
                command.Parameters.AddWithValue("@phoneNumber", txtUphone.Text);
                command.Parameters.AddWithValue("@password", txtUPsw.Text);
                command.Parameters.AddWithValue("@id", collectorID);

                command.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı");
                ShowCollectors();

            }
            catch
            {
                if (!(txtUphone.Text.Length == 10 && txtUphone.Text.All(char.IsDigit)))
                {
                    MessageBox.Show("Check Your Phone Number");

                }
                else if (!(txtUMail.Text.Contains("@")))
                {
                    MessageBox.Show("Check Your Mail Adress");
                }
            }
        }
        private void ShowCollectors()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "select name,surname,mail,phoneNumber,password,id from carcollector";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgCollector.DataSource = dataTable;
                dtgCollector.Columns["id"].Visible = false;
            }
            catch { MessageBox.Show("Hata"); }
        }
        private void HireCollector(string name, string surname, string mail, string phoneNumber, string password)
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "insert into carcollector (name,surname,mail,phoneNumber,status,password) values (@name,@surname,@mail,@phoneNumber,@status,@password)";
                using (MySqlCommand command = new MySqlCommand(sql, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@status", 0);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
                dbConnection.CloseConnection();
                ShowCollectors();
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch
            {
                MessageBox.Show("Telefon Numarası Kullanılmış");
            }

        }

        private void btnHireCol_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string surname = txtBoxSurname.Text;
            string phoneNumber = txtBoxPhoneNumber.Text;
            string mail = txtBoxMail.Text;
            string password = txtBoxPsw.Text;
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            {
                if (mail.Contains("@"))
                {
                    try
                    {
                        HireCollector(name, surname, mail, phoneNumber, password);
                        txtBoxName.Clear();
                        txtBoxSurname.Clear();
                        txtBoxPhoneNumber.Clear();
                        txtBoxMail.Clear();
                        txtBoxPsw.Clear();
                        MessageBox.Show("Kayıt İşlemi Başarılı");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bu Mail Adresi Daha önceden kullanılmış");
                        txtBoxMail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mail Adresinizi Kontrol Edin");
                    txtBoxMail.Clear();


                }
            }
            else
            {
                MessageBox.Show("Please Correct Your Phone Number");
                txtBoxPhoneNumber.Clear();

            }
        }

        private void dtgCollector_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dtgCollector.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtUName.Text = row.Cells[0].Value.ToString();
                    txtUSurname.Text = row.Cells[1].Value.ToString();
                    txtUMail.Text = row.Cells[2].Value.ToString();
                    txtUphone.Text = row.Cells[3].Value.ToString();
                    txtUPsw.Text = row.Cells[4].Value.ToString();
                    collectorID = Convert.ToInt32(row.Cells[5].Value);


                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }
        }


        private void FormBossCollector_Load(object sender, EventArgs e)
        {
            ShowCollectors();

        }

        private void btnUpdateCol_Click(object sender, EventArgs e)
        {
            UpdateCollector();

        }
    }
}
