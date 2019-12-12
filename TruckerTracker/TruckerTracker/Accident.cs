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
        private int id;

        public Accident(int loggedInID)
        {
            InitializeComponent();
            id = loggedInID;
        }

        private void uaDecider(String n)
        {
            switch (n)
            {
                case "main":
                    mainMneu();
                    break;
                case "upload":
                    submitAR();
                    break;
                case "log":
                    goLog();
                    break;
                case "reset":
                    resetAR();
                    break;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButton.BackColor = DefaultBackColor;
            uaDecider("main");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            uaDecider("upload");
        }

        private void Log_Click(object sender, EventArgs e)
        {
            uaDecider("log");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            uaDecider("reset");
        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        private void submitAR()
        {
            int cNum = (int)cars.Value;
            //send report to the database
            TTStruct.logAccident(cNum, notes.Text, accType.SelectedItem.ToString(), id);
            cars.ResetText();
            //reset notes
            notes.Text = "";
            accType.ResetText();
        }

        private void resetAR()
        {
            this.Hide();
            //reset the accident page
            Accident mm = new Accident(id);
            mm.Show();
        }

        private void goLog()
        {
            this.Hide();
            //go to the logs page
            Logs mm = new Logs(id);
            mm.Show();
        }
    }
}
