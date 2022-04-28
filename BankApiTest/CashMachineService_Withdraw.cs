using BankApi.Interfaces;
using BankApi.Models;
using BankApi.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BankApiTest
{
    public class CashMachineService_Withdraw
    {
        [Theory]
        [InlineData(10, "efg")]
        public void Withdraw(double value, string agency)
        {
            //Arrange
            List<BankAccount> bankAccounts = new()
            {
                new BankAccount
                {
                    Agency = "abc",
                    Balance = 100,
                    Id = 1,
                    User = new User
                    {
                        Name = "Carlos",
                        Id = 1
                    }
                },
                new BankAccount
                {
                    Agency = "def",
                    Balance = 200,
                    Id = 2,
                    User = new User
                    {
                        Name = "Roberto",
                        Id = 2
                    }
                },
            };

            var bankAccount = bankAccounts.FirstOrDefault(x => x.Agency == agency);
            var backupValue = bankAccount?.Balance;

            var mockRepo = new Mock<ICashMachineRepository>();

            mockRepo.Setup(x => x.GetByAgency(agency)).Returns(bankAccounts.FirstOrDefault(x => x.Agency == agency));

            mockRepo.Setup(mr => mr.Withdraw(It.IsAny<double>(), It.IsAny<BankAccount>()))
                   .Callback((double value, BankAccount bankAccount) => {
                       bankAccount.Balance -= value;
                   }).Verifiable();

            var service = new CashMachineService(mockRepo.Object);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => service.Withdraw(value, agency));
        }
    }
}
