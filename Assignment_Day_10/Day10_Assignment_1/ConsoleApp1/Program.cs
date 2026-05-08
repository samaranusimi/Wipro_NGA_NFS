using System;

namespace CalculatorLibary
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Value of y can't be 0");
            }
            else
            {
                return x / y;
            }

        }

        public static void Main()
        {
            Console.WriteLine("Calculator App");
        }

    }
}