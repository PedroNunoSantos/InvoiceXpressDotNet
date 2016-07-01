using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("users"), XmlType(AnonymousType=true)]
	public partial class UsersStatsDto
	{
		
		[XmlIgnore]
		public int? UsedUsers { get; set; }
		
		[XmlElement("used_users"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _UsedUsersDto
	    {	    
			get { return UsedUsers.ToXml<int?>(); }
            set { UsedUsers = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableUsers { get; set; }
		
		[XmlElement("available_users"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _AvailableUsersDto
	    {	    
			get { return AvailableUsers.ToXml<int?>(); }
            set { AvailableUsers = value.FromXml<int?>(); }
	    }
	}
}
