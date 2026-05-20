using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Services
{
    public class ExcelFormatter : IFormatter
    {
        public string Format(string content)
        {
            return "[EXCEL FORMAT] " + content;
        }
    }
}