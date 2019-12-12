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
    public partial class UpdateMileage1 : Form
    {
       private int id;

        public UpdateMileage1(int loggedInID)
        {
            id = loggedInID;
            InitializeComponent();
            decider(0);
        }
        
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
                label3.Show();
                displayNew();
            }
            else
            {
                label4.Show();
            }
        }

        //displays the new mileage
        private void displayNew()
        {
            this.label2.Text = "Total Miles:" + TTStruct.getMileage(id);
        }

        private void updateMileage_Click(object sender, EventArgs e)
        {
            decider(2);
        }

        //displays the current mileage from the db
        private void displayCurrent()
        {
            this.label2.Text = "Total Miles:" + TTStruct.getMileage(id);
        }


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
