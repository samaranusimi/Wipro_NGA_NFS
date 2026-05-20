using System.IO;
using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Services
{
    public class ReportSaver : IReportSaver
    {
        public void SaveReport(string content)
        {
            File.WriteAllText("report.txt", content);
        }
    }
}