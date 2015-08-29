using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Max number of Students");
            int maxStudents = int.Parse(Console.ReadLine());
            string[] students = new string[maxStudents];
            for(int index=0;index<maxStudents;index++)
            {
                Console.WriteLine( "Enter Student Id");
                string studentId = Console.ReadLine();
                students[index] = studentId;
                Console.WriteLine("If you want to exit press Enter");

                string userChoice = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(userChoice))
                {
                    break;
                }
            }

            for(int index=0;index<maxStudents;index++)
            {
                string studentId = students[index];
                if(string.IsNullOrWhiteSpace(studentId))
                {
                    break;
                }
                Console.WriteLine("Student Id:{0}",students[index]);
            }
        }
    }
}
