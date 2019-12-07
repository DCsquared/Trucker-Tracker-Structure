using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckerTracker
{
    public partial class Receipt : Form
    {
        private string fileNamePath;
        private string destination;
        private string filename;
        private int accountID;

        public Receipt(int loggedInID)
        {
            accountID = loggedInID;         
            InitializeComponent();

        }
        


        private void Button2_Click(object sender, EventArgs e)
        {
            if (fileNamePath != null && destination != null)
            {
                File.Copy(fileNamePath, destination);
                Accounts.UploadReceipt(filename, this.accountID);
                //button2.BackColor = Color.Green;
                label2.Text = "Your receipt has been uploaded";
                label2.Visible = true;
                fileNamePath = null;
                destination = null; 
            }
            else
            {
                label2.Text = "ERROR: file not selected";
                label2.Visible = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //Do whatever you want
                
                fileNamePath = this.openFileDialog1.FileName;
                filename = Path.GetFileName(fileNamePath);
                destination = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\receipts\\" + filename;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
            label2.Visible = false;
            this.Hide();
            MainMenu mm = new MainMenu(accountID);
            mm.Show();
        }
    }
}
