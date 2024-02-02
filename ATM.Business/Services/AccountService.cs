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

        /*public decimal TransferFunds(decimal balance, decimal amount, decimal AccountBalance)
        {
            balance = balance + amount;
            AccountBalance = AccountBalance - amount;
        }*/
    }
}
