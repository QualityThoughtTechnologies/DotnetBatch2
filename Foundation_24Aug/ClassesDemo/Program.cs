using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Test";
            student.SetAdress("Test");
            student.SetPhoneNumber("99999999");
            student.DisplayInformation();
        }
    }
}
