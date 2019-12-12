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
    public partial class Weight : Form
    {
        private int id;

        public Weight(int loggedInID)
        {
            InitializeComponent();
            id = loggedInID;
            uwDecider("cur");
        }

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
            label3.Text = "Total Weight: " + Trucks.getWeight(id) + " lbs";
        }

        //update weight function
        private void updateW()
        {
            //check if new weight has been entered
            if (nWeight.Text == "")
            {
                label4.Visible = true;
            }
            else
            {
                //update weight in database
                if (Trucks.setWeight(nWeight.Text, this.id))
                {
                    displayNew();
                }
                else
                {
                    label4.Visible = true;
                }
            }
        }

        //display new weight
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

        private void Button1_Click(object sender, EventArgs e)
        {
            uwDecider("update");
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            uwDecider("main");
        }
    }
}
