using CarsSystem.Data.Models;
using System.Collections.Generic;

namespace CarsSystem.Services.Data.Contracts
{
    public interface IUsersService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(string id);
        string GetUserId(Car car);
    }
}
