// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("account"), XmlType(AnonymousType=true)]
	public partial class UserAccountDto : Dto
	{		

		[XmlIgnore]
		public int? Id { get; set; }
		
		//serialization helper for Id
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
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
		public RolesDto Roles { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UserAccountDto>();
        }
		*/
	}
}
