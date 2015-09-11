using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    public class Book
    {
        public double Price { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// This method is used to display Book info
        /// </summary>
        /// <exception cref="System.Exception">When the name andprice are not initalized</exception>
        public void Display()
        {
            try
            {
                Class1.ISBNSearch(Name);
            }
            catch (MyException ex)
            {
                Console.WriteLine("ISBN Search Failed");
                throw ;
            }
            if(String.IsNullOrWhiteSpace(Name) && Price==0)
            {
                throw new MyException("PLease initialize name & Price");
            }

            Console.WriteLine("Name is {0} & price is {1}",Name,Price);
        }
    }
}
