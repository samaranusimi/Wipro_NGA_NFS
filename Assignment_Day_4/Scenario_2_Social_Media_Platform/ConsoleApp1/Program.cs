using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> post = new List<string>();
        Dictionary <string, int> likes = new Dictionary <string, int>();
        HashSet <int> user = new HashSet <int>();
        Stack<string> actions = new Stack<string>();
        Queue<string> notification = new Queue<string>();


        user.Add(1);
        user.Add(2);
        user.Add(3);
        user.Add(4);
        user.Add(2);
        user.Add(1);
        Console.WriteLine("Users Count: "+user.Count);

        post.Add("First Post");
        likes["First Post"] = 0;
        actions.Push("Post Added");
        notification.Enqueue("New post added");

    }
}
