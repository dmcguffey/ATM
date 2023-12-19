using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.models.models
{
    internal abstract class Account
    {
        public string AccountOwner { get; set; }
        public abstract string AccountType { get; }
        public int AccountNumber {  get; protected set; }
        public double balance {  get; protected set; }
        public string CardNumber { get; protected set; }
        public int pinNumber { get; protected set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"-----Account Information-----");
            Console.WriteLine($"Name: {AccountOwner}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"{AccountType}");
            Console.WriteLine($"Current Balance: {balance}");
            Console.WriteLine("------------------------------");
        }

    }
}
