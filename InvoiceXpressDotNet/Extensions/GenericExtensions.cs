using System.Collections.Generic;
using System.Linq;

namespace InvoiceXpressDotNet.Extensions
{
    internal static class GenericExtensions
    {
        internal static bool IsAnyOf<T>(this T data, params T[] parms)
        {
            return IsAnyOf(data, EqualityComparer<T>.Default, parms);
        }

        internal static bool IsAnyOf<T>(this T data, IEqualityComparer<T> comparer, params T[] parms)
        {
            return parms.Contains(data, comparer);
        }

        internal static bool IsNoneOf<T>(this T data, params T[] parms)
        {
            return IsNoneOf(data, EqualityComparer<T>.Default, parms);
        }

        internal static bool IsNoneOf<T>(this T data, IEqualityComparer<T> comparer, params T[] parms)
        {
            return !parms.Contains(data, comparer);
        }
    }
}