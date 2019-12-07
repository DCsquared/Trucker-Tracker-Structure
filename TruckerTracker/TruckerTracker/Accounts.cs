
﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerTracker
{
    public class Accounts
    {
        public int id;
        public String username;
        public String password;
        public String fname;
        public String lname;
        public String timeOnRoad;

        public static int Login(String username, String password)
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
                //If the query was successfully ran, store each of the column elements into toReturn 
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
                //If the query was successfully ran, store each of the column elements into toReturn 
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

        public static Boolean UploadReceipt(String filename, int accountID)
        {
            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "INSERT INTO Receipts (receiptFileName, accountID) VALUES ('" + filename + "', " + accountID + ");";
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

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
        public static int GetTimeSecs(int accountID)
        {
            string sql = "SELECT TIME_TO_SEC(timeOnRoad) AS `time` FROM Accounts WHERE id =" + accountID + ";";
            int previousTime = 0;
            //code to add time to db 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column elements into toReturn 
                if (myReader.Read())
                {
                    previousTime = int.Parse(myReader["time"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return previousTime;
        }

        public static String GetTime(int accountID)
        {
            string sql = "SELECT timeOnRoad AS `time` FROM Accounts WHERE id =" + accountID + ";";
            String previousTime = "";
            //code to add time to db 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the column elements into toReturn 
                if (myReader.Read())
                {
                    previousTime = myReader["time"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return previousTime;
        }

        public static Boolean UpdateTime(int newTime, int accountID)
        {
            //Connect to the database and run the Insert command
            String connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "UPDATE Accounts SET timeOnRoad = SEC_TO_TIME(" + newTime + ") WHERE id = " + accountID + ";";
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
            }
            conn.Close();
            Console.WriteLine("Done.");

            //Return false by default
            return false;
        }

        public static void ResetTime(int accountID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE Accounts SET timeOnRoad = 0 WHERE id = " + accountID + ";";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    

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

        public static Boolean logAccident(int cars, String notes, String atype, int accountID)
        {
            //Connect to the database and run the Insert command
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String date = DateTime.Now.ToString("yyyy-MM-dd");
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
            //List<Logs> eventList = new List<Logs>();  //a list to save the events
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
                //MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store each of the dates into dates 
                //if (myReader.Read())
                //{
                //    dates += myReader["date"].ToString() + "|";
                //}
                //Console.WriteLine(dates);

                //myReader.Close();

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
            String sql = "", report = "_";
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
                //MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                //myAdapter.Fill(myTable);

                //foreach (DataRow row in myTable.Rows)
                //{
                //    report = row["cars"].ToString() + "|" + row["type"].ToString() + "|" + row["notes"].ToString();
                //}

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
                Console.WriteLine(report + "HEllo");

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
