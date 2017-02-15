using System;
using NUnit.Framework;
using CarsSystem.Data;
using Microsoft.AspNet.Identity;

namespace CarsSystem.Tests.Data.CarsSystem.Data
{
    [TestFixture]
    public class CarsSystemDbContextTests
    {
        [Test]
        public void CarsSystemDbContext_ShouldCreateInstanceOfDatabase()
        {
            var db = new CarsSystemDbContext();

            Assert.IsInstanceOf<CarsSystemDbContext>(db);
        }

        [Test]
        public void CarsSystemDbContext_ShouldBeTypeOfICarsDbContext()
        {
            var db = new CarsSystemDbContext();

            Assert.IsInstanceOf<ICarsSystemDbContext>(db);
        }

        [Test]
        public void CarsSystemDbContext_CreateMethodShouldReturnInstanceOfCarsDbContext()
        {
            var db = CarsSystemDbContext.Create();

            Assert.IsInstanceOf<CarsSystemDbContext>(db);
        }

        [Test]
        public void CarsSystemDbContext_CreateMethodShouldReturnInstanceOfICarsDbContext()
        {
            var db = CarsSystemDbContext.Create();

            Assert.IsInstanceOf<ICarsSystemDbContext>(db);
        }
    }
}
