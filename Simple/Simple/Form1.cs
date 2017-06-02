using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple
{
    public partial class frmSample : Form
    {
        public frmSample()
        {
            InitializeComponent();
            Text = "Window ...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxFullName.Clear();
            txtBoxFirstName.Focus();
        }

        private void btnDispalyFullName_Click(object sender, EventArgs e)
        {
            string strFullName;
            strFullName = txtBoxFirstName.Text + " " + txtBoxLastName.Text;
            //MessageBox.Show("your full name is " + strFullName);
            lblFullName.Visible = true;
            txtBoxFullName.Visible = true;
            txtBoxFullName.Text = strFullName;
            txtBoxFullName.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            this.BackColor = Color.FromName(cmbFavColor.Text);
            
          
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoDivorced_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAnimalLover_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox item in grpAnimal.Controls)
            {
                item.Checked = chkAnimalLover.Checked;
            }

            /*if (chkAnimalLover.Checked)
            {
                foreach (CheckBox item in grpAnimal.Controls)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox item in grpAnimal.Controls)
                {
                    item.Checked = false;
                }
            }
            
            /* if (chkAnimalLover.Checked)
            {
                chkDog.Checked = true;
                chkCat.Checked = true;
                chkBird.Checked = true;
            }
            else
            {
                chkDog.Checked = false;
                chkCat.Checked = false;
                chkBird.Checked = false;
            }*/
        }
    }
}
