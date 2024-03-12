using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FormCollectorLogin : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        public FormCollectorLogin()
        {
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
        }

        private void btnCollectorLogin_Click(object sender, EventArgs e)
        {
            string mail = txtBoxUsername.Text;
            string password = txtBoxPsw.Text;

            if (userManager.ValidateCollector(mail, password))
            {
                string collectorName = userManager.GetCollectorName(mail, password);
                FormCollectorMain form = new FormCollectorMain(mail, collectorName);

                ((Form_Main)this.Owner).isCollectorLoggedIn = true;
                ((Form_Main)this.Owner).collectorMail = mail;
                ((Form_Main)this.Owner).collectorPassword = password;
                ((Form_Main)this.Owner).collectorName = collectorName;

                ((Form_Main)this.Owner).OpenChildForm(form);
            }

        }

        private void btnCollectorRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Patronunuza Danışın");

        }
    }

}
