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
        public override string AccountType => "Checking";

    }
}
