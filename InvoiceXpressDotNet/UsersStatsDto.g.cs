﻿// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("users"), XmlType(AnonymousType=true)]
	public partial class UsersStatsDto : Dto
	{		
		
		[XmlIgnore]
		public int? UsedUsers { get; set; }
		
		[XmlElement("used_users"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _UsedUsersDto
	    {	    
			get { return UsedUsers.ToXml<int?>(); }
            set { UsedUsers = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableUsers { get; set; }
		
		[XmlElement("available_users"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _AvailableUsersDto
	    {	    
			get { return AvailableUsers.ToXml<int?>(); }
            set { AvailableUsers = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UsersStatsDto>();
        }
		*/
	}
}
