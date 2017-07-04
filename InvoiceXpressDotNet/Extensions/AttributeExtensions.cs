using System;
using System.Linq;
using System.Reflection;

namespace InvoiceXpressDotNet.Extensions
{
	public static class AttributeHelper
	{
		public static TAttribute GetAttributeValue<TAttribute>(
			this Type type,
			string memberName)
			where TAttribute : Attribute
		{
			MemberInfo info = type.GetMember(memberName).FirstOrDefault();
			if (info == null) return null;

			var attr = info.GetCustomAttributes(typeof(TAttribute), true)
				.FirstOrDefault() as TAttribute;

			return attr;
		}


		public static TOutValue GetAttributeValue<TAttribute, TOutValue>(
			this Type type,
			string memberName,
			Func<TAttribute, TOutValue> valueSelector)
			where TAttribute : Attribute
		{
			var attr = GetAttributeValue<TAttribute>(type, memberName);
			return attr != null ? valueSelector(attr) : default(TOutValue);
		}
		
		public static TOutValue GetAttributeValue<TAttribute, TOutValue>(this Enum value, Func<TAttribute, TOutValue> valueSelector)
			where TAttribute : Attribute
		{
			var attr = GetAttribute<TAttribute>(value);
			return attr == null ? default(TOutValue) : valueSelector(attr);
		}

		private static TAttribute GetAttribute<TAttribute>(Enum value) where TAttribute : Attribute
		{
			Type enumType = value.GetType();
			string name = Enum.GetName(enumType, value);
			if (string.IsNullOrEmpty(name)) return null;

			TAttribute attr = enumType.GetField(name)
				.GetCustomAttributes(false)
				.OfType<TAttribute>()
				.FirstOrDefault();
			return attr;
		}

/*
		public static TValue GetAttributeValue<TAttribute, TValue>(
			this Type type,
			Func<TAttribute, TValue> valueSelector)
			where TAttribute : Attribute
		{
			var att = type.GetCustomAttributes(typeof(TAttribute), true)
				.FirstOrDefault() as TAttribute;
			return att != null ? valueSelector(att) : default(TValue);
		}
*/
	}
}
