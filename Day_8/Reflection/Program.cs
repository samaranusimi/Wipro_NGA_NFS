using System;
using System.Reflection;

namespace reflection_Demo
{
    internal class Program
    {
        static void Main(string[] args){
            Type type = typeof(Student);
            Console.WriteLine ("Name of the class"+type. Name);

            Console.WriteLine("Properties:"); 
            foreach (var item in type. GetProperties()){
                Console.WriteLine(item. Name);
            }
            Console.WriteLine( "Methods:");
            foreach(var item in type. GetMethods()){ 
                Console.WriteLine(item. Name); 
            }
            Console.WriteLine("Invoke methods dynamically ");
            object obj = Activator.CreateInstance(type);
            MethodInfo methodinfo = type.GetMethod("Display");
            methodinfo.Invoke(obj, null);
        }
    }
}