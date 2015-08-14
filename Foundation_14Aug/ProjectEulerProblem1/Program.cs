using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            int number = int.Parse(Console.ReadLine());
            int sum=0,firstNumber=3,secondNumber=5,index=0;
            do
            {
                if((index%firstNumber==0)||(index%secondNumber==0))
                {
                    sum += index;
                }
                index++;
            } while (index < number);

            Console.WriteLine( "Sum is "+sum);
        }
    }
}
