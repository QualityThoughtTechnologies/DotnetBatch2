using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput="Not";
            do
            {
                Student s = new Student();
                Console.WriteLine("Enter id");
                int id;
                if(int.TryParse(Console.ReadLine(),out id))
                {
                    s.Id = id;
                }
                else
                {
                    Console.WriteLine("Invalid id Please retry");
                    continue;
                }
                Console.WriteLine("Enter Name");
                s.Name = Console.ReadLine();
                Console.WriteLine("Enter PHone NUmber");
                s.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Do you want to continue. Press Enter to exit");
                userInput = Console.ReadLine();
                File.AppendAllText("Students.txt", s.ToString()+Environment.NewLine);
            } while (!string.IsNullOrWhiteSpace(userInput));

            do{
                string userChoice = "0";
                Console.WriteLine("Enter 0 to display all the contents & 1 to search");
                userChoice = Console.ReadLine();
                if(userChoice.Equals("0"))
                {
                    Console.WriteLine(File.ReadAllText("Students.txt"));
                }

                Console.WriteLine("Do you want to continue. Press Enter to exit");
                userInput = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(userInput));
            
        }
    }
}
