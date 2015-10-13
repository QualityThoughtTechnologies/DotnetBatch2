using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class CaseConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUserText_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = txtUserText.Text.ToLower();
            TextBox2.Text = txtUserText.Text.ToUpper();
        }
    }
}