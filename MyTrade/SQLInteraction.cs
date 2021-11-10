using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SWP-Jahresprojekt-2021-22
{
    public class SQLInteraction
    {
        static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        private static DataTable temp = new DataTable();

        static bool addUser;
        static int uEditUID;
        static string username;
        static bool editvehicle;

        //Check if connection to server is possible
        public static bool TryConnection()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public static DataTable GetDataTable(string command)
        {
            try
            {
                temp = new DataTable();
                sda.SelectCommand = new SqlCommand(command, con);
                sda.Fill(temp);
                return temp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                temp = new DataTable();
                return temp;
            }
        }

        public static void SaveChanges()
        {
            try
            {
                con.Open();
                sda.UpdateCommand = builder.GetUpdateCommand();
                sda.Update(temp);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }


        //Easily execute SQL-Commands
        public static void CMDExecuteNonQuery(string UserCommand)
        {
            try
            {
                con.Open();
                cmd.CommandText = UserCommand;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static string CMDExecuteScalar(string UserCommand)
        {
            string temp = "";
            try
            {
                con.Open();
                cmd.CommandText = UserCommand;
                temp = (string)cmd.ExecuteScalar();
                if (temp == null)
                {
                    temp = "";
                }
                con.Close();
                return temp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
                return temp;
            }
        }
        public static int CMDExecuteScalarInt(string UserCommand)
        {
            int temp = 0;
            try
            {
                con.Open();
                cmd.CommandText = UserCommand;
                temp = (int)cmd.ExecuteScalar();


                con.Close();
                return temp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
                return temp;
            }
        }
        public static bool CMDExecuteScalarBool(string UserCommand)
        {
            bool temp = false;
            try
            {
                con.Open();
                cmd.CommandText = UserCommand;
                temp = (bool)cmd.ExecuteScalar();
                con.Close();
                return temp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
                return temp;
            }
        }
        public static DateTime CMDExecuteScalarDateTime(string UserCommand)
        {
            DateTime temp = new DateTime(2000, 01, 01);
            try
            {
                con.Open();
                cmd.CommandText = UserCommand;
                temp = (DateTime)cmd.ExecuteScalar();
                if (temp == null)
                {
                    temp = new DateTime(2000, 01, 01); ;
                }
                con.Close();
                return temp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
                return temp;
            }
        }


        //Check if Login is correct
        public static bool uLogin(string username, string password)
        {
            try
            {
                string temp = CMDExecuteScalar("SELECT [pwd] FROM caradmin_login WHERE [user] = '" + username + "';");
                if (BCrypt.CheckPassword(password, temp))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username does not exist!");
                return false;
            }
        }


        //Create new login easily
        public static void uCreateNewUser(string surname, string prename, string username, string password, string hasAdmin)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO caradmin_login VALUES ('" + surname + "', '" + prename + "', '" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "', '" + hasAdmin + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static void uCreateNewCar(string brand, string model, int acceleration, string fueltype, string color, int sits, string drivetype, int ps, int topspeed, int ccm, int parkingnumber)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO caradmin_car VALUES ('" + brand + "', '" + model + "', '" + acceleration + "', '" + fueltype + "', '" + color + "', '" + sits + "', '" + drivetype + "', '" + ps + "', '" + topspeed + "', '" + ccm + "', '" + parkingnumber + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static void uCreateNewMoto(string brand, string model, int acceleration, int gears, string color, int sits, int weight, int ps, int topspeed, int ccm, int parkingnumber)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO caradmin_moto VALUES ('" + brand + "', '" + model + "', '" + acceleration + "', '" + gears + "', '" + color + "', '" + sits + "', '" + weight + "', '" + ps + "', '" + topspeed + "', '" + ccm + "', '" + parkingnumber + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static void uUpdateCar(string brand, string model, int acceleration, string fueltype, string color, int sits, string drivetype, int ps, int topspeed, int ccm, int parkingnumber)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE caradmin_car SET brand = '" + brand + "', model = '" + model + "', acceleration = '" + acceleration + "', fueltype = '" + fueltype + "', color = '" + color + "', sits = '" + sits + "', drivetype = '" + drivetype + "', ps = '" + ps + "', [top speed] = '" + topspeed + "', ccm = '" + ccm + "', parkingnumber = '" + parkingnumber + "'WHERE [CID] = " + GetuEditID() + ";";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static void uUpdateMoto(string brand, string model, int acceleration, int gears, string color, int sits, int weight, int ps, int topspeed, int ccm, int parkingnumber)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE caradmin_moto SET brand = '" + brand + "', model = '" + model + "', acceleration = '" + acceleration + "', gears = '" + gears + "', color = '" + color + "', sits = '" + sits + "', weight = '" + weight + "', ps = '" + ps + "', [top speed] = '" + topspeed + "', ccm = '" + ccm + "', parkingnumber = '" + parkingnumber + "'WHERE [CID] = " + GetuEditID() + ";";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }
        public static void uUpdateUser(string surname, string prename, string username, string password, string hasAdmin, bool alreadyHashed)
        {
            try
            {
                con.Open();
                if (alreadyHashed)
                {
                    cmd.CommandText = "UPDATE caradmin_login SET surname = '" + surname + "', prename = '" + prename + "', [user] = '" + username + "', [pwd] = '" + password + "', [hasAdmin] = '" + hasAdmin + "' WHERE [UID] = " + GetuEditID() + ";";
                }
                else
                {
                    cmd.CommandText = "UPDATE caradmin_login SET surname = '" + surname + "', prename = '" + prename + "', [user] = '" + username + "', [pwd] = '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "', [hasAdmin] = '" + hasAdmin + "' WHERE [UID] = " + GetuEditID() + ";";
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }


        #region Getter/Setter (Java-Style)
        public static void SetConnectionString(string usercon)
        {
            try
            {
                con.ConnectionString = usercon;
                cmd.Connection = con;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static string GetConnectionString()
        {
            return con.ConnectionString;
        }

        public static void SetAddUser(bool temp)
        {
            addUser = temp;
        }
        public static bool GetAddUser()
        {
            return addUser;
        }

        public static void SetuEditID(int ID)
        {
            uEditUID = ID;
        }
        public static string GetuEditID()
        {
            return uEditUID.ToString();
        }

        public static void SetuUsernameLogin(string u)
        {
            username = u;
        }
        public static string GetuUsernameLogin()
        {
            return username;
        }

        public static void SetEditveh(bool temp)
        {
            editvehicle = temp;
        }
        public static bool GetEditveh()
        {
            return editvehicle;
        }
        #endregion
    }
}


