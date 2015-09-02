using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int fibonnaci=0;
            Console.WriteLine(" Please enter your input");
            string input = Console.ReadLine();
            Console.Write("1 2 ");
            int number = int.Parse(input);
            int sum = 2;
            int index = 1;
            while(index<=50)
            //while (fibonnaci<number)
            {
                fibonnaci = firstNumber + secondNumber;
                if(fibonnaci>number)
                {
                    break;
                }
                Console.Write(fibonnaci);
                Console.Write(" ");
                firstNumber = secondNumber;
                secondNumber = fibonnaci;
                if(fibonnaci%2==0)
                {
                    sum += fibonnaci;
                    index++;
                }
            }

            Console.ReadLine();

        }
    }
}
