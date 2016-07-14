using System;
using System.Globalization;

namespace InvoiceXpressDotNet.Extensions
{
    public static class XmlConverterHelpers
    {
        private const string DateFormat = @"dd\/MM\/yyyy";
        private const string FloatFormat = "0.00";

        public static string ToXml<T>(this T data)
        {
            if (typeof(T) == typeof(float?))
            {
                var floatValue = data as float?;
                return floatValue.HasValue ? floatValue.Value.ToString(FloatFormat, CultureInfo.InvariantCulture) : null;
            }

            if (typeof(T) == typeof(DateTime?))
            {
                var dateValue = data as DateTime?;
                return dateValue.HasValue ? dateValue.Value.ToString(DateFormat, CultureInfo.InvariantCulture) : null;
            }

            if (typeof(T) == typeof(int?))
            {
                var intValue = data as int?;
                return intValue.HasValue ? intValue.Value.ToString(CultureInfo.InvariantCulture) : null;
            }

            if (typeof(T) == typeof(bool?))
            {
                var boolValue = data as bool?;
                return boolValue.HasValue ? boolValue.Value.ToString(CultureInfo.InvariantCulture) : null;
            }

            throw new ArgumentOutOfRangeException();
        }

        public static T FromXml<T>(this string str)
        {
            Type baseType = typeof(T);
            baseType = Nullable.GetUnderlyingType(baseType) ?? baseType;

            if (baseType == typeof(float))
            {
                float floatValue;
                if (float.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out floatValue))
                    return (T) Convert.ChangeType(floatValue, baseType);
                return default(T);
            }

            if (baseType == typeof(DateTime))
            {
                DateTime dateVal;
                if (DateTime.TryParseExact(str, DateFormat, null, DateTimeStyles.AssumeLocal,
                    out dateVal))
                    return (T) Convert.ChangeType(dateVal, baseType);
                return default(T);
            }

            if (baseType == typeof(int))
            {
                int intValue;
                if (int.TryParse(str, out intValue))
                    return (T) Convert.ChangeType(intValue, baseType);
                return default(T);
            }

            if (baseType == typeof(bool))
            {
                bool boolValue;
                if (bool.TryParse(str, out boolValue))
                    return (T) Convert.ChangeType(boolValue, baseType);
                return default(T);
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}