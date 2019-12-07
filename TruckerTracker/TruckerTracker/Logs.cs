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
    public partial class Logs : Form
    {
        private int accountID;
        private String dates;
        private String accidents;

        public Logs(int loggedInID)
        {
            InitializeComponent();
            accountID = loggedInID;
            LogDates.Items.Clear();
            dates = "";

            //grabs the accident dates of the user
            dates = Accidents.displayLogs(accountID);

            //separates the dates and stores them in the listbox on the gui
            String[] datesList = dates.Split('|');
            for (int i = 0; i < datesList.Length; i++)
            {
                LogDates.Items.Add(datesList[i]);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //goes to main menu
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }



        private void LogDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            String date = LogDates.SelectedItem.ToString(), dsub = "";
            Console.WriteLine("date: " + date);
            //reformats the selected date text to match that of the database
            if (!date.Equals(""))
            {
                dsub = date.Substring(date.IndexOf(' '));
                date = date.Substring(0, date.IndexOf(' '));
                String[] dateN = date.Split('/');
                date = dateN[2] + "-" + dateN[0] + "-" + dateN[1];

                //grabs the selected accident from the database
                accidents = Accidents.requestLog(date + dsub, accountID);

                //parses the string into 3 sections for the cars, accident type, and the notes
                String[] accident = accidents.Split('|');

                //displays the accident report on the gui
                numCars.Text = accident[0];
                acciType.Text = accident[1];
                LogNotes.Text = accident[2];
            }
        }
    }
}
