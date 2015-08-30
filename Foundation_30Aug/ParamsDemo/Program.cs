using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = new string[] { "Test1", "Test2", "Test3", "Test4" };
            Display(items);
            Console.WriteLine();
            Console.WriteLine();
            DisplayUsingParams( "Test1", "Test2", "Test3","Test4");
            Console.WriteLine();
            Console.WriteLine();
            DisplayUsingParams();
            Console.WriteLine();
            Console.WriteLine();
            DisplayUsingParams(args);
            DisplayUsingParams();

            Console.WriteLine();
            Console.WriteLine();
            Display("Test", "99999999");
            Display("Test1", "99999997","Bangalore");

            Display(city:"Chennai",phoneNumber: "test", name: "Test2");
        }

        static void Display(string[] items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayUsingParams(params string[] items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        static void Display(string name, string phoneNumber, string city="Hyderabad")
        {
            Console.WriteLine("Name is {0}, Phone Number is {1}, City is {2}",name,phoneNumber,city);
        }
       
    }
}
