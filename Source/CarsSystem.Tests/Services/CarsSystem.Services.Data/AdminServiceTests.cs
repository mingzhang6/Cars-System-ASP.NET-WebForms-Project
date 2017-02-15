using System;
using NUnit.Framework;
using CarsSystem.Data.Repositories;
using CarsSystem.Data.Models;
using CarsSystem.Services.Data;
using Moq;

namespace CarsSystem.Tests.Services.CarsSystem.Services.Data
{
    [TestFixture]
    public class AdminServiceTests
    {
        [Test]
        public void AdminService_ShouldThrowArgumentNullException_WhenPassedRepositoryUserIsNull()
        {
            IRepository<User> mockedRepositoryUser = null;
            var mockedRepositoryCar = new Mock<IRepository<Car>>();

            Assert.Throws<ArgumentException>(() => new AdminService(mockedRepositoryUser, mockedRepositoryCar.Object));
        }

        [Test]
        public void AdminService_ShouldThrowArgumentNullException_WhenPassedRepositoryCarIsNull()
        {
            IRepository<Car> mockedRepositoryCar = null;
            var mockedRepositoryUser = new Mock<IRepository<User>>();

            Assert.Throws<ArgumentException>(() => new AdminService(mockedRepositoryUser.Object, mockedRepositoryCar));
        }

        [Test]
        public void AdminService_ShouldThrowArgumentNullExceptionWithExpectedMessage_WhenPassedRepositoryUserIsNull()
        {
            IRepository<User> mockedRepositoryUser = null;
            var mockedRepositoryCar = new Mock<IRepository<Car>>();

            var expectedMessage = Assert.Throws<ArgumentException>(() => new AdminService(mockedRepositoryUser, mockedRepositoryCar.Object));

            Assert.IsTrue(expectedMessage.Message.Contains("null"));
        }

        [Test]
        public void AdminService_ShouldThrowArgumentNullExceptionWithExpectedMessage_WhenPassedRepositoryCarIsNull()
        {
            IRepository<Car> mockedRepositoryCar = null;
            var mockedRepositoryUser = new Mock<IRepository<User>>();

            var expectedMessage = Assert.Throws<ArgumentException>(() => new AdminService(mockedRepositoryUser.Object, mockedRepositoryCar));

            Assert.IsTrue(expectedMessage.Message.Contains("null"));
        }

        [Test]
        public void AdminService_ShouldCreateInstanceOfAdminService_WhenPassedRepositoriesAreCorrectly()
        {
            var mockedRepositoryUser = new Mock<IRepository<User>>();
            var mockedRepositoryCar = new Mock<IRepository<Car>>();

            var service = new AdminService(mockedRepositoryUser.Object, mockedRepositoryCar.Object);

            Assert.IsInstanceOf<AdminService>(service);
        }
    }
}
