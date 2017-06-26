using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
    public abstract class Dto
    {
        public string GetXml()
        {
            return this.XmlSerializeToString();
        }

        /*
        // maybe implement later
        public string GetFromJson()
        {
            return this.XmlSerializeToString();
        }
         */
    }
}
