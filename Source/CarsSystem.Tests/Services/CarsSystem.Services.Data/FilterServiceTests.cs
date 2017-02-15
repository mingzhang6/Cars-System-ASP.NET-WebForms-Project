using System;
using NUnit.Framework;
using CarsSystem.Data.Models;
using CarsSystem.Services.Data;
using CarsSystem.Services.Data.Contracts;
using CarsSystem.Data.Repositories;
using Moq;

namespace CarsSystem.Tests.Services.CarsSystem.Services.Data
{
    [TestFixture]
    public class FilterServiceTests
    {
        [Test]
        public void FilterService_ShouldThrowArgumentNullException_WhenPassedRepositoryIsNull()
        {
            IRepository<Car> mockedRepository = null;

            Assert.Throws<ArgumentException>(() => new FilterService(mockedRepository));
        }

        [Test]
        public void FilterService_ShouldThrowArgumentNullExceptionWithExpectedMessage_WhenPassedRepositoryIsNull()
        {
            IRepository<Car> mockedRepository = null;

            var expectedMessage = Assert.Throws<ArgumentException>(() => new FilterService(mockedRepository));

            Assert.IsTrue(expectedMessage.Message.Contains("null"));
        }

        [Test]
        public void FilterService_ShouldCreateInstanceOfFilterService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<Car>>();

            var service = new FilterService(mockedRepository.Object);

            Assert.IsInstanceOf<FilterService>(service);
        }

        [Test]
        public void FilterService_ShouldImplementsInterfaceIFilterService_WhenPassedRepositoryIsCorrectly()
        {
            var mockedRepository = new Mock<IRepository<Car>>();

            var service = new FilterService(mockedRepository.Object);

            Assert.IsInstanceOf<IFilterService>(service);
        }
    }
}
