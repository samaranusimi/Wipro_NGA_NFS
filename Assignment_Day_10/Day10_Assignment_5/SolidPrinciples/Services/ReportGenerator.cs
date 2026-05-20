using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Services
{
    public class ReportGenerator : IReportGenerator
    {
        public string GenerateReport()
        {
            return "Generated Report Content";
        }
    }
}
