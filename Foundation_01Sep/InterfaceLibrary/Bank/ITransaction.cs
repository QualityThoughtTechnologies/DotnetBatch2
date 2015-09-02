using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary.Bank
{
    public interface ITransaction
    {
        void Transfer(IBankAccount from,IBankAccount toAccount, double amount);
    }
}
