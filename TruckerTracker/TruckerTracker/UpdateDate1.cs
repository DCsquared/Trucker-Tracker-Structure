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
    public partial class UpdateDate1 : Form
    {

        
        private int id;


        public UpdateDate1(int loggedInID)
        {
            id = loggedInID;
            InitializeComponent();
            usDecider("cur");
            usDecider("date");
        }


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
                label3.Show();
            }
            else
            {
                label4.Show();
            }
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

        private void updateService_Click(object sender, EventArgs e)
        {
            usDecider("update");
        }

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
