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
        private int accountID;

        public Weight(int loggedInID)
        {
            InitializeComponent();
            accountID = loggedInID;
            label3.Text = "Total Weight: " + Trucks.getWeight(accountID) + " lbs";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nWeight.Text == "")
            {
                label4.Visible = true;
            }
            else
            {
                //update weight in database
                if (Trucks.setWeight(nWeight.Text, this.accountID))
                { 
                    label3.Text = "Total Weight: " + nWeight.Text + " lbs";
                    label4.Visible = false;
                    tw.Visible = true;
                    nWeight.Text = "";
                }
                else
                {
                    label4.Visible = true;
                }
            }
        }

        //go to main menu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }
    }
}
