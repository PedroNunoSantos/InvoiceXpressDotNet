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
	[XmlRoot("change_account_to"), XmlType(AnonymousType=true)]
	public partial class ChangeAccountToDto : Dto
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
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ChangeAccountToDto>();
        }
		*/
	}
}
