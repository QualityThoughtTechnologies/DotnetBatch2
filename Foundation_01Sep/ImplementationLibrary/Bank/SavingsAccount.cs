using InterfaceLibrary.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary.Bank
{
    public class SavingsAccount:IBankAccount
        //,ITransaction
    {
        double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount<=balance)
            {
                balance -= amount;
            }
            

        }

        public void Transfer(IBankAccount toAccount, double amount)
        {
            Transaction.Transfer(this, toAccount, amount);
        }

        public double Balance
        {
            get { return balance; }
        }

        public ITransaction Transaction { get; set; }
    }
}
