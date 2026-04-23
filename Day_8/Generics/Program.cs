using System;
using GenricsDemo;

namespace genericsDemo
{
    internal class Program
    {
        static void Main()
        {
            GenericsClass<int> obj1 = new GenericsClass<int>();
            obj1.Data = 9876;
            obj1.Display(obj1.Data);
            GenericsClass<string> obj2 = new GenericsClass<string>();
            obj2.Data = "Hello, how are you?";
            obj2.Display(obj2.Data);
        }
    }
}