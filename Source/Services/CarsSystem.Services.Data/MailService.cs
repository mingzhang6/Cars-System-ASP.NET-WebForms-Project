using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Services.Data
{
    public class MailService : IMailService
    {
        public void SendEmail(string subject, string content, IEnumerable<string> emails)
        {
            foreach (var email in emails)
            {
                var mail = new MailMessage();
                var SmtpServer = new SmtpClient();
                SmtpServer.Credentials = new NetworkCredential("mastikurka@gmail.com", "asenmastikata93");
                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";

                SmtpServer.EnableSsl = true;
                SmtpServer.EnableSsl = true;
                mail.To.Add(email);
                mail.From = new MailAddress("mastikurka@gmail.com");
                mail.Subject = subject;
                mail.Body = content;
                SmtpServer.Send(mail);
            }
        }
    }
}
