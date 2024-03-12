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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class FormBossMechanic : Form
    {
        private DatabaseConnection dbConnection;
        private UserManager userManager;
        private int mechanicID;
        private int hireMecId;

        public FormBossMechanic(string name)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            userManager = new UserManager(dbConnection);
            this.Text = name;
            this.Tag = name + "ANA SAYFA";

        }
        private void FormHireMechanic_Load(object sender, EventArgs e)
        {
            ShowMechanics();
            ShowFreeMechs();
            ShowCarsNeedToFix();
        }
        private void ShowCarsNeedToFix()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "select * from cars where status=0 and inMechanic=1";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgNeedToFixCars.DataSource = dataTable;
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
        private void ShowMechanics()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "select name,surname,phoneNumber,password,mail,id from mechanics";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgMechanics.DataSource = dataTable;
                dtgMechanics.Columns["id"].Visible = false;
            }
            catch { MessageBox.Show("Hata"); }
        }
        private void ShowFreeMechs()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "select * from mechanics where status=0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgFreeMecs.DataSource = dataTable;
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
        private void GiveJobToMechanic(int mechanicID, int carID)
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "update cars set mechanicID=@mechanicID,status = @status where id=@carID";
                using (MySqlCommand command = new MySqlCommand(sql, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@mechanicID", mechanicID);
                    command.Parameters.AddWithValue("@status", 1);
                    command.Parameters.AddWithValue("@carID", carID);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                    command.CommandText = "UPDATE mechanics SET jobCount = jobCount + 1 WHERE id = @mechanicID";
                    command.Parameters.AddWithValue("@mechanicID", mechanicID);
                    command.ExecuteNonQuery();

                }

            }
            catch
            {
                MessageBox.Show("burası");

            }
            finally
            {
                ShowMechanics();
                ShowFreeMechs();
                ShowCarsNeedToFix();
                UpdateMechanicStatus();
                dbConnection.CloseConnection();
            }

        }
        private void HireMechanic(string name, string surname, string phoneNumber, string password, string mail)
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "insert into mechanics (name,surname,phoneNumber,status,password,mail) values (@name,@surname,@phoneNumber,@status,@password,@mail)";
                using (MySqlCommand command = new MySqlCommand(sql, dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@status", 0);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.ExecuteNonQuery();
                }
                dbConnection.CloseConnection();
                ShowMechanics();
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch
            {
                MessageBox.Show("Telefon Numarası Kullanılmış");
            }

        }

        private void UpdateMechanicStatus()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = "UPDATE mechanics\r\nSET status = CASE\r\n                WHEN jobCount >= 4 THEN 1\r\n                ELSE 0\r\n              END;";
                MySqlCommand cmd = new MySqlCommand(sql, dbConnection.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
            finally { dbConnection.CloseConnection(); }
        }
        private void UpdateMechanic()
        {
            try
            {
                dbConnection.OpenConnection();
                string sql = $"update mechanics set name = @name ,surname=@surname,mail=@mail,phoneNumber=@phoneNumber,password=@password where id =@id";
                MySqlCommand command = new MySqlCommand(sql, dbConnection.GetConnection());

                command.Parameters.AddWithValue("@name", txtUName.Text);
                command.Parameters.AddWithValue("@surname", txtUSurname.Text);
                command.Parameters.AddWithValue("@mail", txtUMail.Text);
                command.Parameters.AddWithValue("@phoneNumber", txtUphone.Text);
                command.Parameters.AddWithValue("@password", txtUPsw.Text);
                command.Parameters.AddWithValue("@id", mechanicID);

                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");
                ShowMechanics();

            }
            catch
            {
                if (!(txtUphone.Text.Length == 10 && txtUphone.Text.All(char.IsDigit)))
                {
                    MessageBox.Show("Check Your Phone Number");

                }
                else if (!(txtUMail.Text.Contains("@")))
                {
                    MessageBox.Show("Check Your Mail Adress");
                }
            }
        }

        private void dtgMechanics_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dtgMechanics.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtUName.Text = row.Cells[0].Value.ToString();
                    txtUSurname.Text = row.Cells[1].Value.ToString();
                    txtUphone.Text = row.Cells[2].Value.ToString();
                    txtUMail.Text = row.Cells[4].Value.ToString();
                    txtUPsw.Text = row.Cells[3].Value.ToString();
                    mechanicID = Convert.ToInt32(row.Cells[5].Value);


                }
            }
            catch
            {
                MessageBox.Show("Geçerli Bir Sekme Seçin");

            }

        }

        private void btnHireMec_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string surname = txtBoxSurname.Text;
            string phoneNumber = txtBoxPhoneNumber.Text;
            string mail = txtBoxMail.Text;
            string password = txtBoxPsw.Text;
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            {
                if (mail.Contains("@"))
                {
                    try
                    {
                        HireMechanic(name, surname, phoneNumber, password, mail);
                        txtBoxName.Clear();
                        txtBoxSurname.Clear();
                        txtBoxPhoneNumber.Clear();
                        txtBoxMail.Clear();
                        txtBoxPsw.Clear();
                        MessageBox.Show("Kayıt İşlemi Başarılı");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bu Mail Adresi Daha önceden kullanılmış");
                        txtBoxMail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mail Adresinizi Kontrol Edin");
                    txtBoxMail.Clear();


                }
            }
            else
            {
                MessageBox.Show("Please Correct Your Phone Number");
                txtBoxPhoneNumber.Clear();

            }
        }

        private void btnUpdateMec_Click(object sender, EventArgs e)
        {
            UpdateMechanic();
        }

        private void dtgFreeMecs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dtgFreeMecs.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtBoxMecID.Text = row.Cells[0].Value.ToString();
                    hireMecId = Convert.ToInt32(row.Cells[0].Value);
                    txtBoxMecName.Text = row.Cells[1].Value.ToString();
                    txtBoxMecSurname.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
        }

        private void dtgNeedToFixCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dtgNeedToFixCars.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    txtBoxCarID.Text = row.Cells[0].Value.ToString();
                    txtBoxCarPlate.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
        }

        private void btnGiveJobToMec_Click(object sender, EventArgs e)
        {


            try
            {
                int jobMecID = int.Parse(txtBoxMecID.Text);
                int jobCarID = int.Parse(txtBoxCarID.Text);

                GiveJobToMechanic(jobMecID, jobCarID);
                UpdateMechanicStatus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir Değer Seçin");
            }
            finally
            {
                txtBoxCarID.Clear();
                txtBoxCarPlate.Clear();
                txtBoxMecID.Clear();
                txtBoxMecName.Clear();
                txtBoxMecSurname.Clear();
            }
        }
    }
}

