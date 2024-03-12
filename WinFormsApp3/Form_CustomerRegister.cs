using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form_CustomerRegister : Form
    {
        private DatabaseConnection dbConnection;
        private string name;
        private string surname;
        private string mail;
        private string password;
        private string phoneN;
        public Form_CustomerRegister()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();


        }
        public void SaveCustomer(string name, string surname, string mail, string phoneNumber,string password)
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO customers (name, surname, mail, phoneNumber,password) VALUES (@name, @surname, @mail, @phoneNumber,@password)";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
            dbConnection.CloseConnection();
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            mail = textBoxMail.Text;
            phoneN = textBoxPhoneNumber.Text;
            password = textBoxPassword.Text;
            phoneN = textBoxPhoneNumber.Text;

            if (phoneN.Length == 10 && phoneN.All(char.IsDigit))
            {
                if (mail.Contains("@"))
                { 
                    try
                    {
                        SaveCustomer(name, surname, mail, phoneN, password);
                        MessageBox.Show("Müşteri başarıyla kaydedildi. Login Sayfasına Yönlendiriliyorsunuz");
                        Form_CustomerLogin form3 = new Form_CustomerLogin();
                        ((Form_Main)this.Owner).OpenChildForm(form3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bu Mail Adresi Daha önceden kullanılmış");
                        textBoxMail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mail Adresinizi Kontrol Edin");
                    textBoxMail.Clear();

                    
                }
            }
            else
            {
                MessageBox.Show("Please Correct Your Phone Number");
                textBoxPhoneNumber.Clear(); 
                
            }

        
        }
    }
}
