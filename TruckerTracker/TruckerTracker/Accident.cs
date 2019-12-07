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
    public partial class Accident : Form
    {
        private int accountID;

        public Accident(int loggedInID)
        {
            InitializeComponent();
            accountID = loggedInID;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            BackButton.BackColor = DefaultBackColor;
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int cNum = (int)cars.Value;
            Accidents.logAccident(cNum, notes.Text, accType.SelectedItem.ToString(), accountID);
            cars.ResetText();
            notes.Text = "";
            accType.ResetText();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logs mm = new Logs(accountID);
            mm.Show();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accident mm = new Accident(accountID);
            mm.Show();
            
        }
    }
}
