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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;

namespace WinFormsApp3
{
    public partial class FormCollectorMain : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        private string mail;
        private int carID;
        private DateTime selectedDateTime;

        public FormCollectorMain(string mail,string username)
        {
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
            this.mail = mail;
            this.Text = username;
            this.Tag = username + " Ana Sayfa";

        }

        private void FormCollectorMain_Load(object sender, EventArgs e)
        {
            ShowJobs();
        }

        private void ShowJobs()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = $"SELECT c.name as CustomerName, c.surname as CustomerSurname,c.mail,c.phoneNumber,cars.plate,cars.description,cars.id,cars.address from cars inner join carcollector as col on cars.collectorID=col.id inner join customercars as cc on cars.id=cc.carID inner join customers as c on cc.customerID = c.id where col.mail='{mail}' and cars.needCollector = 1 and cars.status=0";
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
                adapter.Fill(dataTable);
                dgtCollectorJobs.DataSource = dataTable;
                dgtCollectorJobs.Columns["id"].Visible = false;

            }
            catch { MessageBox.Show("Hata"); }
            finally
            {
                dbConnection.CloseConnection();

            }

        }
        private void FinishJob()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "UPDATE cars SET arrivalDate = @arrivalDate, needCollector=0,inMechanic=1 WHERE cars.id = @CarID";

                MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());

                command.Parameters.AddWithValue("@arrivalDate", dateTimePickerArrival.Value) ;
                command.Parameters.AddWithValue("@CarID", carID);

                command.ExecuteNonQuery();
                ShowJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Tamamlanmadı: " + ex.Message);
            }
            finally { dbConnection.CloseConnection(); }
        }

        private void dgtCollectorJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dgtCollectorJobs.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtBoxName.Text = row.Cells[0].Value.ToString();
                    txtBoxSurname.Text = row.Cells[1].Value.ToString();
                    txtBoxMail.Text = row.Cells[2].Value.ToString();
                    txtBoxPhoneNumber.Text = row.Cells[3].Value.ToString();
                    txtBoxPlate.Text = row.Cells[4].Value.ToString();
                    txtBoxDesc.Text = row.Cells[5].Value.ToString();
                    carID = Convert.ToInt32(row.Cells[6].Value);
                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }
        }

        private void btnCompleteJob_Click(object sender, EventArgs e)
        {
            FinishJob();
        }

 
    }
}
