using System;
using OrderApp;

namespace OrderApp.Services
{
    public class LoggerService
    {
        public void LogOrder(Order ord)
        {
            Console.WriteLine("Order logged successfully");
        }
    }
}