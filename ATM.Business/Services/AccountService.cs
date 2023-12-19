using ATM.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.models.models;

namespace ATM.Business.Services
{
    internal class AccountService : ICommandService
    {
        public void deposit(decimal balance,decimal amount)
        {
            balance += amount;
        }

        public void withdraw(decimal balance, decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(decimal balance, decimal amount, decimal AccountBalance)
        {
            balance = balance + amount;
            AccountBalance = AccountBalance - amount;
        }
    }
}
