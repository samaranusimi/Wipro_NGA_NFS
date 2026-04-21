using System;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Input");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x/y;
            Console.WriteLine(z);
        }catch(DivideByZeroException)
        {
            Console.WriteLine("Denominator can't be Zero");
        }catch(FormatException)
        {
            Console.WriteLine("Input format should be numeric");
        }
    }
}