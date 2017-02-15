using System;
using NUnit.Framework;
using CarsSystem.Data.Models;
using CarsSystem.Data.Repositories;
using CarsSystem.Services.Data;
using Moq;
using CarsSystem.Services.Data.Contracts;

namespace CarsSystem.Tests.Services.CarsSystem.Services.Data
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void UsersService_ShouldThrowArgumentNullException_WhenPassedRepositoryIsNull()
        {
            IRepository<User> mockedRepository = null;

            Assert.Throws<ArgumentException>(() => new UsersService(mockedRepository));
        }

        [Test]
        public void UsersService_ShouldThrowArgumentNullExceptionWithExpectedMessage_WhenPassedRepositoryIsNull()
        {
            IRepository<User> mockedRepository = null;

            var expectedMessage = Assert.Throws<ArgumentException>(() => new UsersService(mockedRepository));

            Assert.IsTrue(expectedMessage.Message.Contains("null"));
        }

        [Test]
        public void UsersService_ShouldCreateInstanceOfUsersService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<User>>();

            var service = new UsersService(mockedRepository.Object);

            Assert.IsInstanceOf<UsersService>(service);
        }

        [Test]
        public void UsersService_ShouldImplementsInterfaceIUsersService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<User>>();

            var service = new UsersService(mockedRepository.Object);

            Assert.IsInstanceOf<IUsersService>(service);
        }
    }
}
