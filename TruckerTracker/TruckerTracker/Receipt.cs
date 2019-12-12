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
        private int id;

        public Receipt(int loggedInID)
        {
            id = loggedInID;         
            InitializeComponent();
        }
        
        private void urDecider(String n)
        {
            switch (n)
            {
                case "upload":
                    uploadPic();
                    break;
                case "select":
                    selectF();
                    break;
                case "main":
                    mainMneu();
                    break;
            }
        }

        //upload
        private void Button2_Click(object sender, EventArgs e)
        {
            urDecider("upload");
        }

        //select file
        private void Button3_Click(object sender, EventArgs e)
        {
            urDecider("selectF");
        }

        //main menu
        private void Button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
            label2.Visible = false;
            urDecider("main");
        }

        //upload pic to database
        private void uploadPic()
        {
            if (fileNamePath != null && destination != null)
            {
                File.Copy(fileNamePath, destination);
                TTStruct.UploadReceipt(filename, this.id);
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

        //select pic file from device
        private void selectF()
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

        //goes to main menu
        private void mainMneu()
        {
            this.Hide();
            MainMenu mm = new MainMenu(id);
            mm.Show();
        }
    }
}
