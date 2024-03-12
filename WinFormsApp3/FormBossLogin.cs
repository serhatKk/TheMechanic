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
    public partial class FormBossLogin : Form
    {
        private UserManager userManager;
        private DatabaseConnection dbConnection;

        public FormBossLogin()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPsw.Text;
            if (userManager.ValidateBoss(username, password))
            {

                string bossName = userManager.GetBossName(username, password);
                FormBossMain form3 = new FormBossMain(username, bossName);

                ((Form_Main)this.Owner).isBossLoggedIn = true;
                ((Form_Main)this.Owner).bossUsername = username;
                ((Form_Main)this.Owner).bossPassword = password;
                ((Form_Main)this.Owner).bossName = bossName;

                ((Form_Main)this.Owner).OpenChildForm(form3);

            }
        }
    }
}
