using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerTracker
{
    class Routes
    {
        public static DataTable LoadRoutes(int routeID)
        {
            //toReturnDataTable is the table that will be returned
            DataTable  toSetDataTable = new DataTable();

            //Connect to the database and make the query
            string sql = "SELECT stopNumber AS `Stop Number`, stop AS `Stop` FROM Stops WHERE routeID =" + routeID + ";";

            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(toSetDataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return toSetDataTable;
        }
        public static int GetCurrentRoute(int accountID)
        {
            int returnRoute = 0;
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT id FROM Routes WHERE accountID = " + accountID + " ; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column elements into toReturn 
                if (myReader.Read())
                {
                    returnRoute = int.Parse(myReader["id"].ToString());
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            conn.Close();
            Console.WriteLine("Done.");
            return returnRoute;
        }

        public static String GetCurrentStop(int routeID)
        {
            String currentStop = "";
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT stop FROM Stops WHERE routeID = " + routeID + " AND stopNumber = 1; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column elements into toReturn 
                if (myReader.Read())
                {
                    currentStop = myReader["stop"].ToString();
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            conn.Close();
            Console.WriteLine("Done.");
            return currentStop;
        }

        public static  Boolean AddStop(String stopName, int routeID)
        {
            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                int newStopNum = 1;
                String sql = "SELECT stopNumber FROM Stops WHERE routeID = " + routeID + " ;";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                Console.WriteLine(sql);

                MySqlDataReader myReader = cmd.ExecuteReader();


                if (myReader.HasRows)
                {
                    myReader.Close();

                    sql = "SELECT MAX(stopNumber) AS max FROM Stops WHERE routeID = " + routeID + "; ";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    Console.WriteLine(sql);
                    //If the query was successfully ran, store each of the column elements into toReturn 
                    myReader = cmd.ExecuteReader();

                    if (myReader.Read())
                        newStopNum = int.Parse(myReader["max"].ToString()) + 1;

                }
                else
                

                myReader.Close();

                sql = "INSERT INTO Stops (stop, stopNumber, routeID) VALUES ('" + stopName + "', " + newStopNum + " , " + routeID + ");";
                Console.WriteLine(sql);
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                myReader.Close();
                myReader = cmd.ExecuteReader();

                //If a receipt was inserted, return true, if not, it returns false by default
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

        public static void RemoveStop(int stopNumber, int routeID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "DELETE FROM Stops WHERE routeID = " + routeID + " AND stopNumber = " + stopNumber + ";";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            UpdateStopNumbers(stopNumber, routeID);
            Console.WriteLine("Done.");
        }

        public static void UpdateStopNumbers(int stopNumber, int routeID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE Stops SET stopNumber = stopNumber -1 WHERE routeID = " + routeID + " AND stopNumber > " + stopNumber + ";";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
