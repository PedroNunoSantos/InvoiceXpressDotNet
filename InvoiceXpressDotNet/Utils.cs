using System.Linq;
using System.Xml.Linq;

namespace InvoiceXpressDotNet
{
    public static class Utils
    {
        public static string CleanXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            doc.Descendants()
                .Where(e => e.IsEmpty || string.IsNullOrWhiteSpace(e.Value))
                .Remove();
            return doc.ToString();
        }
    }
}