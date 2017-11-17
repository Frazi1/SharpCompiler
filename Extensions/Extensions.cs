using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MathLang.Extensions
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
            where T : class
        {
            foreach (T item in enumerable)
                action(item);
        }

        public static TResult CastTo<TResult>(this object input)
        {
            if(input == null) throw new NullReferenceException(nameof(input));
            return (TResult)input;
        }

        public static List<T> AsList<T>(this T item, params T[] otherItems)
        {
            var list = new List<T> { item };
            list.AddRange(otherItems);
            return list;
        }

        public static List<TResult> AsListOf<TResult>(this IEnumerable enumerable)
        {
            return enumerable.Cast<TResult>().ToList();
        }
        
        public static List<TResult> AsListOf<TResult>(this object item, params object[] otherItems)
        {
            return item.AsList(otherItems).Cast<TResult>().ToList();
        }
    }
}