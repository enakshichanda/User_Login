using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        

        private void Display_Click(object sender, EventArgs e)
        {
            //Puts the cursor focus on the Name Textbox
            nameBox.Focus();
            
            // Condition to check if Name and Student Number fields are empty
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                string emptyBox = "Please enter Student Name";
                MessageBox.Show(emptyBox);
            }
            if
                (string.IsNullOrEmpty(studentNum.Text))
            {
                string emptyBox1 = "Please enter Student Number";
                MessageBox.Show(emptyBox1);
            }
            else
            {   
                
                informationBox.Visible = false;
                clearBox.Enabled = false;    //Clearbox disabled as per requirement
                detailsBox.Visible = true;
                studentLabel.ForeColor = System.Drawing.Color.Red; //setting a default color for display
                welcomeLabel.ForeColor = System.Drawing.Color.Red;
                studentLabel.Text = "Hi " + nameBox.Text + " .Thanks for logging in with " + studentNum.Text; //displays text if details are entered in Name and Student Number.
                welcomeLabel.Text = "Have a Wondeful day ahead ";
                blue.Checked = true;
                imgDesc.ForeColor = System.Drawing.Color.Blue; //setting a default forecolor for display
                clearBox.Enabled = true; // Clearbox enabled
                imgDesc.Text = "Female"; //displays the first message after clicking the submit button


            }
        }
        

        private void Male_Click(object sender, EventArgs e)
        {
    

            // Makes the female picturebox visible and hides the male picturebox.
             female.Visible = true;
             male.Visible = false;
             imgDesc.Text = "Female";
        }

        private void Female_Click(object sender, EventArgs e)
        {


          // Makes the male picturebox visible and hides the female picturebox.
            male.Visible = true;
            female.Visible = false;
            imgDesc.Text = "Male";
        }
            
        private void InformationBox_Enter(object sender, EventArgs e)
        {

        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            //if we click on the red radiobutton the texts change to red
            string scolor = "";

            if (red.Checked)
            {
                scolor = red.Text;
            }

            Color c = Color.FromName(scolor);
            imgDesc.ForeColor = c;
            studentLabel.ForeColor = c;
            welcomeLabel.ForeColor = c;
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            //if we click on the blue radiobutton the texts change to blue
            string scolor = "";

            if (blue.Checked)
            {
                scolor = blue.Text;
            }

            Color c = Color.FromName(scolor);
            imgDesc.ForeColor = c;
            studentLabel.ForeColor = c;
            welcomeLabel.ForeColor = c;

        }

        private void Black_CheckedChanged(object sender, EventArgs e)
        {
            //if we click on the pink radiobutton the texts change to pink
            string scolor = "";

            if (pink.Checked)
            {
                scolor = pink.Text;
            }

            Color c = Color.FromName(scolor);

            imgDesc.ForeColor = c;
            studentLabel.ForeColor = c;
            welcomeLabel.ForeColor = c;
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            //if we click on the green radiobutton the texts change to green
            string scolor = "";

            if (green.Checked)
            {
                scolor = green.Text;
            }

            Color c = Color.FromName(scolor);
            imgDesc.ForeColor = c;
            studentLabel.ForeColor = c;
            welcomeLabel.ForeColor = c;
        }

       
        private void NameBox_MouseHover(object sender, EventArgs e)
        {
            //Tooltip created to hover over name
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(this.nameBox, "Please enter your Name");
        }

        private void StudentNum_MouseHover(object sender, EventArgs e)
        {
            //Tooltip created to hover over student number
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(this.studentNum, "Please enter your Student Number");
        }

        private void Female_MouseHover_1(object sender, EventArgs e)
        {
            //Tooltip created to hover over picturebox image
            ToolTip image1 = new ToolTip();
            image1.SetToolTip(this.female, "Please choose your gender");
        }

        private void Male_MouseHover(object sender, EventArgs e)
        {
            ToolTip image2 = new ToolTip();
            image2.SetToolTip(this.male, "Please choose your gender");
        }
private void ClearBox_Click(object sender, EventArgs e)
    {
        //clears the data from the form and opens a new form
        Form1 NewForm = new Form1();
        NewForm.Show();
        this.Dispose(false);
        clearBox.Enabled = false;
    }
        private void Exit_Click(object sender, EventArgs e)
        {
            //closes the form and all its background threads after clicking on the exit button
            this.Close();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}


