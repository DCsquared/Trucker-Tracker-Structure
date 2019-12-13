using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TruckerTracker
{
    //Route form allows the user to add or remove stops from their route
    public partial class Route : Form
    {
        /* id is the ID of the logged-in user
         * routeID is the ID of the route of the logged-in user
         * currentStop is the current stop the user is driving towards
         * toSetDataTable is the Data Table that populates the route table.
         */
        private int id;
        private int routeID;
        private string currentStop;
        DataTable toSetDataTable;

        //the constructor for the set route form
        public Route(int accID)
        {
            InitializeComponent();
            id = accID;
            srDecider("cur");
        }

        // the decider for the set route form
        private void srDecider(String n)
        {
            switch (n)
            {
                case "main":
                    mainMneu();
                    break;
                case "gps":
                    goGPS();
                    break;
                case "add":
                    addR();
                    break;
                case "cur":
                    displayCur();
                    break;
            }
        }
        
        //the back button that goes to the m
        private void Back_Click(object sender, EventArgs e)
        {
            srDecider("main");
        }

        //the add route button
        private void AddRoute_Click(object sender, EventArgs e)
        {
            srDecider("add");
        }
        
        //remove addresses from the route
        private void RouteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                TTStruct.RemoveStop(e.RowIndex + 1, routeID);
                toSetDataTable = TTStruct.LoadRoutes(routeID);
                routeList.DataSource = toSetDataTable;
            }
        }
        
        //start route button
        private void StartRoute_Click(object sender, EventArgs e)
        {
            srDecider("gps");
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        //go to GPS screen
        private void goGPS()
        {
            this.Hide();
            GPS newGPS = new GPS(id, routeID);
            newGPS.Show();
        }

        //add address to the route
        private void addR()
        {
            TTStruct.AddStop(address.Text, routeID);
            address.Text = "";

            toSetDataTable = TTStruct.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
        }

        //display current route 
        private void displayCur()
        {
            routeID = TTStruct.GetCurrentRoute(id);
            currentStop = TTStruct.GetCurrentStop(routeID);

            //displays the addresses for the current route
            toSetDataTable = TTStruct.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
            CreateUnboundButtonColumn();
        }
        
        //display the added address to the route 
        private void CreateUnboundButtonColumn()
        {
            // Initialize the button column.
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Text = "Remove Stop";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            removeButtonColumn.UseColumnTextForButtonValue = true;
            removeButtonColumn.Width = 2;
            // Add the button column to the control.
            routeList.Columns.Insert(2, removeButtonColumn);
        }
    }
}
