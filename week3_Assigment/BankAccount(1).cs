using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentc_
{
    class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance");
            }
            else
            {
                throw new ArgumentException("Withdrawal amount must be positive");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
