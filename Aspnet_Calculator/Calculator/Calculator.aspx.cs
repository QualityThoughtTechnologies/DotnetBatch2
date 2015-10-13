using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string value = (sender as Button).Text;
            if(txtResult.Text=="0")
            {
                txtResult.Text = value;
            }
            else
            {
                txtResult.Text += value;
            }
        }

        private static string value1;
        private static string operation;
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            value1 = txtResult.Text;
            txtResult.Text = "0";
            operation = "Add";
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if(operation=="Add")
            {
                txtResult.Text = (int.Parse(value1) + int.Parse(txtResult.Text)).ToString();
            }
            else
            {
                txtResult.Text = (int.Parse(value1) - int.Parse(txtResult.Text)).ToString();
            }
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            value1 = txtResult.Text;
            txtResult.Text = "0";
            operation = "Sub";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value1 = string.Empty;
            operation = string.Empty;
        }
    }
}