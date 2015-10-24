using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace required_field_validateors
{
    public partial class Courses : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public String Header
        {
            set {
                Label1.Text = value;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Header = "Processing";
        }
    }
}