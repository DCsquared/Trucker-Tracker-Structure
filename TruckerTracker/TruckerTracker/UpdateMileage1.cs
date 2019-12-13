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


namespace TruckerTracker
{
    //UpdateMileage1 form allows the user to update the total miles that they've driven so far
    public partial class UpdateMileage1 : Form
    {
        //id is the ID of the logged-in user
        private int id;

        //the constrcutor for the UpdateMileage1 form
        public UpdateMileage1(int loggedInID)
        {
            id = loggedInID;
            InitializeComponent();
            decider(0);
        }

        //the decider for the UpdateMileage1
        private void decider(int input)
        {
            if (input == 0)
                displayCurrent();
            else
                updateMileage1();
        }

        //update the mileage in the db
        private void updateMileage1()
        {
            bool test = TTStruct.updateDistance(textBox2.Value, id);
            if (test)
            {
                //show erro message if update was successful and display new mileage
                label3.Show();
                displayNew();
            }
            else
            {
                //show error message if update failed
                label4.Show();
            }
        }

        //displays the new mileage
        private void displayNew()
        {
            this.label2.Text = "Total Miles:" + TTStruct.getMileage(id);
        }

        //the update button
        private void updateMileage_Click(object sender, EventArgs e)
        {
            decider(2);
        }

        //displays the current mileage from the db
        private void displayCurrent()
        {
            this.label2.Text = "Total Miles:" + TTStruct.getMileage(id);
        }

        //the main menu button
        private void MainMenu_Click(object sender, EventArgs e)
        {
            mainMneu();
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
