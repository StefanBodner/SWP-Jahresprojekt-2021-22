using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyTrade
{
    public class SQLInteraction
    {
        static MySqlConnection con = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        private static MySqlDataAdapter sda = new MySqlDataAdapter();
        private static MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
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
                sda.SelectCommand = new MySqlCommand(command, con);
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
                string temp = CMDExecuteScalar("SELECT [pwd] FROM mytrade_UserData WHERE [user] = '" + username + "';");
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
                MessageBox.Show("Username does not exis t!");
                return false;
            }
        }


        //Create new login easily
        public static void uCreateNewUser(string surname, string prename, string username, string password)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Mytrade_UserData (surname,prename,username,password) VALUES ('" + surname + "', '" + prename + "', '" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }


        public static void uUpdateUser(string surname, string prename, string username, string password, bool alreadyHashed)
        {
            try
            {
                con.Open();
                if (alreadyHashed)
                {
                    cmd.CommandText = "UPDATE mytrade_UserData SET surname = '" + surname + "', prename = '" + prename + "', [user] = '" + username + "', [pwd] = '" + password + "' WHERE [UID] = " + GetuEditID() + ";";
                }
                else
                {
                    cmd.CommandText = "UPDATE mytrade_UserData SET surname = '" + surname + "', prename = '" + prename + "', [user] = '" + username + "', [pwd] = '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "' WHERE [UID] = " + GetuEditID() + ";";
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


