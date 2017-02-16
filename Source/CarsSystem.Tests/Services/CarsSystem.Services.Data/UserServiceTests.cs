using System;
using NUnit.Framework;
using CarsSystem.Data.Models;
using CarsSystem.Data.Repositories;
using CarsSystem.Services.Data;
using Moq;
using CarsSystem.Services.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

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

        [Test]
        public void UserService_VerifyThehMethodGetAllCars_IsCalled_WhenPassedParametersAreCorrect()
        {
            var listOfUser = new List<User>
            {
                new User() { Id="test", FirstName="Gosho", LastName="Pochivkata" },
                new User() { Id="test1", FirstName="Monti", LastName="Picha" },
                new User() { Id="test2", FirstName="Marin", LastName="The hunter" },

            };
            var mockedService = new Mock<IUsersService>();
            mockedService.Setup(c => c.GetAllUsers()).Returns(listOfUser);

            var result = mockedService.Object.GetAllUsers();

            mockedService.Verify(s => s.GetAllUsers(), Times.Exactly(1));
        }

        [Test]
        public void UserService_VerifyThehMethodGetCarById_IsCalled_WhenPassedParametersAreCorrect()
        {
            var user = new User() { Id = "test", FirstName = "Gosho", LastName = "Pochivkata" };

            var mockedService = new Mock<IUsersService>();
            mockedService.Setup(c => c.GetUserById("test")).Returns(user);

            var result = mockedService.Object.GetUserById("test");

            mockedService.Verify(s => s.GetUserById("test"), Times.Exactly(1));
        }

        [Test]
        public void UserService_GetUserByIdWorksProperly_WhenPassedParametersAreCorrect()
        {
            var user = new User() { Id = "test", FirstName = "Gosho", LastName = "Pochivkata" };

            var mockedService = new Mock<IUsersService>();
            mockedService.Setup(c => c.GetUserById("test")).Returns(user);

            var result = mockedService.Object.GetUserById("test");

            Assert.AreEqual(user.FirstName, result.FirstName);
        }

        [Test]
        public void UserService_GetAllUsersMethodWorksProperly_WhenPassedParametersAreCorrect()
        {
            var listOfUser = new List<User>
            {
                new User() { Id="test", FirstName="Gosho", LastName="Pochivkata" },
                new User() { Id="test1", FirstName="Monti", LastName="Picha" },
                new User() { Id="test2", FirstName="Marin", LastName="The hunter" },

            };
            var mockedService = new Mock<IUsersService>();
            mockedService.Setup(c => c.GetAllUsers()).Returns(listOfUser);

            var result = mockedService.Object.GetAllUsers().ToList();

            Assert.AreEqual(listOfUser.Count, result.Count);
        }
    }
}
