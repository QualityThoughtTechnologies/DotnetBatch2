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
            Console.WriteLine("Do you want to add a new student record if No press enter");
            string userInput=Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(userInput)) 
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
            } 

            do{
                string userChoice = "0";
                Console.WriteLine("Enter 0 to display all the contents & 1 to search");
                userChoice = Console.ReadLine();
                IConvertor<Student, String> convertor = new StudentToStringConvertor();
                IList<Student> studentList = new List<Student>();
                AddStudentsToList(convertor, studentList);
                if(userChoice.Equals("0"))
                {
                    foreach(Student s in studentList)
                    {
                        Console.WriteLine("Name is {0}, Id is {1}, phone number is {2}",
                            s.Name, s.Id, s.PhoneNumber);
                    }
                }
                else
                {
                    
                    Console.WriteLine("Enter Id");
                    int id = int.Parse(Console.ReadLine());
                    bool isFound = false;
                    foreach(Student s in studentList)
                    {
                        if(s.Id==id)
                        {
                            isFound = true;
                            Console.WriteLine("Name is {0}, Id is {1}, phone number is {2}",
                            s.Name, s.Id, s.PhoneNumber);
                            break;
                        }
                    }
                    if(!isFound)
                    {
                        Console.WriteLine("Could not find any record");
                    }
                }

                Console.WriteLine("Do you want to continue. Press Enter to exit");
                userInput = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(userInput));
            
        }

        private static void AddStudentsToList(IConvertor<Student, String> convertor, IList<Student> studentList)
        {
            foreach (string line in File.ReadAllLines("Students.txt"))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                Student student = convertor.ConvertFrom(line);
                studentList.Add(student);

            }
        }
    }
}
