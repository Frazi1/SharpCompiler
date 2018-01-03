using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace JasminSharp.Helpers
{
    public static class Extensions
    {
        public static string GetTextValue<TEnum>(this TEnum value)
            where TEnum : struct, IConvertible
        {
            var type = typeof(TEnum);
            var memInfo = type.GetMember(value.ToString(CultureInfo.InvariantCulture));
            var attributes = memInfo[0].GetCustomAttributes(typeof(TextValue), false);
            var textValue = ((TextValue) attributes[0]).Value;
            return textValue;
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
                action(item);
        }

        public static IEnumerable<Enum> GetFlags(this Enum e)
        {
            return Enum.GetValues(e.GetType()).Cast<Enum>().Where(e.HasFlag);
        }

        public static IEnumerable<T> GetFlags<T>(this Enum e)
        {
            return e.GetFlags().Cast<T>();
        }

        public static IEnumerable<T> GetFlagsWithoutDefault<T>(this Enum e)
        {
            return GetFlags<T>(e).Where(flag => !flag.Equals(default(T)));
        }
    }
}