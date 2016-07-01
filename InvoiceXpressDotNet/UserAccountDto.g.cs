using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("account"), XmlType(AnonymousType=true)]
	public partial class UserAccountDto
	{
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("url")]
		public string Url { get; set; }
		
		[XmlElement("api_key")]
		public string ApiKey { get; set; }
		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("blocked")]
		public string Blocked { get; set; }
		
		[XmlElement("roles")]
		public RolesDto RolesArray { get; set; }
	}
}
