using System;
using NUnit.Framework;
using Moq;
using CarsSystem.Data.Repositories;
using CarsSystem.Data;
using CarsSystem.Data.Models;
using CarsSystem.Services.Data;
using CarsSystem.Services.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CarsSystem.Tests.Services.CarsSystem.Services.Data
{
    [TestFixture]
    public class CarsServiceTests
    {
        [Test]
        public void CarsService_ShouldThrowArgumentNullException_WhenPassedRepositoryIsNull()
        {
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

        [Test]
        public void CarsService_VerifyThehMethodGetAllCars_IsCalled_WhenPassedParametersAreCorrect()
        {
            var listOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf",  },
                new Car() { Id=2, Manufacturer="BMW", Model="e40",  },
                new Car() { Id=3, Manufacturer="Lada", Model="2105",  }
            };
            var mockedService = new Mock<ICarsService>();
            mockedService.Setup(c => c.GetAllCars()).Returns(listOfCars);

            var result = mockedService.Object.GetAllCars();

            mockedService.Verify(s => s.GetAllCars(), Times.Exactly(1));
        }

        [Test]
        public void CarsService_VerifyThehMethodGetCarById_IsCalled_WhenPassedParametersAreCorrect()
        {
            var car = new Car() { Id = 1, Manufacturer = "VW", Model = "Golf", };
            var mockedService = new Mock<ICarsService>();
            mockedService.Setup(c => c.GetCarById(2)).Returns(car);

            var result = mockedService.Object.GetCarById(2);

            mockedService.Verify(s => s.GetCarById(2), Times.Exactly(1));
        }

        [Test]
        public void CarsService_VerifyThehMethodAddCar_IsCalled_WhenPassedParametersAreCorrect()
        {
            var car = new Car() { Id = 1, Manufacturer = "VW", Model = "Golf", };
            var mockedService = new Mock<ICarsService>();
            mockedService.Setup(c => c.AddCar(car)).Verifiable();

            mockedService.Object.AddCar(car);

            mockedService.Verify(s => s.AddCar(car), Times.Exactly(1));
        }

        [Test]
        public void CarsService_GetAllCarsWorksProperly_WhenPassedParametersAreCorrect()
        {
            var listOfCars = new List<Car>
            {
                new Car() { Id=1, Manufacturer="VW", Model="Golf",  },
                new Car() { Id=2, Manufacturer="BMW", Model="e40",  },
                new Car() { Id=3, Manufacturer="Lada", Model="2105",  }
            };
            var mockedService = new Mock<ICarsService>();
            mockedService.Setup(c => c.GetAllCars()).Returns(listOfCars);

            var result = mockedService.Object.GetAllCars().ToList();

            Assert.AreEqual(listOfCars.Count, result.Count);
        }

        [Test]
        public void CarsService_GetCarByIdWorksProperly_WhenPassedParametersAreCorrect()
        {
            var car = new Car() { Id = 1, Manufacturer = "VW", Model = "Golf", };
            var mockedService = new Mock<ICarsService>();
            mockedService.Setup(c => c.GetCarById(2)).Returns(car);

            var result = mockedService.Object.GetCarById(2);

            Assert.AreEqual(car.Manufacturer, result.Manufacturer);
        }
    }
}
