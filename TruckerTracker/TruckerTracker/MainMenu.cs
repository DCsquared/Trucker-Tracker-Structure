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
        private int accountID;
        public MainMenu(int accID)
        {
            InitializeComponent();
            accountID = accID;
            String name = Accounts.GetName(accountID);
            loggedIn.Text = "Logged in as: " + name; 
        }
        //THIS WILL NO BE IN THE FINAL PROGRAM. ALL INSTANCES OF MAIN MENU MUST BE PASSED THE ACCOUNT ID

        private void Button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Green)
                button6.BackColor = DefaultBackColor; 
            else
                button6.BackColor = Color.Green;
            this.Hide();
            Weight mm = new Weight(accountID);
            mm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Green)
                button4.BackColor = DefaultBackColor;
            else
                button4.BackColor = Color.Green;
            this.Hide();
            Receipt mm = new Receipt(this.accountID);
            mm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (truckInfo.BackColor == Color.Green)
                truckInfo.BackColor = DefaultBackColor;
            else
                truckInfo.BackColor = Color.Green;
            this.Hide();
            Info mm = new Info(accountID);
            mm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
             if (button7.BackColor == Color.Green)
                button7.BackColor = DefaultBackColor;
            else
                button7.BackColor = Color.Green;
            this.Hide();
            Route mm = new Route(accountID);
            mm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Green)
                button1.BackColor = DefaultBackColor;
            else
                button1.BackColor = Color.Green;
            this.Hide();
            UpdateDate mm = new UpdateDate(accountID);
            mm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Green)
                button5.BackColor = DefaultBackColor;
            else
                button5.BackColor = Color.Green;
            this.Hide();
            Accident mm = new Accident(accountID);
            mm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Green)
                button3.BackColor = DefaultBackColor;
            else
                button3.BackColor = Color.Green;
            this.Hide();
            UpdateMileage mm = new UpdateMileage(accountID);
            mm.Show();
        }
    }
}
