using System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerTracker
{
    class Trucks
    {
        public static Boolean setWeight(String newWeight, int accountID)
        {
            //Connect to the database and run the Update command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "UPDATE Trucks SET weight = " + newWeight + " where accountID = " + accountID + ";";
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            conn.Close();
            Console.WriteLine("Done.");

            //return true by default
            return true;
        }

        public static String getWeight(int accountID)
        {
            DataTable myTable = new DataTable();
            String sql = "", wght = "1";
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                sql = "Select weight from Trucks where accountID = " + accountID + ";";
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column elements into toReturn 
                if (myReader.Read())
                {
                    wght = myReader["weight"].ToString();
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done");

            return wght;
        }
        public static string getMileage(int accountID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT mileage FROM Trucks WHERE accountID = " + accountID + ";"; // Need to get the user's id
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If an Account was inserted, return true, if not, it returns false by default
                if (myReader.Read())
                {
                    return myReader["mileage"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by default
            return "Error";
        }

        public static bool updateDistance(decimal distance, int accountID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE Trucks SET mileage = " + distance + " where accountID = " + accountID + ";"; // Need to get the user's id
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //If an Account was inserted, return true, if not, it returns false by default
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by default
            return false;
        }

        public static string getDate(int accountID)
        {
            string connStr = "server=dkmpi.hopto.org;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to Database");
                conn.Open();
                string sql = "SELECT serviceDate AS 'serviceDate' from Trucks WHERE accountID = " + accountID + " ;"; // Need to get the user's id
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If an Account was inserted, return true, if not, it returns false by default
                if (myReader.Read())
                {
                    return ((DateTime)(myReader["serviceDate"])).ToString("MM/dd/yyyy");


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by default
            return "Error";
        }

        public static bool setDate(int year, int month, int day, int accountID)
        {
            string connStr = "server=dkmpi.hopto.org;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to Database");
                conn.Open();
                string sql = "UPDATE Trucks SET serviceDate = '" + year + "-" + month + "-" + day + "' where accountID = " + accountID + ";"; // Need to get the user's id
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //If an Account was inserted, return true, if not, it returns false by default
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by default
            return false;
        }
    }
}