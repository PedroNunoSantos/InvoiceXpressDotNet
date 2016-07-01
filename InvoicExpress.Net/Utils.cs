using System;
using System.Linq;
using System.Xml.Linq;

namespace InvoicExpress.Net
{
    public class Utils
    {
        public static string CleanXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            doc.Descendants()
                .Where(e => e.IsEmpty || String.IsNullOrWhiteSpace(e.Value))
                .Remove();
            return doc.ToString();
        }
    }
}