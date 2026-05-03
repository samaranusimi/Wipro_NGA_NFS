using System;
using OrderApp;

namespace OrderApp.Services
{
    public class EmailService
    {
        public void SendEmail(Order ord)
        {
            Console.WriteLine("Email sent to " + ord.CustomerName);
        }
    }
}