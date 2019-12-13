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
    //Weight form allows the user to update the current weight of the truck 
    public partial class Weight : Form
    {
        //id is the ID of the logged-in user
        private int id;

        //the constructor for the weight form
        public Weight(int loggedInID)
        {
            InitializeComponent();
            id = loggedInID;
            uwDecider("cur");
        }

        //the decider for the weight form
        private void uwDecider(String func)
        {
            switch (func)
            {
                case "cur":
                    displayCur();
                    break;
                case "update":
                    updateW();
                    break;
                case "main":
                    mainMneu();
                    break;
            }
        }

        //display current weight
        private void displayCur()
        {
            label3.Text = "Total Weight: " + TTStruct.getWeight(id) + " lbs";
        }

        //update weight function
        private void updateW()
        {
            //check if the new weight has been entered
            if (nWeight.Text == "")
            {
                label4.Visible = true;
            }
            else
            {
                //update the weight in database
                if (TTStruct.setWeight(nWeight.Text, this.id))
                {
                    displayNew();
                }
                else
                {
                    label4.Visible = true;
                }
            }
        }

        //display the new weight
        private void displayNew()
        {
            label3.Text = "Total Weight: " + nWeight.Text + " lbs";
            label4.Visible = false;
            tw.Visible = true;
            nWeight.Text = "";
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        //the update weight button
        private void Button1_Click(object sender, EventArgs e)
        {
            uwDecider("update");
        }

        //the main menu button
        private void button2_Click(object sender, EventArgs e)
        {
            uwDecider("main");
        }
    }
}
