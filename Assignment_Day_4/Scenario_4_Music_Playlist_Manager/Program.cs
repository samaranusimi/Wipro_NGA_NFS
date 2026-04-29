using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> playlist = new LinkedList<string>();
        playlist.AddLast("Tum Hi Ho");
        playlist.AddLast("Jeene Laga Hoon");
        playlist.AddLast("Tera Ban Jaunga");

        SortedList<int, string> ratings = new SortedList<int, string>();
        ratings.Add(5, "Tum Hi Ho");
        ratings.Add(4, "Jeene Laga Hoon");
        ratings.Add(3, "Tera Ban Jaunga");

        SortedDictionary<string, string> artists = new SortedDictionary<string, string>();
        artists.Add("Arijit Singh", "Tum Hi Ho");
        artists.Add("Atif Aslam", "Jeene Laga Hoon");
        artists.Add("Akhil Sachdeva", "Tera Ban Jaunga");

        Console.WriteLine("Playlist:");
        foreach (string song in playlist)
        {
            Console.WriteLine(song);
        }

        playlist.Remove("Jeene Laga Hoon");

        Console.WriteLine("\nAfter removing a song:");
        foreach (string song in playlist)
        {
            Console.WriteLine(song);
        }

        Console.WriteLine("\nSorted by Rating:");
        foreach (var item in ratings)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.WriteLine("\nSorted by Artist:");
        foreach (var item in artists)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}