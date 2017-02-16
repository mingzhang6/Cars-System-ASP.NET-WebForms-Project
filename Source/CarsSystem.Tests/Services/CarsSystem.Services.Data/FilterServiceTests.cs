using System;
using NUnit.Framework;
using CarsSystem.Data.Models;
using CarsSystem.Services.Data;
using CarsSystem.Services.Data.Contracts;
using CarsSystem.Data.Repositories;
using Moq;
using System.Collections.Generic;
using System.Linq;

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

        [Test]
        public void FilterService_FilterExpiringVignetteCars_ShouldReturnIEnumerableCollection_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilVignette=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilVignette=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilVignette=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringVignetteCars()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringVignetteCars().ToList();

            Assert.AreEqual(collectionOfCars.Count, result.Count);
        }

        [Test]
        public void FilterService_FilterExpiringVignetteCars_VerifyThatTheMethodIsCalledExactOneTime_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilVignette=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilVignette=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilVignette=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringVignetteCars()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringVignetteCars();

            mockedService.Verify(s => s.FilterExpiringVignetteCars(), Times.Exactly(1));
        }

        [Test]
        public void FilterService_FilterExpiringInsurance_ShouldReturnIEnumerableCollection_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilInsurance=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilInsurance=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilInsurance=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringInsurance()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringInsurance().ToList();

            Assert.AreEqual(collectionOfCars.Count, result.Count);
        }

        [Test]
        public void FilterService_FilterExpiringInsurance_VerifyThatTheMethodIsCalledExactOneTime_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilInsurance=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilInsurance=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilInsurance=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringInsurance()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringInsurance();

            mockedService.Verify(s => s.FilterExpiringInsurance(), Times.Exactly(1));
        }

        [Test]
        public void FilterService_FilterExpiringAnnualCheckUp_ShouldReturnIEnumerableCollection_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilAnnualCheckUp=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilAnnualCheckUp=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilAnnualCheckUp=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringAnnualCheckUp()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringAnnualCheckUp().ToList();

            Assert.AreEqual(collectionOfCars.Count, result.Count);
        }

        [Test]
        public void FilterService_FilterExpiringAnnualCheckUp_VerifyThatTheMethodIsCalledExactOneTime_WhenPassedParametersAreCorrect()
        {
            var collectionOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf", ValidUntilAnnualCheckUp=DateTime.Now },
                new Car() { Id=2, Manufacturer="BMW", Model="e40", ValidUntilAnnualCheckUp=DateTime.Now },
                new Car() { Id=3, Manufacturer="Lada", Model="2105", ValidUntilAnnualCheckUp=DateTime.Now }
            };

            var mockedService = new Mock<IFilterService>();
            mockedService.Setup(s => s.FilterExpiringAnnualCheckUp()).Returns(collectionOfCars);

            var result = mockedService.Object.FilterExpiringAnnualCheckUp();

            mockedService.Verify(s => s.FilterExpiringAnnualCheckUp(), Times.Exactly(1));
        }
    }
}
