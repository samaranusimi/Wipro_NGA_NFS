using delegatedemo;

class Program
	{
		public static void Main()
		{
            MathOperation operation = delegateDemo.Add;
            Console.WriteLine("Delegate ref is created and currently it is pointing to Add()");
            int result = operation(10, 5);
            Console.WriteLine("Since Delegate is pointing to Add() so the result of Addition is "+result);

            operation = delegatedemo.Subtract;
            Console.WriteLine("Now the delegate ref is changed and currently it is pointing to Subtract()");
            result = operation(10, 5);
            Console.WriteLine("Since Delegate is pointing to Subtract() so the result of Subtraction is " + result);

		}
	
}

