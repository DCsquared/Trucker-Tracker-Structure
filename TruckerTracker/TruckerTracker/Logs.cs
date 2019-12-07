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
    public partial class Logs : Form
    {
        private int accountID;
        private String dates;
        private String accidents;

        public Logs(int loggedInID)
        {
            InitializeComponent();
            accountID = loggedInID;
            LogDates.Items.Clear();

            dates = Accidents.displayLogs(accountID);
            String[] datesList = dates.Split('|');
            for (int i = 0; i < datesList.Length; i++)
            {
                LogDates.Items.Add(datesList[i]);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
                this.Hide();
                MainMenu mm = new MainMenu(accountID);
                mm.Show();
        }

       

        private void LogDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            String date = LogDates.SelectedItem.ToString(), dsub = "";
            Console.WriteLine("date: " + date);
            if (!date.Equals(""))
            {
                dsub = date.Substring(date.IndexOf(' '));
                date = date.Substring(0, date.IndexOf(' '));
                String[] dateN = date.Split('/');
                date = dateN[2] + "-" + dateN[0] + "-" + dateN[1];
                accidents = Accidents.requestLog(date + dsub, accountID);
                Console.WriteLine(accidents);
                String[] accident = accidents.Split('|');
                numCars.Text = accident[0];
                acciType.Text = accident[1];
                LogNotes.Text = accident[2];
            }
        }
    }
}
