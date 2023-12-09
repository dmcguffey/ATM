using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.models.models
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(){ }
        
        public int CardNumber { get; protected set; }
        public int pinNumber { get; protected set; }

        public override string AccountType => "Checking";

    }
}
