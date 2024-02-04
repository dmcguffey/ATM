using ATM.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.models.models;

namespace ATM.Business.Services
{
    public class AccountService : ICommandService
    {
        public decimal Deposit(decimal balance,decimal amount)
        {
            return balance += amount;
        }

        public decimal Withdraw(decimal balance, decimal amount)
        {
            return balance -= amount;
        }

        public (decimal newBalance, decimal newAccountBalance) TransferFunds(decimal balance, decimal AccountBalance, decimal amount)
        {
            balance += amount;
            AccountBalance -= amount;
            return (balance, AccountBalance);
        }
    }
}
