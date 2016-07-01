using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("change_account_to"), XmlType(AnonymousType=true)]
	public partial class ChangeAccountToDto
	{
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
	}
}
