using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet.Extensions
{
    public static class XmlExtensions
    {
        public static string XmlSerializeToString<T>(this T objectInstance) where T : Dto
        {
            var xml = new XmlWriterSettings();
            xml.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(stream, xml))
            {
                var serializer = new XmlSerializer(objectInstance.GetType());
                var ns = new XmlSerializerNamespaces(new[] {XmlQualifiedName.Empty});
                serializer.Serialize(writer, objectInstance, ns);
                string returnXml = stream.ToString().RemoveEmptyEntries();

                Trace.WriteLine(returnXml);

                return returnXml;
            }
        }

        public static T DeserializeXml<T>(this string xmlData, bool removeEmptyElements = true) where T : Dto
        {
            string xmlDeserialize = removeEmptyElements
                ? xmlData.RemoveEmptyEntries()
                : xmlData;

            Trace.WriteLine(xmlDeserialize);

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xmlDeserialize))
                return (T) serializer.Deserialize(reader);
        }

        /// <summary>
        ///     Remove empty empty entries from xml
        /// </summary>
        /// <param name="xml">Input xml</param>
        /// <returns>Cleaned xml</returns>
        public static string RemoveEmptyEntries(this string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            doc.Descendants()
                .Where(e => e.IsEmpty || string.IsNullOrWhiteSpace(e.Value))
                .Remove();
            return doc.ToString();
        }
    }
}