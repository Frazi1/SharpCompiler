using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

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
            var textValue = ((TextValue)attributes[0]).Value;
            return textValue;
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
                action(item);
        }
    }
}