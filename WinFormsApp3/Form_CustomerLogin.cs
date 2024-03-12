using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form_CustomerLogin : Form
    {

        private DatabaseConnection dbConnection;
        private UserManager userManager;

        public Form_CustomerLogin()
        {
            InitializeComponent();

            this.Text = null;
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);


        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = usrnameTxtBox.Text;
            string password = pswTextBox.Text;

            if (userManager.ValidateUser(mail, password))
            {
                string customerName = userManager.GetCustomerName(mail, password);
                FormCustomerMain frm = new FormCustomerMain(mail, customerName);

                ((Form_Main)this.Owner).isCustomerLoggedIn = true;
                ((Form_Main)this.Owner).customerMail = mail;
                ((Form_Main)this.Owner).customerPassword = password;
                ((Form_Main)this.Owner).customerName = customerName;

                ((Form_Main)this.Owner).OpenChildForm(frm);
            }
            else
            {
                MessageBox.Show("Sisteme Kayıt Olmadıysanız Kayıt Olunuz.", "Geçersiz kullanıcı adı veya şifre.", MessageBoxButtons.OK);

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form_CustomerRegister form = new Form_CustomerRegister();
            ((Form_Main)this.Owner).OpenChildForm(form);
        }


    }
}