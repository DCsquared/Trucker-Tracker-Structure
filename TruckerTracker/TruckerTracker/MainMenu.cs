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
            String name = TTStruct.GetName(id);
            loggedIn.Text = "Logged in as: " + name; 
        }

        //goes to the update truck weight
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight mm = new Weight(id);
            mm.Show();
        }

        //goes to the upload reciept
        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receipt mm = new Receipt(this.id);
            mm.Show();
        }

        //goes to the truck info
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info mm = new Info(id);
            mm.Show();
        }

        //goes to the set route
        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Route mm = new Route(id);
            mm.Show();
        }

        //goes to the update service date
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDate mm = new UpdateDate(id);
            mm.Show();
        }

        //goes to the acciedent report
        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accident mm = new Accident(id);
            mm.Show();
        }

        //goes to the update mileage
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateMileage mm = new UpdateMileage(id);
            mm.Show();
        }
    }
}
