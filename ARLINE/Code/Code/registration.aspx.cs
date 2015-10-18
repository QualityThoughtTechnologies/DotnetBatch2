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
public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    String constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString.ToString();
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = "insert into Reg(Name,Address,Emailid,username,password,Type) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','"+DropDownList1.Text+"')";
        int i = cmd.ExecuteNonQuery();
        if (i>0)
        {
            Label.Visible = true;
            Label.Text = "sucess";
        }

        else
        {
            Label.Visible = true;
            Label.Text = "error";

        }
        con.Close();
    }
}