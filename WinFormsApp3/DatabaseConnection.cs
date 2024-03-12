using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

public class DatabaseConnection
{
    private MySqlConnection connection;
    private string connectionString;

    public DatabaseConnection()
    {
         connectionString = "Server=localhost;Database=mechanic;User ID=root;Password=19032048;";
         connection = new MySqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
            connection.Open();
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
            connection.Close();
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}

public class UserManager
{
    private DatabaseConnection databaseConnection;

    public UserManager(DatabaseConnection dbConnection)
    {
        databaseConnection = dbConnection;
    }
    #region Boss
    public bool ValidateBoss(string username, string password)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM boss WHERE name='{username}' AND password='{password}'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        if (isValid)
        {
            return isValid;
        }
        else
        {
            MessageBox.Show("Lütfen Bilgilerinizi Kontrol edin");
            return isValid;
        }
    }
    public string GetBossName(string username, string password)
    {
        try
        {
            string query = "SELECT name,surname FROM boss WHERE name=@username AND password=@password";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["name"].ToString() + " " + reader["surname"].ToString();

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return null;
    }
    public int GetBossID(string username)
    {
        try
        {
            string query = "SELECT idBoss FROM boss WHERE name=@username";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        return Convert.ToInt32(reader["id"]);

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return 0;
    }
    #endregion


    /*--------------------------------------------------------------*/
    #region Customer

    public bool ValidateUser(string username, string password)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM customers WHERE mail='{username}' AND password='{password}'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        return isValid;
    }
    public string GetCustomerName(string username, string password)
    {
        try
        {
            string query = "SELECT name,surname FROM customers WHERE mail=@username AND password=@password";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["name"].ToString() +" "+ reader["surname"].ToString() ;

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return null;
    }
    public int GetCustomerID(string username)
    {
        try
        {
            string query = "SELECT id FROM customers WHERE mail=@username";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                          
                        return Convert.ToInt32(reader["id"]);

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return 0;
    }
    #endregion


    /*--------------------------------------------------------------*/
    #region Mechanic

    public bool ValidateMechanic(string mail, string password)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            // Örnek bir sorgu (şifre doğrulama gibi)
            string query = $"SELECT COUNT(*) FROM mechanics WHERE mail='{mail}' AND password='{password}'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        if (isValid)
        {
            return isValid;
        }
        else
        {
            MessageBox.Show("Lütfen Bilgilerinizi Kontrol edin\n!!Sisteme Kayıt Olmadıysanız Önce Sisteme Kayıt Olun.");
            return isValid;
        }
       
    }
    public string GetMechanicName(string username, string password)
    {
        try
        {
            string query = "SELECT name,surname FROM mechanics WHERE mail=@username AND password=@password";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["name"].ToString() + " " + reader["surname"].ToString();

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return null;
    }
    public int GetMechanicID(string username)
    {
        try
        {
            string query = "SELECT id FROM mechanics WHERE mail=@username";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        return Convert.ToInt32(reader["id"]);

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return 0;
    }
    #endregion


    /*--------------------------------------------------------------*/
    #region Collector

    public bool ValidateCollector(string username, string password)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM carcollector WHERE mail='{username}' AND password='{password}'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        if (isValid)
        {
            return isValid;
        }
        else
        {
            MessageBox.Show("Lütfen Bilgilerinizi Kontrol edin\n !!Sisteme Kayıt Olmadıysanız Önce Sisteme Kayıt Olun.");
            return isValid;
        }
    }
    public string GetCollectorName(string username, string password)
    {
        try
        {
            string query = "SELECT name,surname FROM carcollector WHERE mail=@username AND password=@password";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["name"].ToString() + " " + reader["surname"].ToString();

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return null;
    }
    public int GetCollectorID(string username)
    {
        try
        {
            string query = "SELECT id FROM carcollector WHERE mail=@username";

            databaseConnection.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        return Convert.ToInt32(reader["id"]);

                    }

                }

            }
        }
        catch { MessageBox.Show("Kullanıcı Bulunamadı"); }
        finally { databaseConnection.CloseConnection(); }
        return 0;
    }

    /*--------------------------------------------------------------*/

    #endregion

    public bool CheckCustomerHasCarInMechanic(string mail)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM customercars as cc inner join customers as c on cc.customerID=c.id inner join cars on cc.carID=cars.id WHERE c.mail='{mail}' and cars.inMechanic=1";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        return isValid;
    }
    public bool CheckCustomerHasCarRepaired(string mail)
    {
        bool isValid = false;

        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM customercars as cc inner join customers as c on cc.customerID=c.id inner join cars on cc.carID=cars.id WHERE c.mail='{mail}' and cars.inMechanic=1 and cars.status=2";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        return isValid;
    }

    public bool CheckCustomerCarCount(string mail)
    {

        bool isValid = false;
        try
        {
            databaseConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM customercars as cc inner join cars on cc.carID = cars.id inner join customers as c on cc.customerID=c.id WHERE c.mail='{mail}'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection.GetConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            isValid = count > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            databaseConnection.CloseConnection();
        }
        return isValid;
        }

}

