using InterfaceLibrary.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary.Communications
{
    public class PhoneCommunication : CommunicationBase
    {

        public override void SendNotification(InterfaceLibrary.Bank.Customer.Customer customer, string notificationMessage)
        {
            string phoneNUmber = GetContactNumber(customer);
            Console.WriteLine("Sending sms with message {0} to {1}", notificationMessage, phoneNUmber);

        }
    }
}
