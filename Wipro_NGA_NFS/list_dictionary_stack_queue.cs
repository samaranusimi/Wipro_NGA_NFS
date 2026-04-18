using System;
class program
{
    public static void Main()
    {
        // List<string> names = new List<string>();

        
        // names.Add("Samar");
        // names.Add("Rahul");

       
        // Console.WriteLine("First Name: " + names[0]);

       
        // foreach (string name in names)
        // {
        //     Console.WriteLine(name);
        // }

        

        Stack<string> stack = new Stack<string>();

        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine("Count: " + stack.Count);

        
        
        Console.WriteLine(stack.Pop());
        

        
    }
}
