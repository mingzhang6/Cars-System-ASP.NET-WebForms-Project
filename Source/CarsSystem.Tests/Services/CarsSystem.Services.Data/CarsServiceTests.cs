using System;
using NUnit.Framework;
using Moq;
using CarsSystem.Data.Repositories;
using CarsSystem.Data;
using CarsSystem.Data.Models;
using CarsSystem.Services.Data;
using CarsSystem.Services.Data.Contracts;

namespace CarsSystem.Tests.Services.CarsSystem.Services.Data
{
    [TestFixture]
    public class CarsServiceTests
    {
        [Test]
        public void CarsService_ShouldThrowArgumentNullException_WhenPassedRepositoryIsNull()
        {
            //var data = new Mock<ICarsSystemDbContext>();
            //var mockedRepository = new Mock<IRepository<Car>>();
            IRepository<Car> mockedRepository = null;

            Assert.Throws<ArgumentException>(() => new CarsService(mockedRepository));
        }

        [Test]
        public void CarsService_ShouldThrowArgumentNullExceptionWithExpectedMessage_WhenPassedRepositoryIsNull()
        {
            IRepository<Car> mockedRepository = null;

            var expectedMessage = Assert.Throws<ArgumentException>(() => new CarsService(mockedRepository));

            Assert.IsTrue(expectedMessage.Message.Contains("null"));
        }

        [Test]
        public void CarsService_ShouldCreateInstanceOfCarsService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<Car>>();

            var service = new CarsService(mockedRepository.Object);

            Assert.IsInstanceOf<CarsService>(service);
        }

        [Test]
        public void CarsService_ShouldImplementsInterfaceICarsService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<Car>>();

            var service = new CarsService(mockedRepository.Object);

            Assert.IsInstanceOf<ICarsService>(service);
        }
    }
}
