using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary.Bank
{
    /// <summary>
    /// This interface will be used for Bank Accounts
    /// </summary>
    public interface IBankAccount
    {
        /// <summary>
        /// This method will be used to perform deposit
        /// </summary>
        /// <param name="amount"></param>
        void Deposit(double amount);

        void Withdraw(double amount);

        double Balance { get; }

        void Transfer(IBankAccount toAccount, double amount);

        ITransaction Transaction { get; set; }

    }
}
