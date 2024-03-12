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
    public partial class FormMechanicLogin : Form
    {
        public DatabaseConnection dbConnection;
        public UserManager userManager;

        public FormMechanicLogin()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = usrnameTxtBox.Text;
            string password = txtBoxPsw.Text;
            if (userManager.ValidateMechanic(mail, password))
            {
                string mechanicName = userManager.GetMechanicName(mail, password);
                Form_Mechanic_Main form = new Form_Mechanic_Main(mail,mechanicName);

                ((Form_Main)this.Owner).isMechanicLoggedIn=true;
                ((Form_Main)this.Owner).mechanicMail = mail;
                ((Form_Main)this.Owner).mechanicPassword = password;
                ((Form_Main)this.Owner).mechanicName = mechanicName;

                ((Form_Main)this.Owner).OpenChildForm(form);
            }
 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Contact With Your Boss");

        }
    }
}
