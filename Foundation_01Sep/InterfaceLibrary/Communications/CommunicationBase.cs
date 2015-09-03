using InterfaceLibrary.Bank.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary.Communications
{
    public abstract class CommunicationBase
    {
        public abstract void SendNotification(Customer customer,string notificationMessage );

        protected virtual string GetContactNumber(Customer customer)
        {
            if(customer==null)
            {
                return null;
            }
            return customer.Identity.ContNumber;
        }

        protected virtual string GetEmail(Customer customer)
        {
            if (customer == null)
            {
                return null;
            }
            return customer.Identity.EmailID;

        }

    }
}
