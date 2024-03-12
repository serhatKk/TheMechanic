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
    public partial class FormCustomerMain : Form
    {
        private string mail;
        private DatabaseConnection dbConnection;
        private UserManager userManager;

        public FormCustomerMain(string mail, string username)
        {
            InitializeComponent();
            this.Text = username;
            this.mail = mail;
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userManager.CheckCustomerHasCarInMechanic(mail))
            {
                FormCustomer frm = new FormCustomer(mail, this.Text);
                ((Form_Main)this.Owner).OpenChildForm(frm);


            }
            else
            {
                MessageBox.Show("Serviste Arabanız Bulunmamaktadır");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCarRegister formCarRegister = new FormCarRegister(mail, this.Text);

            ((Form_Main)this.Owner).OpenChildForm(formCarRegister);
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
   
            if (userManager.CheckCustomerHasCarRepaired(mail))
            {
                FormGetMyCar formGetMyCar = new FormGetMyCar(mail, this.Text);

                ((Form_Main)this.Owner).OpenChildForm(formGetMyCar);


            }
            else
            {
                MessageBox.Show("Serviste Arabanız Bulunmamaktadır");
            }
        }
    }
}
