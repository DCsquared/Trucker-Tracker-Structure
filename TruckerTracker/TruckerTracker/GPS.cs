using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckerTracker
{
    //GPS form displays the curent time the user has been on the road as well as the stops left on their route. 
    public partial class GPS : Form
    {
        /* id is the ID of the logged-in user
         * routeID is the ID of the route of the logged-in user
         * count keeps track of the number of seconds that the user has been driving
         * hours is the number of hours the user has been on the road
         * minutes is the number of minutes the user has been on the road
         * seconds is the number of seconds the user has been on the road
         * toSetDataTable is the Data Table that populates the route table.
         */
        private int id;
        private int routeID;
        private int count = 0;
        private int hours;
        private int minutes;
        private int seconds;
        private DataTable toSetDataTable;

        //the constructor for the gps form 
        public GPS(int accID, int rtID)
        {
            id = accID;
            routeID = rtID;
            InitializeComponent();
            gpsDecider("display");
        }

        //the decider for the set route page
        private void gpsDecider(String n)
        {
            switch (n)
            {
                case "main":
                    mainMneu();
                    break;
                case "reset":
                    resetTimer();
                    break;
                case "start":
                    timerUpdate("start");
                    break;
                case "stop":
                    timerUpdate("stop");
                    break;
                case "display":
                    displayR();
                    break;
            }
        }

        //start timer
        private void Start_Click(object sender, EventArgs e)
        {
            gpsDecider("start");
        }

        //stop timer
        private void Pause_Click(object sender, EventArgs e)
        {
            gpsDecider("stop");
        }

        //resume timer
        private void Back_Click(object sender, EventArgs e)
        {
            gpsDecider("start");
        }

        //end the route and stop the timer
        private void End_Click(object sender, EventArgs e)
        {
            gpsDecider("endTimer");
            gpsDecider("main");
        }

        //set up the timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            String h, m, s;
            h = m = s = "";
            hours = count / 3600;
            minutes = (count - (hours * 3600)) / 60;
            seconds = (count - (hours * 3600)) - (minutes * 60);
            //formats the timer to have 00:00:00 format
            if (hours < 10)
                h = "0";
            else
                h = "";
            if (minutes < 10)
                m = "0";
            else
                m = "";
            if (seconds < 10)
                s = "0";
            else s = "";

            Timer.Text = h + hours + ":" + m + minutes + ":" + s + seconds;
            count++;
        }

        //remove an address that has been reached
        private void RouteList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           var senderGrid = (DataGridView)sender;

            //makes sure the route has stops to remove
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                TTStruct.RemoveStop(e.RowIndex + 1, routeID);
                toSetDataTable = TTStruct.LoadRoutes(routeID);
                routeList.DataSource = toSetDataTable;
            }
        }

        //reset timer button for new day
        private void Button1_Click(object sender, EventArgs e)
        {
            gpsDecider("reset");
        }

        //end the timer and update the timer in the database
        private void endTimer()
        {
            timer1.Stop();

            int previousTime = TTStruct.GetTimeSecs(id);

            int totalTime = previousTime + count;
            TTStruct.UpdateTime(totalTime, id);
        }

        //reset the timer
        private void resetTimer()
        {
            TTStruct.ResetTime(id);
            count = 0;
            Timer.Text = "00:00:00";
            Console.WriteLine("Done.");
        }

        //pause or resume the timer
        private void timerUpdate(String t)
        {
            if (t.Equals("start"))
                timer1.Start();
            else
                timer1.Stop();
        }

        //display the current route
        private void displayR()
        {
            toSetDataTable = TTStruct.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
            CreateUnboundButtonColumn();
        }

        //display the addresses of the route 
        private void CreateUnboundButtonColumn()
        {
            // Initialize the button column.
            DataGridViewButtonColumn arrivedButtonColumn = new DataGridViewButtonColumn();
            arrivedButtonColumn.Text = "Arrived";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            arrivedButtonColumn.UseColumnTextForButtonValue = true;
            arrivedButtonColumn.Width = 2;
            // Add the button column to the control.
            routeList.Columns.Insert(2, arrivedButtonColumn);
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }
    }
}
