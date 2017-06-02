using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Question2SportingEvents
{
    public partial class Form1 : Form
    {
        string firstName, lastName;
        bool boyOrGirl = false;
        bool[] whichSport;
        int count = 0;
        string gender,sport;
        public Form1()
        {
            InitializeComponent();
            firstName = "";
            lastName = "";
            whichSport = new bool[6];
            
            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            /*if (radioBtnBoy.Checked && radioBtnSoccer.Checked)
            {
                picBx.Image = imgList.Images[0];
            }
            if (radioBtnBoy.Checked && radioBtnSoccer.Checked)
            {
                picBx.Image = imgList.Images[1];
            }
            if (radioBtnBoy.Checked && radioBtnSoccer.Checked)
            {
                picBx.Image = imgList.Images[0];
            }
            if (radioBtnBoy.Checked && radioBtnSoccer.Checked)
            {
                picBx.Image = imgList.Images[0];
            }
             if (radioBtnBoy.Checked && radioBtnSoccer.Checked)
            {
                picBx.Image = imgList.Images[0];
            }*/
            if(radioBtnBoy.Checked)
                gender = "Boy";
            if (radioBtnGirl.Checked)
                gender = "girl";
            if (radioBtnSoccer.Checked)
            {
                picBx0.Visible = true;
                //picBx0.BringToFront();
                sport = "soccer";
            }
            else if(radioBtnFlagBall.Checked)
            {
                picBx0.Visible = false;
                pxBx2.Visible = true;
                sport = "flag Football";
                
            }else if(radioBtnBasketBall.Checked)
            {
                pxBx2.Visible = false;
                pxBx3.Visible = true;
                sport = "Basketball";
            }else if(radioBtnSoftBall.Checked)
            {
                pxBx3.Visible = false;
                pxBx4.Visible =true;
                sport = "Soft Ball";
            }else if(radioBtnField.Checked)
            {
                pxBx4.Visible = false;
                pxBx5.Visible = true;
                sport = "FieldHockey";
            }
            
            
           
                
        }
        private void txtBxFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = txtBxFirstName.Text;
        }

        private void txBxLastname_TextChanged(object sender, EventArgs e)
        {
            lastName = txBxLastname.Text;
        }

        private void grpGender_Enter(object sender, EventArgs e)
        {
            if (radioBtnBoy.Checked)
                boyOrGirl = true;
            else if(radioBtnGirl.Checked)
                boyOrGirl = false;
            if (boyOrGirl)
            {
                Console.WriteLine(boyOrGirl);
            }
         
        }

        private void grpSports_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("here so");
        }

        private void radioBtnBoy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnGirl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnFlagBall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnBasketBall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnSoftBall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnField_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show(firstName +" "+ lastName + " has registered for " + gender+" "+sport,"",MessageBoxButtons.OK);
        }
    }
}
