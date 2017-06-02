using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Question1MessageDisplay
{
    public partial class Form1 : Form
    {
        bool doOnce = false,isPressed = false;
        public Form1()
        {
            InitializeComponent();
            //lblDispayQuotes.Text = DisplayText;
  
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void btnAddQuote_Click(object sender, EventArgs e)
        {

            if (!cmbQuots.Items.Contains(cmbQuots.Text))
            {
                lblDispayQuotes.Text = cmbQuots.Text;
                cmbQuots.Items.Add(cmbQuots.Text);
                doOnce = true;
                isPressed = true;

            }

            isPressed = true;
            
          
            

            
        }

        private void cmbQuots_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string item in cmbQuots.Items)
            {
                if (cmbQuots.SelectedIndex == cmbQuots.Items.IndexOf(item))
                {
                    Console.WriteLine(item);
                    lblDispayQuotes.Text = item;
                }
              
            }
           
           // lblDispayQuotes.Text = cmbQuots.SelectedText;
        }

        private void cmbQuots_TextUpdate(object sender, EventArgs e)
        {
            if (cmbQuots.Text == null)
            {
                lblDispayQuotes.Text = cmbQuots.Text;
            }
        }

        private void cmbQuots_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine("here");
            //cmbQuots.ResetText();
        }

        private void lblDispayQuotes_TextChanged(object sender, EventArgs e)
        {
            if (isPressed)
            {
                cmbQuots.SelectedIndex = -1;
                isPressed = false;
            }
         
            cmbQuots.SelectedIndex = -1;
            
        }

        private void formatSubMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();

            lblDispayQuotes.Font = fontDialog.Font;

            /*ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();*/
            //lblDispayQuotes.Font
        }

        private void formatSubMenuItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            lblDispayQuotes.ForeColor = colorDialog.Color;
        }
    }
}
