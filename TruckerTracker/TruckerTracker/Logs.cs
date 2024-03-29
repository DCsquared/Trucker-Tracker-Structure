﻿using System;
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
    //Logs allows the user to view any accident reports that they have filed
    public partial class Logs : Form
    {
        /*
         * id is the ID of the logged-in user
         * dates is a string that holds the queried dates of the accidents that the user has had
         * accidents is a string that holds all of the report of the selected accident date
        */
        private int id;
        private String dates;
        private String accidents;

        //the constructor for the logs form
        public Logs(int loggedInID)
        {
            InitializeComponent();
            id = loggedInID;
            logDecider("display");
        }

        //the decider for the logs fofm
        private void logDecider(String n)
        {
            switch (n)
            {
                case "main":
                    mainMneu();
                    break;
                case "display":
                    display();
                    break;
                case "report":
                    showReport();
                    break;
            }
        }

        //back button that takes them to the main menu
        private void BackButton_Click(object sender, EventArgs e)
        {
            logDecider("main");
        }
        
        //grabs the report of the selected date
        private void LogDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            logDecider("report");
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        //display the dates
        private void display()
        {
            LogDates.Items.Clear();
            dates = "";

            //grabs the accident dates of the user
            dates = TTStruct.displayLogs(id);

            //separates the dates and stores them in the listbox on the gui
            String[] datesList = dates.Split('|');
            for (int i = 0; i < datesList.Length; i++)
            {
                LogDates.Items.Add(datesList[i]);
            }
        }

        //grab the select report
        private void showReport()
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
                accidents = TTStruct.requestLog(date + dsub, id);

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
