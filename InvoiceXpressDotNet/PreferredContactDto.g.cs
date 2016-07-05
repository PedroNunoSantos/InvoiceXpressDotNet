using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("preferred_contact"), XmlType(AnonymousType=true)]
	public partial class PreferredContactDto : Dto
	{		
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("phone")]
		public string Phone { get; set; }
		
		[XmlElement("mobile")]
		public string Mobile { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<PreferredContactDto>();
        }
		*/
	}
}
