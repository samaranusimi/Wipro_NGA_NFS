using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message) { }
}

class BankAccount
{
    public string AccountHolderName;
    public double Balance;

    public BankAccount(string name, double balance)
    {
        AccountHolderName = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Deposit must be greater than 0");
        }

        Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Not enough balance");
        }

        if (Balance - amount < 1000)
        {
            throw new InsufficientBalanceException("Minimum balance 1000 required");
        }

        Balance -= amount;
        Console.WriteLine("Withdrawn: " + amount);
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount("Samar", 4000);

        try
        {
            acc.Deposit(1000);
            acc.Withdraw(4500);
            acc.CheckBalance();
        }
        catch (InvalidAmountException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (InsufficientBalanceException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Transaction Completed");
        }
    }
}