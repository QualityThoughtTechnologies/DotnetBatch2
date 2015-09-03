using InterfaceLibrary.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary.Communications
{
    public class EmailCommunication:CommunicationBase
    {
        public override void SendNotification(InterfaceLibrary.Bank.Customer.Customer customer, string notificationMessage)
        {
            string email=GetEmail(customer);
            Console.WriteLine("Sending Email with message {0} to {1}",notificationMessage,email);
         
        }
    }
}
