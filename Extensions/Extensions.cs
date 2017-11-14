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
            return (TResult) input;
        }
    }
}