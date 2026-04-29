using System;
using System.Collections.Generic;

class Order
{
    public int OrderId;
    public string ProductName;
    public double Price;
}

class Customer
{
    public int CustomerId;
    public string Name;
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        HashSet<string> categories = new HashSet<string>();
        Queue<Order> orderQueue = new Queue<Order>();
        Stack<string> orderStatus = new Stack<string>();

        orders.Add(new Order { OrderId = 1, ProductName = "Book", Price = 500 });
        orders.Add(new Order { OrderId = 2, ProductName = "Headphones", Price = 2000 });
        orders.Add(new Order { OrderId = 3, ProductName = "Watch", Price = 1500 });

        customers.Add(1, new Customer { CustomerId = 1, Name = "Samar" });
        customers.Add(2, new Customer { CustomerId = 2, Name = "Kartik" });

        categories.Add("Education");
        categories.Add("Electronics");
        categories.Add("Accessories");
        categories.Add("Electronics");

        foreach (Order o in orders)
        {
            if (o.OrderId == 2)
            {
                o.Price = 1800;
            }
        }

        orders.RemoveAll(o => o.OrderId == 3);

        foreach (Order o in orders)
        {
            orderQueue.Enqueue(o);
        }
        
        Console.WriteLine("Processing Orders:");
        while (orderQueue.Count > 0)
        {
            Order current = orderQueue.Dequeue();
            Console.WriteLine("Order ID: " + current.OrderId + " - " + current.ProductName);

            orderStatus.Push("Order " + current.OrderId + " processed");
        }

        Console.WriteLine("\nOrder Status History:");
        foreach (string status in orderStatus)
        {
            Console.WriteLine(status);
        }

        Console.WriteLine("\nRemaining Orders:");
        foreach (Order o in orders)
        {
            Console.WriteLine(o.OrderId + " " + o.ProductName + " " + o.Price);
        }

        Console.WriteLine("\nCategories:");
        foreach (string c in categories)
        {
            Console.WriteLine(c);
        }
    }
}