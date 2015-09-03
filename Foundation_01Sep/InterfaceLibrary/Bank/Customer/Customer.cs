using InterfaceLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary.Bank.Customer
{
    public class Customer
    {
        public Customer()
        {
            PrefferedCommunicationModes = new[] { "Email", "Phone" };
        }

        public Address Address { get; set; }

        public PersonalIdentification Identity { get; set; }

        public IBankAccount Account { get; set; }

        public string[] PrefferedCommunicationModes { set; get; }
    }
}
