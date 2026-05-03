using System;

namespace SolidDemo.SRP.Good
{
    class Report
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Report");
        }
    }

    class ReportSaver
    {
        public void SaveToFile()
        {
            Console.WriteLine("Saving Report");
        }
    }
    public class GoodSRP
    {
        public static void Run()
        {
            Console.WriteLine("Good SRP:");
            Report r = new Report();
            r.GenerateReport();

            ReportSaver saver = new ReportSaver();
            saver.SaveToFile();
        }
    }


}