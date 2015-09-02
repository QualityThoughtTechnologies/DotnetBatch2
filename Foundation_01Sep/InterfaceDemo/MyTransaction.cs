using InterfaceLibrary.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class MyTransaction:ITransaction
    {
        public void Transfer(IBankAccount from, IBankAccount toAccount, double amount)
        {
            Console.WriteLine("MY Transaction Started");
            from.Withdraw(amount);
            Console.WriteLine("FROM "+from.Balance);
            toAccount.Deposit(amount);
            Console.WriteLine("TO " + toAccount.Balance);
            Console.WriteLine("MY Transaction Started");
        }
    }
}
