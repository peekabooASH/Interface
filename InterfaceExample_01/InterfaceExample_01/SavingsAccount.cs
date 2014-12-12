using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_01
{
    class SavingsAccount : IAccount
    {

        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";

        }
    }
}
