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
    public partial class GPS : Form
    {
        private int accountID;
        private int routeID;
        private int count = 0;
        private int hours;
        private int minutes;
        private int seconds;
        private DataTable toSetDataTable;


        public GPS(int accID, int rtID)
        {
            accountID = accID;
            routeID = rtID;
            InitializeComponent();
            toSetDataTable = Routes.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
            CreateUnboundButtonColumn();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void End_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            int previousTime = Accounts.GetTimeSecs(accountID);
            
            int totalTime = previousTime + count;
            Accounts.UpdateTime(totalTime, accountID);


            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            hours = count / 3600;
            minutes = (count - (hours * 3600)) / 60;
            seconds = (count - (hours * 3600)) - (minutes * 60);
            Timer.Text = hours + ":" + minutes + ":" + seconds;
            count++;
        }

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


        private void RouteList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Routes.RemoveStop(e.RowIndex + 1, routeID);
                toSetDataTable = Routes.LoadRoutes(routeID);
                routeList.DataSource = toSetDataTable;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Accounts.ResetTime(accountID);
            count = 0;
            Timer.Text = "00:00:00";
            Console.WriteLine("Done.");

        }
    }
}
