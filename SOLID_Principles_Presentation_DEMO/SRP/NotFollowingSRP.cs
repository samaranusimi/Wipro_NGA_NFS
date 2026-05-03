using System;

namespace SolidDemo.SRP.Bad
{
    class Report
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Report");
        }

        public void SaveToFile()
        {
            Console.WriteLine("Saving Report");
        }
    }
    public class BadSRP
    {
        public static void Run()
        {
            Console.WriteLine("Bad SRP:");
            Report r = new Report();
            r.GenerateReport();
            r.SaveToFile();
        }
    }

}