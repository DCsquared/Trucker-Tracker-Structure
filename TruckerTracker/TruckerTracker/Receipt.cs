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
    //allows the user to upload a picture of the reciept
    public partial class Receipt : Form
    {
        /* fileNamePath is the path to the file filename
         * destination is the path to the receipts folder
         * filename is the naem of the target file without the path
         * id is the id of the logged in user
         */
        private string fileNamePath;
        private string destination;
        private string filename;
        private int id;

        //the constructor for the receipt form
        public Receipt(int loggedInID)
        {
            id = loggedInID;         
            InitializeComponent();
        }
        
        //the decider for the upload receipt page
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

        //upload button
        private void Button2_Click(object sender, EventArgs e)
        {
            urDecider("upload");
        }

        //select file button
        private void Button3_Click(object sender, EventArgs e)
        {
            urDecider("selectF");
        }

        //main menu button
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
                //display error if wrong or no file was select
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
                //process for getting the file and saving a copy to in app folder

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
