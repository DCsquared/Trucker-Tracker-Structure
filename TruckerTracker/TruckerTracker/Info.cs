using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckerTracker
{
    public partial class Info : Form
    {
        private int accountID;
        public Info(int accID)
        {
            accountID = accID;
            InitializeComponent();
            this.label4.Text = "Weight: " + Accounts.getWeight(this.accountID) + "lbs ";
            this.label5.Text = "Mileage: " + Trucks.getMileage(this.accountID);
            this.label6.Text = "Current Drive Time:" + Accounts.GetTime(this.accountID);
            int timeleft = 36000 - Accounts.GetTimeSecs(this.accountID);
            int minutes = (timeleft / 60) % 60;
            int hours = timeleft / 3600;
            int seconds = timeleft % 60;
            this.label7.Text = "Remaining Drive Time: " + hours + "hrs, " + minutes + "min, " + seconds + "sec";
            this.label8.Text = "Time Since Last Service: " + Trucks.getDate(this.accountID);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }
    }
}