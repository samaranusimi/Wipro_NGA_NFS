using System;
using SolidDemo.SRP.Bad;
using SolidDemo.SRP.Good;
using SolidDemo.OCP.Bad;
using SolidDemo.OCP.Good;
using SolidDemo.LSP.Bad;
using SolidDemo.LSP.Good;


class Program
{
    static void Main()
    {
        // Console.WriteLine("SRP");
        // BadSRP.Run();
        // GoodSRP.Run();

        // Console.WriteLine("OCP");
        // BadOCP.Run();
        // GoodOCP.Run();


        Console.WriteLine("LSP");
        BadLSP.Run();
        GoodLSP.Run();

       
    }
}