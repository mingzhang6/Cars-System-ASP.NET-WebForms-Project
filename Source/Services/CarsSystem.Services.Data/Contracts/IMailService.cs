using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Services.Data.Contracts
{
    public interface IMailService
    {
        void SendEmail(string subject, string content, IEnumerable<string> emails);
    }
}
