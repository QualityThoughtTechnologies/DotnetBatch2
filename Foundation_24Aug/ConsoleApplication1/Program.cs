using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factors(35);
            return;
            int maxNumber = 20;
            int largestPossibleValue=1;
            for(int index=1;index<=maxNumber;index++)
            {
                largestPossibleValue *= index;

            }
            int number=0;
            for(int index=1;index<largestPossibleValue;index++)
            {
                bool isDivisible = true;
                for(int tempIndex=1;tempIndex<=maxNumber;tempIndex++)
                {
                    if(index%tempIndex!=0)
                    {
                        isDivisible = false;
                        break;
                    }

                }

                if(isDivisible)
                {
                    number = index;
                    break;
                }
            }
            Console.WriteLine(number);

        }

        static bool IsPrime(int number)
        {
            bool isPrime = true;
            for(int index=2;index<number/2+1;index++)
            {
                if(number%index==0)
                {
                    isPrime = false;
                    break;
                }

            }
            return isPrime;
        }

        static void Factors(int number)
        {

            for(int index=2;index<number/2+1;index++)
            {
                if(number%index==0)
                {
                    if(IsPrime(index))
                    {
                        Console.WriteLine(index);
                    }
                }
            }
        }
    }
}
