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
        /* id is the user's account ID
         * username is the user's username
         * password is the user's password
         * fname is  the user's first name
         * lname is the user's last name
         * timeOnRoad is the amount of time the user has been on the road
         */
        public int id;
        public String username;
        public String password;
        public String fname;
        public String lname;
        public String timeOnRoad;

        //Login takes the input of a username and password and returns the matching accountID if the combination is valid, -1 otherwise
        public static int Login(String username, String password)
        {
            int returnID = -1;
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Run a select query
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT id FROM Accounts WHERE username = '" + username + "' AND password = '" + password + "' ; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store the id into returnID
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

        //GetName takes the input of an accountID and returns the fist and last name of that user
        public static String GetName(int accountID)
        {
            String name = "No one";
            //Connect to the database 
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Run a select query
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                String sql = "SELECT fname, lname FROM Accounts WHERE id = " + accountID + " ; ";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If the query was successfully ran, store the first and last name into name
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

        //UploadReceipt takes the input of a filename and an accountID and uploads the receipt to the database
        public static Boolean UploadReceipt(String filename, int accountID)
        {
            //Connect to the database and run the Insert query
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

        //GetTimeSecs takes the input of an accountID and returns the time in seconds that the user has been on the road
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
                //If the query was successfully ran, store the time into previousTime
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

        //GetTime takes the input of an accountID and returns the time that the user has been on the road
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
                //If the query was successfully ran, store the time in previousTime
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

        //UpdateTime takes the input of a newTime and an accountID and updates the time in the database.
        //  It returns true if it was succesful, false otherwise
        public static Boolean UpdateTime(int newTime, int accountID)
        {
            //Connect to the database and run the Update command
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

        //ResetTime takes the input of an accountID and sets the timeOnRoad for that account to 0
        public static void ResetTime(int accountID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                //Run the Update query
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

        //logAccident takes the input of # of cars, notes on the accident, type of acccident, and the accountID of the user who isreporting it and 
        //      returns true if the upload was successful, false otherwise
        public static Boolean logAccident(int cars, String notes, String atype, int accountID)
        {
            //Connect to the database and run the insert in the amount of cars, the accident type, and the accident notes into the database of the current user
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //format the string into the sql datetime data type format
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

        //displayLogs takes the input of an accountID and fills a data table with the accidents
        public static String displayLogs(int accountID)
        {
            String sql = "", dates = "";
            //date table to hold all of the dates of the accidents associated with the user
            DataTable myTable = new DataTable();

            //a sql qeury that grabs all of the dates of the accidents associated with the user
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

                //store the dates inside the data table
                myAdapter.Fill(myTable);
                foreach (DataRow row in myTable.Rows)
                {
                    //store the dates in a string to return to the function call
                    dates += row["date"].ToString() + "|";
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            //Return the string full of the accident dates
            return dates;
        }

        //queries the info of the selected accident
        public static String requestLog(String dateS, int accountID)
        {
            String sql = "", report = "";
            //Connect to the database and query all of the info related to the selected accident date 
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
                //If the query was successfully ran, store the accident report inside of a string
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
            //Return the string that has selected accident report data
            return report;
        }

        //LoadRoutes takes the input of a routeID and fills a data table with the stops of that route
        public static DataTable LoadRoutes(int routeID)
        {
            //toSetDataTable is the table that will be returned
            DataTable toSetDataTable = new DataTable();

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

        //GetCurrentRoute takes the input of an accountID, and returns the routeID asociated with that accountID
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
                //If the query was successfully ran, store the routeID into returnRoute
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

        //GetCurrentStop takes the input of a routeID and returns the current stop
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
                //If the query was successfully ran, store the stop into currentStop 
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

        //AddStop takes the input of a stopName and routeID and inserts the stop into the route
        public static Boolean AddStop(String stopName, int routeID)
        {
            //Connect to the database and run a query 
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

                //If there is at least one stop on this route
                if (myReader.HasRows)
                {
                    myReader.Close();

                    sql = "SELECT MAX(stopNumber) AS max FROM Stops WHERE routeID = " + routeID + "; ";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    Console.WriteLine(sql);
                    //If the query was successfully ran, get the highest stop number in the route and store it into newStopNum
                    myReader = cmd.ExecuteReader();

                    if (myReader.Read())
                        newStopNum = int.Parse(myReader["max"].ToString()) + 1;

                }
                else
                    myReader.Close();
                //SQL query to insert the stop into the route
                sql = "INSERT INTO Stops (stop, stopNumber, routeID) VALUES ('" + stopName + "', " + newStopNum + " , " + routeID + ");";
                Console.WriteLine(sql);
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                myReader.Close();
                myReader = cmd.ExecuteReader();

                //If a stop was inserted, return true
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

        //RemoveStop accepts stopNumber and routeID as an input and removes the corresponding stop from the database
        public static void RemoveStop(int stopNumber, int routeID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //SQL query to delete a stop from the database
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

        //UpdateStopNumbers accepts stopNumber and routeID as an input and updates all the stop numbers after that one in the database
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

        public static Boolean setWeight(String newWeight, int accountID)
        {
            //Connect to the database and run the Update the trucks's weight for the current user
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
            //grab the weight from the trucks table of the current user
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
                if (myReader.Read())
                {
                    //store the weight in a variable to returned
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

            //return the selected weight
            return wght;
        }

        public static string getMileage(int accountID)
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;"; //Sql sign in info
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT mileage FROM Trucks WHERE accountID = " + accountID + ";"; // SQL statement to get the mileage of the truck
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                //If an that truck exists return the mileage of that truck
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

        public static bool updateDistance(decimal distance, int accountID) //Update the distance in the database associated with the accountID
        {
            string connStr = "server=danialmemon.com;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;"; //SQL sign in info
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE Trucks SET mileage = " + distance + " where accountID = " + accountID + ";"; // SQL statement to set the newest mileage amount
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

        public static string getDate(int accountID)
        {
            string connStr = "server=dkmpi.hopto.org;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;";  //SQL sign in info
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to Database");
                conn.Open();
                string sql = "SELECT serviceDate AS 'serviceDate' from Trucks WHERE accountID = " + accountID + " ;"; // SQL statement to get the last service date
                Console.WriteLine(sql);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    return ((DateTime)(myReader["serviceDate"])).ToString("MM/dd/yyyy");  // Gets the date in a specific format


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
            string connStr = "server=dkmpi.hopto.org;user=remoteUser;database=TruckerTracker;port=3306;password=GoodThinking45!;sslmode =none;"; //SQL sign in info
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to Database");
                conn.Open();
                string sql = "UPDATE Trucks SET serviceDate = '" + year + "-" + month + "-" + day + "' where accountID = " + accountID + ";"; // Set's the information in the database.
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
    }

}