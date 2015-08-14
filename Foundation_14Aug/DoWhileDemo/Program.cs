using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int mainIndex = 2;

            do
            {
                //Console.WriteLine("Enter input");
                //int number = int.Parse(Console.ReadLine());
                int number = mainIndex;
                int index = 2;
                bool isPrime = true;
                while (index < number - 1)
                {
                    if (number % index == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    index++;
                }
                if (isPrime)
                {
                    Console.WriteLine(number + " is a prime number");
                }
                //else
                //{
                //    Console.WriteLine(number + " is not a prime number");
                //} 
                mainIndex++;
            } while (mainIndex<maxNumber);
        }
    }
}
