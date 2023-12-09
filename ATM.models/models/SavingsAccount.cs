using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.models.models
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount() { }

        public override string AccountType => "Savings";
    }
}
