using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Faculty
    {
        public string Name { set; get; }

        public string PhoneNUmber { set; get; }

        public string Address { set; get; }

        public void DisplayINformation()
        {
            //Console.WriteLine("Name is "+Name+ " Address is "+ Address+ "Phone Number is"+PhoneNUmber);
            //string.Format("")

            Console.WriteLine(
                "Name is {0}, Adress is {1}, Phone number is {2}",
                Name,Address,PhoneNUmber);
        }
    }
}
