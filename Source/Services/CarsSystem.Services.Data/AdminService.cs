using CarsSystem.Data.Models;
using CarsSystem.Data.Repositories;
using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Services.Data
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<User> userRepo;
        private readonly IRepository<Car> carRepo;

        public AdminService(IRepository<User> userRepo, IRepository<Car> carRepo)
        {
            if (userRepo == null)
            {
                throw new ArgumentException("The user repo should not be null!");
            }

            if (carRepo == null)
            {
                throw new ArgumentException("The car repo should not be null!");
            }

            this.userRepo = userRepo;
            this.carRepo = carRepo;
        }

        public void AddCar(string manufacturer, string model, EngineType typeOfEngine, string registrationNumber,
            string vinNumber, byte countOfTyres, byte countOfDoors, CarType typeOfCar, DateTime yearOfManufacturing,
            DateTime validUntilAnnualCheckUp, DateTime validUntilVignette, DateTime ValidUntilInsurance, string userId)
        {
            //ToDo...How to get id of user.User.identity.GetUserId()?

            var carToAdd = new Car
            {
                Manufacturer = manufacturer,
                Model = model,
                TypeOfEngine = typeOfEngine,
                RegistrationNumber = registrationNumber,
                VINNumber = vinNumber,
                CountOfTyres = countOfTyres,
                CountOfDoors = countOfDoors,
                TypeOfCar = typeOfCar,
                YearOfManufacturing = yearOfManufacturing,
                ValidUntilAnnualCheckUp = validUntilAnnualCheckUp,
                ValidUntilVignette = validUntilVignette,
                ValidUntilInsurance = ValidUntilInsurance,
                UserId = userId
            };

            this.carRepo.Add(carToAdd);
            this.carRepo.SaveChanges();
        }

        public void AddUser(string firstName, string secondName, string lastName, long egn, int numbeOfIdCard,
            DateTime dateOfIssue, string city, string phoneNumber, string email)
        {
            var userToAdd = new User
            {
                FirstName = firstName,
                SecondName = secondName,
                LastName = lastName,
                EGN = egn,
                NumberOfIdCard = numbeOfIdCard,
                DateOfIssue = dateOfIssue,
                City = city,
                PhoneNumber = phoneNumber
            };

            this.userRepo.Add(userToAdd);
            this.userRepo.SaveChanges();

            //var re = this.userRepo.All().Where(c => c.NumberOfIdCard == userToAdd.NumberOfIdCard);
            //return userToAdd.Id;
        }
    }
}
