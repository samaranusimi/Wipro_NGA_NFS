using System;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Enter n1:");
			int n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter n2:");
			int n2 = int.Parse(Console.ReadLine());
			int sum = n1+n2;
			Console.WriteLine($"Sum is {sum}.");


			Console.WriteLine($"N1: {n1}");
			Console.WriteLine($"N2: {n2}");

		}
	}
}

/*Create a C# Console application implementing following : - 
Hello World 
Adding two number
Taking input from the user and displaying it back.*/  