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
    public partial class UpdateMileage : Form
    {
       private string fileNamePath;
       private string destination;
       private string filename;
       private int accountID;

        public UpdateMileage(int loggedInID)
        {
            accountID = loggedInID;
            InitializeComponent();
            this.label2.Text = "Total Miles:" + Trucks.getMileage(this.accountID);
        }

        private void updateMileage_Click(object sender, EventArgs e)
        {
            bool test = Trucks.updateDistance(textBox2.Value, this.accountID);
            if (test)
            {
                label3.Show();
            }
            else
            {
                label4.Show();
            }
            this.label2.Text = "Total Miles:" + Trucks.getMileage(this.accountID);

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }


    }
}
