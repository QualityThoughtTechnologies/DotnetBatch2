using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="System.ArgumentNullException"/>
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter any number");
            try
            {
                int test = int.Parse(Console.ReadLine());
                Console.WriteLine(test);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error Occured. Please Enter a valid value");
                Console.WriteLine(" Enter any value to read error details, press Enter to exit");

                string choice = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Message is "+ex.Message);
                    Console.WriteLine("Stack Trace is "+ex.StackTrace);
                }
            }
            //catch(Exception)
            //{
            //    Console.WriteLine("Enter valid value in the range of {0} an {1}", int.MinValue, int.MaxValue);
            //}

               // Console.WriteLine("Please visit us again");
            finally
            {
                Console.WriteLine("Please visit us again");
            }

            try
            {
                throw new ArgumentException();
                Book book = new Book();
                book.Display();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
