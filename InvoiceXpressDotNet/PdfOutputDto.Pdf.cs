using System.Xml.Serialization;

namespace InvoiceXpressDotNet.DataTransferObjects
{
    public partial class PdfOutputDto
    {
        /// <summary>
        ///     If true the pdf document is ready to be seen or downloaded, otherwise try again later
        /// </summary>
        [XmlIgnore]
        public bool IsPdfReady { get; set; }
    }
}