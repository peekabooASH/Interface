using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_01
{
    class CheckingAccount : IAccount
    {
        public double Balance { get; set; }
        public string Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public string Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
