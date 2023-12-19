using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business.Services
{
    public class CardCheck
    {
        public CardCheck() { }
        
        public static bool IsCard(string CardNumber)
        {
            int sum = 0;

            foreach(var digit in CardNumber.Split(','))
            {
                var number = int.Parse(digit);
                if (number % 2 != 0)
                {
                    number *= 2;
                }
                sum = number / 10;
                sum = number % 10;

            }

            return (sum % 10 == 0);
        }
    }
}
