using System;
using SolidPrinciples.Interfaces;
using SolidPrinciples.Models;
using SolidPrinciples.Services;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {

            IReportGenerator generator = new ReportGenerator();

            IReportSaver saver = new ReportSaver();

            IFormatter formatter = new PdfFormatter();

            ReportService reportService = new ReportService(generator, saver, formatter);

            reportService.ProcessReport();


            Report salesReport = new SalesReport();
            Report inventoryReport = new InventoryReport();

            Console.WriteLine(salesReport.GetReportDetails());
            Console.WriteLine(inventoryReport.GetReportDetails());

            Console.ReadLine();
        }
    }
}