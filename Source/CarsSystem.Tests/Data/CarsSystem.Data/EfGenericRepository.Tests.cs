using System;
using NUnit.Framework;
using CarsSystem.Data;
using CarsSystem.Data.Repositories;
using CarsSystem.Data.Models;
using Moq;

namespace CarsSystem.Tests.Data.CarsSystem.Data
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void EfGenericRepository_ShouldThrowArgumentNullException_WhenThePassedContextIsNull()
        {
            ICarsSystemDbContext context = null;

            Assert.Throws<ArgumentException>(() => new EfGenericRepository<Car>(context));
        }

        [Test]
        public void EfGenericRepository_ShouldCreateCarRepository_WhenThePassedParametersAreValid()
        {
            var context = new Mock<ICarsSystemDbContext>();

            var repository = new EfGenericRepository<Car>(context.Object);

            Assert.IsInstanceOf<EfGenericRepository<Car>>(repository);
        }

        [Test]
        public void EfGenericRepository_ShouldCreateUserRepository_WhenThePassedParametersAreValid()
        {
            var context = new Mock<ICarsSystemDbContext>();

            var repository = new EfGenericRepository<User>(context.Object);

            Assert.IsInstanceOf<EfGenericRepository<User>>(repository);
        }

        [Test]
        public void EfGenericRepository_ShouldCreateCarIRepository_WhenThePassedParametersAreValid()
        {
            var context = new Mock<ICarsSystemDbContext>();

            var repository = new EfGenericRepository<Car>(context.Object);

            Assert.IsInstanceOf<IRepository<Car>>(repository);
        }

        [Test]
        public void EfGenericRepository_ShouldCreateUserIRepository_WhenThePassedParametersAreValid()
        {
            var context = new Mock<ICarsSystemDbContext>();

            var repository = new EfGenericRepository<User>(context.Object);

            Assert.IsInstanceOf<IRepository<User>>(repository);
        }
    }
}
