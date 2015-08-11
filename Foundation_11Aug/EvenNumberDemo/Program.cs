using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 76;

            //checking for all invalid value

            number = 0;
            if (number>0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }

                //note: The else is commented to check different if statement
                //else
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd Number");
                } 
            }
            else
            {
                Console.WriteLine("Please enter positive integers");
            }

            
        }
    }
}
