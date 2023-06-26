using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Account
    {
        int accountBalances = 1000;
        public void SetBalance(int Amount)
        {
            accountBalances = Amount;   
        }
        public void GetBalances()
        {
            Console.WriteLine($"Your Account Balances is {accountBalances}");
        }
    }
}
