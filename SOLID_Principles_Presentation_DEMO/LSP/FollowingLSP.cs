using System;

namespace SolidDemo.LSP.Good{
class BankAccount
{
    public virtual void Deposit(double amount)
    {
        Console.WriteLine("Deposited: " + amount);
    }
}

class SavingsAccount : BankAccount
{
    public void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawn from Savings: " + amount);
    }
}

class FixedDepositAccount : BankAccount
{
    // public void GetMaturityAmount()
    // {
    //     Console.WriteLine("Amount available after maturity");
    // }
}

class GoodLSP
{
    public static void Run()
    {
        Console.WriteLine("Savings Account");
        SavingsAccount sa = new SavingsAccount();
        sa.Deposit(1000);
        sa.Withdraw(500);

        Console.WriteLine("\nFixed Deposit Account");
        FixedDepositAccount fd = new FixedDepositAccount();
        fd.Deposit(2000);
        //fd.GetMaturityAmount();
    }
}
}