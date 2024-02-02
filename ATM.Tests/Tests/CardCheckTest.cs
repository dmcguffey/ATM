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
        [Fact]
        public void IsCard()
        {
            //ARRANGE
            CardCheckTest cardCheck = new CardCheckTest();
            string cardNumber = "4111111111111111";
            //ACT
            bool actual = CardCheck.IsCard(cardNumber);
            //ASSERT
            Assert.True(actual);
        }
        [Fact]
        public void IsNotCard()
        {
            //ARRANGE
            CardCheckTest cardCheck = new CardCheckTest();
            string cardNumber = "4111111111111112";
            //ACT
            bool actual = CardCheck.IsCard(cardNumber);
            //Assert
            Assert.False(actual);
        }
    }
}
