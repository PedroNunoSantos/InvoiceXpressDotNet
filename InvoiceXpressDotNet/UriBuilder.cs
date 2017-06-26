using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
	public class UrlBuilder
	{
/*
		public string GetUrlFilter()
		{
			var sb = new StringBuilder();
			Dictionary<PropertyInfo, string> dic = GetUrls();
			foreach (KeyValuePair<PropertyInfo, string> pair in dic)
			{
				if (string.IsNullOrEmpty(pair.Value))
					continue;

				PropertyInfo p = pair.Key;
				string value = p.GetValue(this);

				sb.Append($"&{pair.Value}={value}");
			}

			return sb.ToString();
		}
*/

		protected Dictionary<PropertyInfo, string> GetUrls()
		{
			var dict = new Dictionary<PropertyInfo, string>();
			PropertyInfo[] props = GetType().GetProperties();

			foreach (PropertyInfo prop in props)
			foreach (object attr in prop.GetCustomAttributes(true))
			{
				var attribute = attr as UrlFilterAttribute;
				if (attribute == null) continue;
				dict.Add(prop, attribute.Name);
			}

			return dict;
		}
	}

	public static class UrlHelpers
	{
		private const string DateFormat = @"dd\/MM\/yyyy";
		private const string FloatFormat = "0.00";

		public static string ToUrl<T>(this T data)
		{
			if (data == null)
				return "";
			
			Type type = typeof(T);
			
			if (type == typeof(string))
			{
				var stringValue = data as string;
				return WebUtility.UrlEncode(stringValue);
			}

			if (type == typeof(float?))
			{
				var floatValue = data as float?;
				return WebUtility.UrlEncode(floatValue?.ToString(FloatFormat, CultureInfo.InvariantCulture));
			}

			if (type == typeof(DateTime?))
			{
				var dateValue = data as DateTime?;
				return WebUtility.UrlEncode(dateValue?.ToString(DateFormat, CultureInfo.InvariantCulture));
			}

			if (type == typeof(int?))
			{
				var intValue = data as int?;
				return WebUtility.UrlEncode(intValue?.ToString(CultureInfo.InvariantCulture));
			}

			if (type == typeof(bool?))
			{
				var boolValue = data as bool?;
				return WebUtility.UrlEncode(boolValue?.ToString(CultureInfo.InvariantCulture));
			}

			throw new ArgumentOutOfRangeException();
		}
	}

	
}
	