using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business.Interfaces
{
    public interface ICommandService
    {

        //withdraw
        public void withdraw(decimal balance, decimal amount);

        //deposit
        public void deposit(decimal balance, decimal amount);
        //Transfer funds from checking to savings or vice versa
        public void TransferFunds(decimal balance, decimal amount, decimal AccountBalance);
    }
}
