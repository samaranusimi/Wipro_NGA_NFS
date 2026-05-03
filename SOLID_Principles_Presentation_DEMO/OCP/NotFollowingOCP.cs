using System;

namespace SolidDemo.OCP.Bad
{
    class Notification
    {
        public void Send(string type)
        {
            if (type == "Email")
                Console.WriteLine("Sending Email");
            else if (type == "SMS")
                Console.WriteLine("Sending SMS");
        }
    }

    public class BadOCP
    {
        public static void Run()
        {
            Console.WriteLine("Bad OCP:");
            Notification n = new Notification();
            n.Send("Email");
            n.Send("SMS");
        }
    }
}