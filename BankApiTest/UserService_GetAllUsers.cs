using BankApi.Interfaces;
using BankApi.Models;
using BankApi.Services;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BankApiTest
{
    public class UserService_GetAllUsers
    {
        [Fact]
        public void GetAllUsersReturnsAListOfUsers()
        {
            //Arrange
            var users = new List<User>()
            {
                new User(){ Name = "Roberto", Id = 1 },
                new User(){ Name = "Carlos", Id = 2 }
            };

            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(x => x.GetAll()).Returns(users);
            var service = new UserService(mockRepo.Object);

            //Act
            var result = service.GetAll();

            //Assert
            mockRepo.Verify(x => x.GetAll(), Times.Once());
            Assert.IsType<List<User>>(result);
        }

        [Fact]
        public void GetAllUsersReturnsNotEmptyWhenRegisterAreFound()
        {
            //Arrange
            var users = new List<User>()
            {
                new User(){ Name = "Roberto", Id = 1 },
                new User(){ Name = "Carlos", Id = 2 }
            };

            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(x => x.GetAll()).Returns(users);
            var service = new UserService(mockRepo.Object);

            //Act
            var result = service.GetAll();

            //Assert
            mockRepo.Verify(x => x.GetAll(), Times.Once());
            Assert.True(result.Count > 0);
        }
    }
}