using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QualityThoughtWebSample
{
    public partial class Candidate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["QualityThoughtDb"].ConnectionString;
              
        }
    }
}