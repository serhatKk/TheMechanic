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
using System.Xml.Linq;

namespace WinFormsApp3
{
    public partial class FormCarRegister : Form
    {
        private string mail;
        private UserManager userManager;
        private DatabaseConnection dbConnection;
        private int carID;
        private int customerID;
        private int newCarId;

        public FormCarRegister(string mail,string username)
        {
            this.mail = mail;
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            InitializeComponent();
            this.Text = username;
        }
        private void FormCarRegister_Load(object sender, EventArgs e)
        {
            ShowCars();
            FillComboBox();
            ShowCollectingCars();
        }
        private int GetCustomerIdByMail(string mail)
        {
            dbConnection.OpenConnection();
            string query = $"SELECT id FROM customers WHERE mail = '{mail}'";
            MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
            object result = command.ExecuteScalar();
            dbConnection.CloseConnection();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1;
            }
        }
        private void ShowCars()
        {
            dbConnection.OpenConnection();
            string query = $"SELECT cars.plate,cars.brand,cars.model ,cars.id,c.id FROM customercars as cc inner join customers as c on cc.customerID = c.id inner join cars on cc.carID=cars.id where c.mail ='{mail}' and cars.needCollector=0";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["id1"].Visible = false;
            dbConnection.CloseConnection();

        }
        private void ShowCollectingCars()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = $"SELECT cars.plate,cars.brand,cars.model ,cars.id,c.id FROM customercars as cc inner join customers as c on cc.customerID = c.id inner join cars on cc.carID=cars.id where c.mail ='{mail}' and cars.needCollector=1";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection());
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns["id"].Visible = false;
                dataGridView2.Columns["id1"].Visible = false;
                dbConnection.CloseConnection();
            }
            catch { MessageBox.Show("Aq Hatası"); }
        }
        private void RegisterCar(string plate, string brand, string model, string description, int collectorID,string address)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "INSERT INTO cars (plate, brand, model, status, description, collectorID, needCollector,address) VALUES (@plate, @brand, @model, @status, @description, @collectorID, @needCollector , @address)";
                using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@plate", plate);
                    command.Parameters.AddWithValue("@brand", brand);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@status", 0);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@collectorID", collectorID);
                    command.Parameters.AddWithValue("@needCollector", 1);
                    command.Parameters.AddWithValue("@address", address);

                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT LAST_INSERT_ID()";
                    newCarId = Convert.ToInt32(command.ExecuteScalar());
                    MatchCarWithCustomer(newCarId, GetCustomerIdByMail(mail));

                }
                dbConnection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        private void MatchCarWithCustomer(int id, int cid)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "INSERT INTO customercars (customerID, carID) VALUES (@customerID,@carID)";
                using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@customerID", cid);
                    command.Parameters.AddWithValue("@carID", id);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex) { MessageBox.Show("a", ex.Message); }
            dbConnection.CloseConnection();

        }

        private void FillComboBox()
        {
            dbConnection.OpenConnection();
            // SQL 
            string query = "SELECT id,name FROM carcollector where status=0 ";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbConnection.GetConnection()))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.NewRow();


                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }

        }


        private void UpdateNeedCollectorValue()
        {
            string query = "UPDATE cars SET status=0, needCollector = 1 WHERE id = @CarID";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            cmd.Parameters.AddWithValue("@CarID", carID);

            dbConnection.OpenConnection();
            cmd.ExecuteNonQuery();
            dbConnection.CloseConnection();
        }

        private bool IsCarExists(string plate)
        {
            dbConnection.OpenConnection();
            string query = "SELECT COUNT(*) FROM cars WHERE plate = @plate ";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@plate", plate);
                int count = Convert.ToInt32(command.ExecuteScalar());
                dbConnection.CloseConnection();
                return count > 0;
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    textBoxPlate.Text = row.Cells[0].Value.ToString();
                    textBoxBrand.Text = row.Cells[1].Value.ToString();
                    textBoxModel.Text = row.Cells[2].Value.ToString();
                    carID = Convert.ToInt32(row.Cells[3].Value);
                    customerID = Convert.ToInt32(row.Cells[4].Value);

                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string plate = textBoxPlate.Text;
            string brand = textBoxBrand.Text;
            string model = textBoxModel.Text;
            string desc = textBoxDesc.Text;
            string address = txtBoxAddress.Text;
            int collector = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                if (IsCarExists(plate))
                {
                    UpdateNeedCollectorValue();
                    MessageBox.Show("Aracınız Sistemde Kayıtlı. Arabanızı Almaya Geliyoruz...");
                    ShowCars();
                    ShowCollectingCars();

                }
                else
                {
                    RegisterCar(plate, brand, model, desc, collector,address);
                    MessageBox.Show("Araç başarıyla kaydedildi. Servis gelecek.");
                    ShowCars();
                    ShowCollectingCars();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Tamamlanmadı aq");
            }
            ShowCollectingCars();
        }


    }
}
