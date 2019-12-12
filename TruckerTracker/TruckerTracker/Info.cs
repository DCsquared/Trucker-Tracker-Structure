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
        private int id;
        String weight;
        String mile;
        String driveTime;
        String date;
        int time;

        public Info(int accid)
        {
            id = accid;
            InitializeComponent();
            truckInfoDec("");
        }

        private void truckInfoDec(String dec)
        {
            if (dec.Equals("main"))
                mainMneu();
            else
            {
                getInfo();
                displayInfo();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            truckInfoDec("main");
        }

        //grabs the info from the database and stores it in local variables
        private void getInfo()
        {
            weight = TTStruct.getWeight(this.id);
            mile = TTStruct.getMileage(this.id);
            driveTime = TTStruct.GetTime(this.id);
            date = TTStruct.getDate(this.id);
            time = TTStruct.GetTimeSecs(this.id);
        }

        //updates gui with the data stored in the local variables
        private void displayInfo()
        {
            this.label4.Text = "Weight: " + weight + "lbs ";
            this.label5.Text = "Mileage: " + mile;
            this.label6.Text = "Current Drive Time:" + driveTime;
            int timeleft = 36000 - time;
            int minutes = (timeleft / 60) % 60;
            int hours = timeleft / 3600;
            int seconds = timeleft % 60;
            this.label7.Text = "Remaining Drive Time: " + hours + "hrs, " + minutes + "min, " + seconds + "sec";
            this.label8.Text = "Time Since Last Service: " + date;
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