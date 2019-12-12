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
    public partial class MainMenu : Form
    {
        private int id;
        //displays the currently signed in user
        public MainMenu(int accID)
        {
            InitializeComponent();
            id = accID;
            mDecider("display");
        }

        private void mDecider(String m)
        {
            switch (m)
            {
                case "display":
                    String name = TTStruct.GetName(id);
                    loggedIn.Text = "Logged in as: " + name;
                    break;
                case "tw":
                    this.Hide();
                    Weight mm = new Weight(id);
                    mm.Show();
                    break;
                case "ur":
                    this.Hide();
                    Receipt r = new Receipt(this.id);
                    r.Show();
                    break;
                case "ti":
                    this.Hide();
                    Info i = new Info(id);
                    i.Show();
                    break;
                case "sr":
                    this.Hide();
                    Route re = new Route(id);
                    re.Show();
                    break;
                case "us":
                    this.Hide();
                    UpdateDate1 us = new UpdateDate1(id);
                    us.Show();
                    break;
                case "a":
                    this.Hide();
                    Accident a = new Accident(id);
                    a.Show();
                    break;
                case "um":
                    this.Hide();
                    UpdateMileage1 um = new UpdateMileage1(id);
                    um.Show();
                    break;
            }
        }

        //goes to the update truck weight
        private void Button6_Click(object sender, EventArgs e)
        {
            mDecider("tw");
        }

        //goes to the upload reciept
        private void Button4_Click(object sender, EventArgs e)
        {
            mDecider("ur");
        }

        //goes to the truck info
        private void Button2_Click(object sender, EventArgs e)
        {
            mDecider("ti");
        }

        //goes to the set route
        private void Button7_Click(object sender, EventArgs e)
        {
            mDecider("sr");
        }

        //goes to the update service date
        private void Button1_Click(object sender, EventArgs e)
        {
            mDecider("us");
        }

        //goes to the acciedent report
        private void Button5_Click(object sender, EventArgs e)
        {
            mDecider("a");
        }

        //goes to the update mileage
        private void Button3_Click(object sender, EventArgs e)
        {
            mDecider("um");
        }
    }
}
