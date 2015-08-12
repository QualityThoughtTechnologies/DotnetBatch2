using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkForContinue = 1;
            while (checkForContinue==1)
            {
                Console.WriteLine(" Please enter your input");
                string input = Console.ReadLine();

                int dayOfWeek = int.Parse(input);
                switch (dayOfWeek)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    default:
                        Console.WriteLine("Please complete the code & check");
                        break;
                }
                Console.WriteLine("Do you want to continue. Press 0 to exit or 1 to continue");
                string inputForContinuty = Console.ReadLine();
                checkForContinue = int.Parse(inputForContinuty); 
            }
            
        }
    }
}
