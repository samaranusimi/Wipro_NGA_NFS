using System;
using OrderApp;
using OrderApp.Services;

class Program
{
    static void Main()
    {
        OrderProcessor proc = new OrderProcessor();

        EmailService emailSvc = new EmailService();
        SMSService smsSvc = new SMSService();
        LoggerService logSvc = new LoggerService();

        proc.OnOrderPlaced += emailSvc.SendEmail;
        proc.OnOrderPlaced += smsSvc.SendSMS;
        proc.OnOrderPlaced += logSvc.LogOrder;

        Order ord = new Order
        {
            OrderId = 101,
            CustomerName = "Samar",
            Amount = 900
        };

        proc.PlaceOrder(ord);
    }
}