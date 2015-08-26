using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusrname.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(this, "Please enter  user Name and Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtusrname.Clear();
                txtPassword.Clear();
            }
            else
            {
                if (txtusrname.Text == "admin" || txtusrname.Text == "ADMIN" && txtPassword.Text == "admin")
                {
                    MessageBox.Show(this, "Login Successfully", "Login status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Invalid user Name and Password", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtusrname.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
