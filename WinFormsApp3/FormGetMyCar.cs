using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp3
{
    public partial class FormGetMyCar : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        private string mail;
        private int carID;

        public FormGetMyCar(string mail, string name)
        {
            this.mail = mail;
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
            this.Text = name;
            this.Tag = name + "Ana Sayfa ";

        }


        private void FormGetMyCar_Load(object sender, EventArgs e)
        {
            ShowCars();
        }
        private void MecCompleted(int carID) 
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "UPDATE cars set mechanicID=0,deliveryDate = @deliveryDate ,inMechanic=0 where id=@CarID ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@deliveryDate", DateTime.Now) ;
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Tamamlandı");
                ClearAllTextBoxes();
                ShowCars();

            }
            catch
            {
                MessageBox.Show("İşlem Tamamlanmadı Tekrar Deneyiniz..");
            }
            finally { dbConnection.CloseConnection(); }

        }
        private void ShowCars()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = $"SELECT c.name,c.surname,cars.plate, m.name as mechanicName ,m.surname, m.mail,m.phoneNumber,cars.brand,cars.model,cars.description,cars.fixCost as price ,cars.id FROM customercars as cc inner join customers as c on cc.customerID = c.id inner join cars on cc.carID=cars.id inner join mechanics as m on cars.mechanicID= m.id where c.mail ='{mail}' and cars.inMechanic=1 and cars.status=2";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { dbConnection.CloseConnection(); }
        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            MecCompleted(carID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    textBoxCusName.Text = row.Cells[0].Value.ToString();
                    textBoxPlate.Text = row.Cells[2].Value.ToString();
                    textBoxBrand.Text = row.Cells[7].Value.ToString();
                    textBoxModel.Text = row.Cells[8].Value.ToString();
                    textBoxDesc.Text = row.Cells[9].Value.ToString();
                    textBoxCost.Text = row.Cells[10].Value.ToString();
                    carID = Convert.ToInt32(row.Cells[11].Value);

                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }
        }
        private void ClearAllTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }
    }
}
