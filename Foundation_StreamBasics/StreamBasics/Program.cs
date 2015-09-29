using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader=new StreamReader("Read.txt"))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                } while (!string.IsNullOrWhiteSpace(line));
                }
        }
    }
}
