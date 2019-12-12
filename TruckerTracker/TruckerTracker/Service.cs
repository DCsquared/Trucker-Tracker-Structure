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
    public partial class Service : Form
    {
        private int id;
        public Service(int accID)
        {
            id = accID;
            InitializeComponent();
            upSerDecider(0);
        }

        private void upSerDecider(int i)
        {
            if(i == 0)
             displayCurrent();
            else if(i == 1)
                updateServ();
            else
             mainMneu();
        }

        private void displayCurrent()
        {

        }

        private void displayNew()
        {

        }

        private void updateServ()
        {

        }

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            lastDate.Text = "Last Service Date: " + monthCalendar1.SelectionStart;
            lastDate.Text = lastDate.Text.Substring(0, lastDate.Text.LastIndexOf('/') + 5);


            if (update.BackColor == Color.Green)
            {
                update.BackColor = DefaultBackColor;
                this.Hide();
                MainMenu mm = new MainMenu(id);
                mm.Show();
            }
            else
            {
                updateCon.Visible = true;
                update.BackColor = Color.Green;
                getServiced.Visible = false;
            }

            getServiced.Visible = true;
            updateCon.Visible = false;
        }
    }
}
