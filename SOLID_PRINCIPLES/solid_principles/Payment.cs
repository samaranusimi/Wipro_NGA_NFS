using System;

public interface IPayment
{
    void Pay(int amount);
}

public class UpiPayment : IPayment
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid using UPI");
    }
}

public class CardPayment : IPayment
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid using Card");
    }
}

public class NetBankingPayment : IPayment
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid using Net Banking");
    }
}