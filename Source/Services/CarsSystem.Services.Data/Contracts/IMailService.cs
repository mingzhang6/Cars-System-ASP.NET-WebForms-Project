using System.Collections.Generic;

namespace CarsSystem.Services.Data.Contracts
{
    public interface IMailService
    {
        void SendEmail(string subject, string content, IEnumerable<string> emails);
    }
}
