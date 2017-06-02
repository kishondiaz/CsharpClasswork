using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Moives' table. You can move, or remove it, as needed.
            this.moivesTableAdapter.Fill(this.moviesDataSet.Moives);

        }

        private void moivesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moivesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.moviesDataSet);

        }

        private void moivesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
