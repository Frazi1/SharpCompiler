using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MathLang.Extensions
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
                action(item);
        }

        public static void ReverseForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            enumerable.Reverse().ForEach(action);
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

        public static bool Contains<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            return enumerable.FirstOrDefault(predicate) != null;
        }

        public static string ToCamelCase(this string str)
        {
            return str[0].ToString().ToLower() +  (str.Length > 1 ? str.Substring(1) : string.Empty);
        }

        public static IEnumerable<T> GetDuplicatedItems<T>(this IEnumerable<T> enumerable)
        {   
            //var list = enumerable.ToList();
            //for (int i = 0; i < list.Count; i++)
            //for (int j = i + 1; j < list.Count; j++)
            //    if (list[i].Equals(list[j]))
            //        return list[i];
            //return default(T);
            return enumerable.GroupBy(x => x)
                .Where(x => x.Skip(1).Any())
                .SelectMany(x => x);
        }

        public static bool HasDuplicates<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.GetDuplicatedItems().Any();
        }

        public static string RemoveFirstAndLastCharacters(this string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}