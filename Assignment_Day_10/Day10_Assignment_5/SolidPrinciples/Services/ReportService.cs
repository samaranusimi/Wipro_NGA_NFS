using System;
using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Services
{
    public class ReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportSaver _saver;
        private readonly IFormatter _formatter;

        public ReportService(
            IReportGenerator generator,
            IReportSaver saver,
            IFormatter formatter)
        {
            _generator = generator;
            _saver = saver;
            _formatter = formatter;
        }

        public void ProcessReport()
        {
            string report = _generator.GenerateReport();

            string formattedReport = _formatter.Format(report);

            _saver.SaveReport(formattedReport);

            Console.WriteLine("Report processed successfully.");
        }
    }
}