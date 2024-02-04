using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ATM.Business.Services;
using NuGet.Frameworks;

namespace ATM.Tests.Tests
{
    public class AccountServiceTest
    {
        [Theory]
        [InlineData(2.00, 4.00, 6.00)]
        [InlineData(-1.00, 2.00, 1.00)]
        [InlineData(0.00, 0.00, 0.00)]

        public void DepositTest (decimal balance, decimal amount, decimal expected)
        {
            //ARRANGE
            AccountService challenger = new AccountService();
            //ACT
            decimal actual = challenger.Deposit(balance, amount);
            //ASSERT
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.00, 2.00, 0.00)]
        [InlineData(10.00, 20.00, -10.00)]
        [InlineData(0.00, 0.00, 0.00)]
        [InlineData(15.00, 5.00, 10.00)]

        public void WithdrawTest(decimal balance, decimal amount, decimal expected)
        {
            //ARRANGE
            AccountService challenger = new AccountService();
            //ACT
            decimal actual = challenger.Withdraw(balance, amount);
            //ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void FundsTransferred()
        {
            //ARRANGE
            decimal FirstBalance = 2000.00m;
            decimal SecondBalance = 1000.00m;
            decimal TransferAmount = 500.00m;
            AccountService challenger = new AccountService();
            //ACT
            (decimal New_FirstBalance, decimal New_SecondBalance) = challenger.TransferFunds(FirstBalance, SecondBalance, TransferAmount);

            //ASSERT
            Assert.Equal(FirstBalance + TransferAmount, New_FirstBalance);
            Assert.Equal(SecondBalance - TransferAmount, New_SecondBalance);
        }
    }
}
