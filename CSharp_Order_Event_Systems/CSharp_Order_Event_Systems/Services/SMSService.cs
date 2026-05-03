using System;
using OrderApp;

namespace OrderApp.Services
{
    public class SMSService
    {
        public void SendSMS(Order ord)
        {
            Console.WriteLine("SMS sent to " + ord.CustomerName);
        }
    }
}