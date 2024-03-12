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
    public partial class FormBossMain : Form
    {

        public FormBossMain(string username, string password)
        {
            InitializeComponent();
            this.Text = username;
            this.Tag = username + " Ana Sayfa";

        }

        private void btnMec_Click(object sender, EventArgs e)
        {
            FormBossMechanic frm = new FormBossMechanic(this.Text);
            ((Form_Main)this.Owner).OpenChildForm(frm);
        }

        private void btnCollectors_Click(object sender, EventArgs e)
        {
            FormBossCollector collector = new FormBossCollector();
            ((Form_Main)this.Owner).OpenChildForm(collector);

        }
    }
}
