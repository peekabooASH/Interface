using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_01
{
    public interface IAccount
    {
        double Balance { set; get; }
        string Deposit(double amount);
        string Withdraw(double amount);
    }
}
