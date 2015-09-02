using InterfaceLibrary.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary.Bank
{
    public class RTGSTransaction:ITransaction
    {

        public void Transfer(IBankAccount from, IBankAccount toAccount, double amount)
        {
            Console.WriteLine("RTGS  Started");
            from.Withdraw(amount);
            toAccount.Deposit(amount);
            Console.WriteLine("RTGS Completed");
        }
    }
}
