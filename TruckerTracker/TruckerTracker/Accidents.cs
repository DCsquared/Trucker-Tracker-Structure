using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerTracker
{
    public class Accidents
    {
        
        public static Boolean logAccident(int cars, String notes, String atype, int accountID)
        {
            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                String sql = "INSERT INTO Accidents (date, type, cars, notes, accountID) VALUES ('" + date + "', '" + atype + "', " + cars + ", '" + notes + "'," + accountID + ");";
                Console.WriteLine(sql);
                Console.WriteLine(date);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                //If a report was inserted, return true, if not, it returns false by default
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

        public static String displayLogs(int accountID)
        {
            String sql = "", dates = "";
            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();

            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                sql = "Select date from Accidents where accountID = " + accountID + ";";
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);

                foreach (DataRow row in myTable.Rows)
                {
                    dates += row["date"].ToString() + "|";
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by default
            return dates;
        }

        public static String requestLog(String dateS, int accountID)
        {
            String sql = "", report = "";
            Console.WriteLine(dateS);
            DataTable myTable = new DataTable();
            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                sql = "Select * from Accidents where date = '" + dateS + "' and accountID = " + accountID + ";";
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the dates into dates 
                if (myReader.Read())
                {
                    Console.WriteLine("storing data in string");
                    report = myReader["cars"].ToString() + "|";
                    report += myReader["type"].ToString() + "|";
                    report += myReader["notes"].ToString();
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return false by report
            return report;
        }
    }
}