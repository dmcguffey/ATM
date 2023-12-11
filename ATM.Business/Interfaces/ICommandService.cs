using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business.Interfaces
{
    public interface ICommandService
    {
        //display balance for users
        public void DisplayBalance() { }

        //withdraw
        public void withdraw(decimal amount) { }

        //deposit
        public void deposit(decimal amount) { }
    }
}
