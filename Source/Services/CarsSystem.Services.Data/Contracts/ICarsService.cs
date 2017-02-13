using CarsSystem.Data.Models;
using System.Collections.Generic;

namespace CarsSystem.Services.Data.Contracts
{
    public interface ICarsService
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
    }
}