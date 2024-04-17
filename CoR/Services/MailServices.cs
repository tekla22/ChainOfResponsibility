using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.Services
{
    internal class MailServices
    {
        public void SendEmail(string email, string body)
        {
            Console.WriteLine("Email with request {0} was sent to {1}", body, email);
        }
    }
}
