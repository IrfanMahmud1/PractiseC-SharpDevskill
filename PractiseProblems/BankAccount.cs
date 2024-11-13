using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class BankAccount2
    {
        public string AccountNumber { get; set; }
        public double Balance { get;private set; }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
