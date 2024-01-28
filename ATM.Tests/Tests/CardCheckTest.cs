using ATM.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM.Tests.Tests
{
    public class CardCheckTest
    {
        [Theory]
        [InlineData("4111111111111111", true)]

        public void IsCard(string cardNumber, bool expected)
        {
            //ARRANGE not necessary with static
            //ACT
            bool actual = CardCheck.IsCard(cardNumber);
            //ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
