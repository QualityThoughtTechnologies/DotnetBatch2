using ImplementationLibrary.Bank;
using InterfaceLibrary.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount savingsAccount = new SavingsAccount();
            IBankAccount currentAccount = new CurrentAccount();

            savingsAccount.Deposit(1000);
            DisplayBalance(savingsAccount);
            savingsAccount.Withdraw(100);
            DisplayBalance(savingsAccount);
            savingsAccount.Withdraw(2000);
            DisplayBalance(savingsAccount);

            currentAccount.Deposit(10000);
            DisplayBalance(currentAccount);
            currentAccount.Withdraw(15000);
            DisplayBalance(currentAccount);

            savingsAccount.Transaction = new MyTransaction();
            savingsAccount.Transfer(currentAccount, 100);
            DisplayBalance(savingsAccount);
            DisplayBalance(currentAccount);
            



        }

        private static void DisplayBalance(IBankAccount account)
        {
            Console.WriteLine(account.Balance);
        }
    }
}
