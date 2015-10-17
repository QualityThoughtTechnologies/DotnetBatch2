using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QualityThoughtWebSample
{
    public partial class CourseMangement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString=ConfigurationManager.ConnectionStrings["QualityThoughtDb"].ConnectionString;
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    string.Format("INSERT INTO Courses ([Course Name] ,[Course Description])  VALUES ('{0}','{1}')", txtCourseName.Text, txtCourseDescription.Text), connection);
                int recordsInserted=command.ExecuteNonQuery();
                
            }
        }
    }
}