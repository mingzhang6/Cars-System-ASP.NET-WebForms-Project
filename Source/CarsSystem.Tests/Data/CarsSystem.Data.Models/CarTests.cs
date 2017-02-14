using System;
using NUnit.Framework;
using CarsSystem.Data.Models;

namespace CarsSystem.Tests.Data.CarsSystem.Data.Models
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        public void Car_ShouldCreateInstanceOfClassCorrectly()
        {
            var car = new Car();

            Assert.IsInstanceOf<Car>(car);
        }

        [Test]
        public void Car_ShouldCreateNullManufacturerField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.IsNull(car.Manufacturer);
        }

        [Test]
        public void Car_ShouldCreateNullModelField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.IsNull(car.Model);
        }

        [Test]
        public void Car_ShouldCreateGasolineTypeOfEngineField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.AreEqual(car.TypeOfEngine, EngineType.Gasoline);
        }

        [Test]
        public void Car_ShouldCreateNullRegistrationNumberField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.IsNull(car.RegistrationNumber);
        }

        [Test]
        public void Car_ShouldCreateNullVINNumberField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.IsNull(car.VINNumber);
        }

        [Test]
        public void Car_ShouldCreateZeroCountOfTyresField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.Zero(car.CountOfTyres);
        }

        [Test]
        public void Car_ShouldCreateZeroCountOfDoorsField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.Zero(car.CountOfDoors);
        }

        [Test]
        public void Car_ShouldCreateOrdinaryTypeOfCarField_WhenInstantiedNewCar()
        {
            var car = new Car();

            Assert.AreEqual(car.TypeOfCar, CarType.Ordinary);
        }

        [Test]
        public void Car_ShouldCreateExpectedYearOfManufacturingField_WhenInstantiedNewCar()
        {
            var car = new Car();

            var actualYearOfManufactoring = car.YearOfManufacturing.ToString();
            var expectedYearOfMAnufactoring = "1.1.0001 г. 0:00:00";

            Assert.AreEqual(expectedYearOfMAnufactoring, expectedYearOfMAnufactoring);
        }

        [Test]
        public void Car_ShouldCreateExpectedValidUntilAnnualCheckUpField_WhenInstantiedNewCar()
        {
            var car = new Car();

            var actualValidUntilAnnualCheckUp = car.ValidUntilAnnualCheckUp.ToString();
            var expectedValidUntilAnnualCheckUp = "1.1.0001 г. 0:00:00";

            Assert.AreEqual(expectedValidUntilAnnualCheckUp, actualValidUntilAnnualCheckUp);
        }

        [Test]
        public void Car_ShouldCreateExpectedValidUntilVignetteField_WhenInstantiedNewCar()
        {
            var car = new Car();

            var actualValidUntilVignette = car.ValidUntilVignette.ToString();
            var expectedValidUntilVignette = "1.1.0001 г. 0:00:00";

            Assert.AreEqual(expectedValidUntilVignette, actualValidUntilVignette);
        }

        [Test]
        public void Car_ShouldCreateExpectedValidUntilInsuranceField_WhenInstantiedNewCar()
        {
            var car = new Car();

            var actualValidUntilInsurance = car.ValidUntilInsurance.ToString();
            var expectedValidUntilInsurance = "1.1.0001 г. 0:00:00";

            Assert.AreEqual(expectedValidUntilInsurance, actualValidUntilInsurance);
        }
    }
}
