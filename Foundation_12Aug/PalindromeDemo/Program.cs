using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int number = 100;number<=999;number++)
            {
                int tempNumber = number;
                int reverse = 0;
                while (tempNumber != 0)
                {
                    int remainder = tempNumber % 10;
                    tempNumber = tempNumber / 10;
                    reverse = reverse * 10 + remainder;

                }

                if (number == reverse)
                {
                    Console.Write(number + " ");
                }
            }

            
        }
    }
}
