using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// Change to TruckerTracker WHEN UPDATING
namespace TruckerTracker
{
    public partial class UpdateDate : Form
    {

        
        private int accountID;


        public UpdateDate(int loggedInID)
        {
            accountID = loggedInID;
            InitializeComponent();
            this.label2.Text = "Last Service Date:" + Trucks.getDate(this.accountID);
        }

        private void updateService_Click(object sender, EventArgs e)
        {
            bool test = Trucks.setDate(calendar.SelectionStart.Year, calendar.SelectionStart.Month, calendar.SelectionStart.Day, this.accountID);
            if (test)
            {
                label3.Show();
            }
            else
            {
                label4.Show();
            }
            this.label2.Text = "Last Service Date:" + Trucks.getDate(this.accountID);
        }
        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }



        private bool dateChecker()
        {
            DateTime startDate = new DateTime(2019, 12, 1);
            DateTime endDate = new DateTime(2019, 12, 2);
            if(!((endDate-startDate).Days>=56))
            {
                return true;
            }
            return false;
        }

    }
}
