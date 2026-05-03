using System;

namespace SolidDemo.LSP.Bad
{
    class BankAccount
    {
        public virtual void Withdraw(double amount)
        {
            Console.WriteLine("Withdraw: " + amount);
        }
    }

    class FixedDeposit : BankAccount
    {
        public override void Withdraw(double amount)
        {
            throw new Exception("Withdrawal not allowed");
        }
    }

    public class BadLSP
    {
        public static void Run()
        {
            Console.WriteLine("Bad LSP:");
            try
            {
                BankAccount acc = new FixedDeposit();
                acc.Withdraw(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}