using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Services
{
    public class PdfFormatter : IFormatter
    {
        public string Format(string content)
        {
            return "[PDF FORMAT] " + content;
        }
    }
}