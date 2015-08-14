using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            int index = number;
            while (index>0)
            {
                factorial *= index;
                index--;
            }
            Console.WriteLine("Factorial is "+factorial);
        }
    }
}
