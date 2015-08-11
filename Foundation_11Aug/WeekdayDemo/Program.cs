using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekdayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=0;

            if(choice==0)
            {
                Console.WriteLine("Sunday");
            }
            else if (choice == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (choice == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Please enter between 0 & 6");
            }
        }
    }
}
