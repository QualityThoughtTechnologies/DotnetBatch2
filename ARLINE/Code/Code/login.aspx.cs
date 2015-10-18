using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    String constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString.ToString();
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con=new SqlConnection(constring);
        SqlCommand cmd=new SqlCommand() ;
        cmd.CommandType=CommandType.Text;
        cmd.Connection=con;
        con.Open();
        cmd.CommandText="select username,Type from Reg where username='"+TextBox1.Text+"' and password='"+TextBox2.Text+"'";
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand=cmd;
        DataSet ds=new DataSet();
        da.Fill(ds,"emp");
        if(ds.Tables["emp"].Rows.Count>0)
        {
            string check;
            check =ds.Tables["emp"].Rows[0]["Type"].ToString();
            Session["Type"] = check;
            Response.Redirect("home.aspx");
        }
        else
        {
            Label.Visible=true;
            Label.Text="Invalid username or password";
        }


        con.Close();



    }
}
