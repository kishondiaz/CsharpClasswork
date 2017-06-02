using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
            lblDate.Text = DateTime.Now.ToString();
        }

        protected void GridViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}