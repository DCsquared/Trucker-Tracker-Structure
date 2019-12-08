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
    public class TTStruct
    {
        //gets the account id of the user if they are in the database and returns the id number
        public static int passLoginInfo(String username, String password)
        {
            int returnID = -1;
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT id FROM Accounts WHERE username = '" + username + "' AND password = '" + password + "' ; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successful, store the query in returnID
                if (myReader.Read())
                {
                    returnID = int.Parse(myReader["id"].ToString());
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            conn.Close();
            Console.WriteLine("Done.");
            return returnID;
        }

        //grabs the first and last name of the current signed in user
        public static String GetName(int accountID)
        {
            String name = "No one";
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT fname, lname FROM Accounts WHERE id = " + accountID + " ; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column values in name
                if (myReader.Read())
                {
                    name = myReader["fname"].ToString() + " ";
                    name += myReader["lname"].ToString();
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            conn.Close();
            Console.WriteLine("Done.");
            return name;
        }
    }
}