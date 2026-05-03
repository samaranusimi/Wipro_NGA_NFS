using System;

namespace OrderApp
{
    public delegate void OrderPlacedHandler(Order ord);

    public class OrderProcessor
    {
        public event OrderPlacedHandler OnOrderPlaced;

        public void PlaceOrder(Order ord)
        {
            Console.WriteLine("Order Placed: " + ord.OrderId);

            OnOrderPlaced?.Invoke(ord);
        }
    }
}