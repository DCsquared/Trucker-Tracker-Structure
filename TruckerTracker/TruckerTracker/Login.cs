﻿using System;
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
    //login form allows the user to login and use the app
    public partial class Login : Form
    {
        //constructor for the login form
        public Login()
        {
            InitializeComponent();
        }

        //login button
        private void Button1_Click(object sender, EventArgs e)
        {
            loginDecider();
        }

        //the login algorithm decider for the process 1 of DFD
        private void loginDecider()
        {
            int id = TTStruct.Login(usrnm.Text, pwrd.Text);
            if (displayOutput(id))
            {
                mainMenu(id);
            }
        }

        //handles the changes to the GUI
        private Boolean displayOutput(int id)
        {
            if (id < 0)
            {
                label4.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        //goes to main menu
        private void mainMenu(int id)
        {
            label4.Visible = false;
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }
    }
}
