using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MyTrade
{
    class SQLInteraction
    {
        #region Variables
        static MySqlConnection con = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();

        private static MySqlDataReader dr = null;

        static int uEditUID;
        #endregion

        //Get ticker List from database (WatchList)
        public static List<string> uGetTickerWL()
        {
            List<string> list = new List<string>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT ticker FROM myTrade_UserWL WHERE UID = '" + SQLInteraction.GetUID() + "';";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
            return list;
        }

        public static void FillIVList()
        {
            StoreVariables.tickerIV.Clear();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM myTrade_UserIV WHERE UID = '" + SQLInteraction.GetUID() + "';";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StoreVariables.tickerIV.Add(new uInvestments(dr.GetString(2), dr.GetDouble(3), dr.GetDouble(4), dr.GetDouble(5)));
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }


        #region Easily execute SQL-Commands
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

        #endregion


        //Check if Login is correct
        public static bool uLogin(string username, string password)
        {
            try
            {
                string temp = CMDExecuteScalar("SELECT pwd FROM myTrade_Login WHERE user = '" + username + "';");
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
        public static void uCreateNewUser(string surname, string prename, string email, string username, string password)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO myTrade_Login(surname, prename, email, user, pwd) VALUES ('" + surname + "', '" + prename + "', '" + email + "', '" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
        }

        public static bool UsernameExists(string uUsername)
        {
            if (CMDExecuteScalar("SELECT user FROM myTrade_Login WHERE user = '" + uUsername + "';").Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void uUpdateUser(string surname, string prename, string email, string username, string password)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE myTrade_Login SET surname = '" + surname + "', prename = '" + prename + "', email = '" + email + "', user = '" + username + "', pwd = '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "' WHERE UID = " + GetUID() + ";";
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

        public static void SetUID(int UID)
        {
            uEditUID = UID;
        }
        public static string GetUID()
        {
            return uEditUID.ToString();
        }
        #endregion
    }
}
