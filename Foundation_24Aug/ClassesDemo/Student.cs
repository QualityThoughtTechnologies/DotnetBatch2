using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Student
    {
        string name;
        string address;

        public void DisplayInformation()
        {
            Console.WriteLine("Name is "+name+" Address is "
                + address+" Phone Number is "+ PhoneNumber);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAdress(string address)
        {
            this.address = address;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string GetName()
        {
            return this.name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string PhoneNumber { set; get; }
    }
}
