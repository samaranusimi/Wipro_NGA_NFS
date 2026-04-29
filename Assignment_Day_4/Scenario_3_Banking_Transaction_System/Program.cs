using System;
using System.Collections.Generic;

// Simple Transaction class
class Transaction
{
    public string Id;
    public double Amount;
}

class Program
{
    static void Main()
    {
        // Data structures
        List<Transaction> history = new List<Transaction>();
        Dictionary<string, double> accounts = new Dictionary<string, double>();
        Queue<Transaction> pending = new Queue<Transaction>();
        Stack<Transaction> rollback = new Stack<Transaction>();
        HashSet<string> ids = new HashSet<string>();

        accounts["A1"] = 1000;

        List<Transaction> transactions = new List<Transaction> { 
        new Transaction { Id = "T1", Amount = 500 },
        new Transaction { Id = "T2", Amount = -200 },
        new Transaction { Id = "T1", Amount = 300 }  };

        foreach (Transaction t in transactions)
        {
            if (ids.Add(t.Id))
            {
                pending.Enqueue(t);
            }
            else
            {
                Console.WriteLine("Duplicate: " + t.Id);
            }
        }

        while (pending.Count > 0)
        {
            Transaction t = pending.Dequeue();

            accounts["A1"] += t.Amount;

            history.Add(t);
            rollback.Push(t);

            Console.WriteLine("Processed " + t.Id);
        }

        Console.WriteLine("Balance: " + accounts["A1"]);

        if (rollback.Count > 0)
        {
            Transaction last = rollback.Pop();
            accounts["A1"] -= last.Amount;

            Console.WriteLine("Undo " + last.Id);
        }

        Console.WriteLine("Final Balance: " + accounts["A1"]);
    }
}
