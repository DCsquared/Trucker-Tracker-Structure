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
    public partial class Mileage : Form
    {
        public Mileage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (mDriven.Text == "" || mDriven.Text == "")
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = true;
                label3.Text = "Total Miles " + mDriven.Text;
                              
            }

            if (button1.BackColor == Color.Green)
            {
                button1.BackColor = DefaultBackColor;
                this.Hide();
               // MainMenu mm = new MainMenu();
                //mm.Show();
            }
            else
                button1.BackColor = Color.Green;
        }
    }
}
