using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> taskQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();
        List<string> allTasks = new List<string>();
        SortedDictionary<int, string> priorityTasks = new SortedDictionary<int, string>();
        HashSet<string> uniqueTasks = new HashSet<string>();

        string task1 = "Attend Class";
        string task2 = "Complete Homework";
        string task3 = "Play Sports";

        if (uniqueTasks.Add(task1))
        {
            taskQueue.Enqueue(task1);
            allTasks.Add(task1);
            priorityTasks.Add(2, task1);
        }

        if (uniqueTasks.Add(task2))
        {
            taskQueue.Enqueue(task2);
            allTasks.Add(task2);
            priorityTasks.Add(1, task2);
        }

        if (uniqueTasks.Add(task3))
        {
            taskQueue.Enqueue(task3);
            allTasks.Add(task3);
            priorityTasks.Add(3, task3);
        }

        Console.WriteLine("Executing Tasks:");
        while (taskQueue.Count > 0)
        {
            string task = taskQueue.Dequeue();
            Console.WriteLine(task);
            undoStack.Push(task);
        }

        Console.WriteLine("\nUndo Last Task:");
        if (undoStack.Count > 0)
        {
            Console.WriteLine(undoStack.Pop());
        }

        Console.WriteLine("\nPriority Tasks:");
        foreach (var item in priorityTasks)
        {
            Console.WriteLine("Priority " + item.Key + ": " + item.Value);
        }

        Console.WriteLine("\nAll Tasks:");
        foreach (string task in allTasks)
        {
            Console.WriteLine(task);
        }
    }
}