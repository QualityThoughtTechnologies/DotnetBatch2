using InterfaceLibrary.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary.Bank
{
    public class CurrentAccount:IBankAccount
        //,ITransaction
    {
        double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;

        }

        public double Balance
        {
            get { return balance; }
        }

        public void Transfer(IBankAccount toAccount, double amount)
        {
            Transaction.Transfer(this, toAccount, amount);
        }

        public ITransaction Transaction { get; set; }
    }
}
