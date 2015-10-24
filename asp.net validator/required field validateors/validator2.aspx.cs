using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace required_field_validateors
{
    public partial class validator2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnSubmitForm_Click1(object sender, EventArgs e)
        {
            Label1.Text = "Welcome, " + Server.HtmlEncode(txtName.Text);
        }
    }
}