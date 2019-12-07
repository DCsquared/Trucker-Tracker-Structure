using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TruckerTracker
{
    public partial class Route : Form
    {
        private int accountID;
        private int routeID;
        private string currentStop;
        DataTable toSetDataTable;
        public Route(int accID)
        {
            InitializeComponent();
            accountID = accID;
            routeID = Routes.GetCurrentRoute(accountID);
            currentStop = Routes.GetCurrentStop(routeID);

            toSetDataTable =  Routes.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
            CreateUnboundButtonColumn();

        }


        private void Back_Click(object sender, EventArgs e)
        {

            back.BackColor = DefaultBackColor;
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();

        }

        private void AddRoute_Click(object sender, EventArgs e)
        {
            Routes.AddStop(address.Text, routeID);
            address.Text = "";

            toSetDataTable = Routes.LoadRoutes(routeID);
            routeList.DataSource = toSetDataTable;
        }



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

        private void RouteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Routes.RemoveStop(e.RowIndex + 1, routeID);
                toSetDataTable = Routes.LoadRoutes(routeID);
                routeList.DataSource = toSetDataTable;
            }

        }

        private void StartRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            GPS newGPS = new GPS(accountID, routeID);
            newGPS.Show();
        }
    }
}
