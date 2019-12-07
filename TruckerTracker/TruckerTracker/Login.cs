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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int accountID = Accounts.Login(usrnm.Text, pwrd.Text);
            Console.WriteLine("ID: " + accountID);
            //ACCOUNTS LOGIN FUNCTION
            if (accountID < 0)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                this.Hide();
                MainMenu mm = new MainMenu(accountID);
                mm.Show();
            }

            
        }
    }
}
