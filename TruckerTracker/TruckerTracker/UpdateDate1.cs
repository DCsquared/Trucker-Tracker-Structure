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
    //UpdateDate1 form allows the user to select a date on the calendar and update the date that they last got their 
    //truck serviced and will remind them to get it sevriced after 56 days have passed.
    public partial class UpdateDate1 : Form
    {
        //id is the ID of the logged-in user
        private int id;

        //the constructor for the UpdateDate1 form
        public UpdateDate1(int loggedInID)
        {
            id = loggedInID;
            InitializeComponent();
            usDecider("cur");
            usDecider("date");
        }

        //the decider for the UpdateDate1 form
        private void usDecider(String func)
        {
            switch (func)
            {
                case "cur":
                    displayCur();
                    break;
                case "update":
                    updateServ();
                    break;
                case "main":
                    mainMneu();
                    break;
                case "date":
                    dateChecker();
                    break;
            }
        }

        //update the service date
        private void updateServ()
        {
            bool test = TTStruct.setDate(calendar.SelectionStart.Year, calendar.SelectionStart.Month, calendar.SelectionStart.Day, this.id);
            if (test)
            {
                //show if update was a success
                label3.Show();
            }
            else
            {
                //show if update was a failure
                label4.Show();
            }
            //display the new date
            displayNew("" + TTStruct.getDate(this.id));
        }

        //display new date
        private void displayNew(String n)
        {
            this.label2.Text = "Last Service Date:" + n;
        }

        //display current date
        private void displayCur()
        {
            this.label2.Text = "Last Service Date:" + TTStruct.getDate(this.id);
        } 

        //update service date button
        private void updateService_Click(object sender, EventArgs e)
        {
            usDecider("update");
        }

        //go to main menu
        private void MainMenu_Click(object sender, EventArgs e)
        {
            usDecider("main");
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        //checks to see if it is time for the user to get their truck serviced
        private bool dateChecker()
        {
            DateTime startDate = new DateTime(2019, 12, 1);
            DateTime endDate = new DateTime(2019, 12, 2);
            if(!((endDate-startDate).Days>=56))
            {
                //show reminder message
                return true;
            }
            return false;
        }

    }
}
