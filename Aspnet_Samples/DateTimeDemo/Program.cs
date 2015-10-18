using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            //s.S
            s.Start();

            do
            {
                DateTime date = DateTime.Now;
                DateTime universalDate = DateTime.UtcNow;
                Console.WriteLine(date);
                Console.WriteLine(universalDate);
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine(date.ToShortTimeString());
                CultureInfo culture = new CultureInfo("zh-CN");
                Console.WriteLine(date.ToString(culture));
                Console.WriteLine(date.AddYears(3).ToString());

                TimeSpan t = date - universalDate;
                Console.WriteLine(t.Hours);

                Console.WriteLine(date.ToString("MMM-dd-yyyy")); 
            } while (s.Elapsed.Seconds<20);
        }
    }
}
