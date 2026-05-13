using System;

namespace RazorPages
{
    public class Item
    {
        public string? Name { get; set; }
    }

    public static class ItemStore
    {
        public static List<Item> Items = new List<Item>();
    }
}