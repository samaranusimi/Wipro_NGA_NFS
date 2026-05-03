using System;

namespace SolidDemo.OCP.Good
{
    interface INotification
    {
        void Send();
    }

    class Email : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Email");
        }
    }

    class SMS : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS");
        }
    }

    class TelegramSMS : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Telegram SMS");
        }
    }

    public class GoodOCP
    {
        public static void Run()
        {
            Console.WriteLine("Good OCP:");
            INotification email = new Email();
            email.Send();

            INotification sms = new SMS();
            sms.Send();

            INotification telegram = new TelegramSMS();
            telegram.Send();
        }
    }
}