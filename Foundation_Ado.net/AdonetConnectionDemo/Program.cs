using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=DotnetBatch2;Integrated Security=True";
            //using(SqlConnection connection=new SqlConnection(connectionString))
            //{
            //    SqlCommand updateCommand = new SqlCommand("update student_master set ph_no='99999999' where ph_no IS NULL", connection);
            //    connection.Open();
            //    int rowsAffected=updateCommand.ExecuteNonQuery();
            //    Console.WriteLine("Rows effected are {0}",rowsAffected);
            //    connection.Close();
            //}

            //using(SqlConnection connection=new SqlConnection(connectionString))
            //{
            //    Console.WriteLine("Enter Student Id");
            //    string id = Console.ReadLine();
            //    Console.WriteLine("Enter Student Name");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter address");
            //    string address = Console.ReadLine();
            //    Console.WriteLine("Enter phone number");
            //    string phoneNo = Console.ReadLine();
            //    string insertCommand = "insert into student_master values('{0}','{1}','{2}','{3}')";
            //    SqlCommand insertSqlCommand = new SqlCommand(
            //        string.Format(insertCommand, id, name, address, phoneNo), connection);
            //    connection.Open();
            //    insertSqlCommand.ExecuteNonQuery();
            //    connection.Close();

            //}

            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand("Select * from student_master", connection);
                connection.Open();
                using (SqlDataReader dataReader = selectCommand.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        Console.WriteLine(dataReader["ph_no"]);
                    }
                }
            }
        }
    }
}
