using System;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.DataTransferObjects;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.Extensions
{
    public static class UrlExtensions
    {
		public static string BuildUrlFilter(this InvoiceFilters filters)
		{
			if (filters == null) return "";
			string str = "";

			Type type = typeof(InvoiceFilters);
			if (filters.DocumentType.Count > 0)
			{
				string nameOf = nameof(InvoiceFilters.DocumentType);
				string qsName = type.GetAttributeValue<UrlFilterAttribute, string>(nameOf, attr => attr.Name);
				foreach (DocumentType dt in filters.DocumentType)
				{
					string qsValue = dt.GetAttributeValue<UrlFilterAttribute, string>(attr => attr.Name);
					if (!string.IsNullOrWhiteSpace(qsValue))
						str += $"&{qsName}={qsValue}";
				}
			}
			if (filters.DocumentStatus.Count > 0)
			{
				string nameOf = nameof(InvoiceFilters.DocumentStatus);
				string qsName = type.GetAttributeValue<UrlFilterAttribute, string>(nameOf, attr => attr.Name);
				foreach (DocumentStatus ds in filters.DocumentStatus)
				{
					string qsValue = ds.GetAttributeValue<UrlFilterAttribute, string>(attr => attr.Name);
					if (!string.IsNullOrWhiteSpace(qsValue))
						str += $"&{qsName}={qsValue}";
				}
			}

			if (!string.IsNullOrEmpty(filters.Text))
				str += $"&text={filters.Text.ToUrl()}";

			if (filters.DueDateTo.HasValue)
				str += $"&due_date[to]={filters.DateTo.ToUrl()}";
			if (filters.DueDateFrom.HasValue)
				str += $"&due_date[from]={filters.DueDateFrom.ToUrl()}";

			if (filters.DateTo.HasValue)
				str += $"&date[to]={filters.DateTo.ToUrl()}";
			if (filters.DateFrom.HasValue)
				str += $"&date[from]={filters.DateFrom.ToUrl()}";

			if (filters.TotalBeforeTaxesFrom.HasValue)
				str += $"&total_before_taxes[from]={filters.TotalBeforeTaxesFrom.ToUrl()}";
			if (filters.TotalBeforeTaxesTo.HasValue)
				str += $"&total_before_taxes[to]={filters.TotalBeforeTaxesTo.ToUrl()}";

			if (filters.NonArchived ?? false)
				str += $"&non_archived={filters.NonArchived.ToUrl()}";

			if (filters.Archived ?? false)
				str += $"&archived={filters.Archived.ToUrl()}";

			return str;
		}
	}
}
