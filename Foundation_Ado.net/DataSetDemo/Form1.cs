using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using(SqlConnection connection=new SqlConnection("Data Source=.;Initial Catalog=DotnetBatch2;Integrated Security=True"))
            {
                SqlDataAdapter dataAdapter=new SqlDataAdapter("Select * from student_master",connection);
                DataTable table=new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            
        }
    }
}
