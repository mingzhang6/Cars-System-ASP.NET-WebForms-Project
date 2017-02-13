using CarsSystem.Data.Models;
using System;

namespace CarsSystem.Services.Data.Contracts
{
    public interface IAdminService
    {
        void AddCar(string manufacturer, string model, EngineType typeOfEngine, string registrationNumber,
            string vinNumber, byte countOfTyres, byte countOfDoors, CarType typeOfCar, DateTime yearOfManufacturing,
            DateTime validUntilAnnualCheckUp, DateTime validUntilVignette, DateTime ValidUntilInsurance, string userId);

        void AddUser(string firstName, string secondName, string lastName, long egn, int numbeOfIdCard,
            DateTime dateOfIssue, string city, string phoneNumber, string email);
    }
}