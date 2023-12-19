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
        
        public static bool IsCard(string cardNumber)
        {
            //sum will be what is used to determine if number is divisible by 10
            int sum = 0;
            //for determining if multiplying the digit by two is double digit
            bool doubleDigit = false;
            //create a new array to go through. Reversing the array allows for easier processing.
            char[] cardDigits = cardNumber.ToCharArray();
            Array.Reverse(cardDigits);

            foreach(var digit in cardDigits)
            {
                //must check if number is a digit
                if (char.IsDigit(digit))
                {
                    //convert to int
                    int number = digit - '0';
                    //check if number is a double digit
                    if(doubleDigit)
                    {
                        number *= 2;
                        if (number > 9)
                        {
                            number -= 9;
                        }
                    }
                    sum += number;
                    doubleDigit = !doubleDigit;
                }
                else if (digit != ' ')
                {
                    throw new ArgumentException("Invalid Entry.");
                }

            }
            return (sum % 10 == 0);
        }
    }
}
