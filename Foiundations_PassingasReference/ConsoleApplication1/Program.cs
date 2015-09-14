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
            double rate;
            double time=5;
            Console.WriteLine(GetInterest(10000, out rate, ref time)); ;
            Console.WriteLine(rate);
            Console.WriteLine(time);
            //int.TryParse
        }

        static double GetInterest(double principle,out double rateOfIntrest,ref double timeInYears)
        {
            rateOfIntrest = 4;
            timeInYears++;
            return principle * timeInYears * rateOfIntrest / 100;
        }
    }
}
