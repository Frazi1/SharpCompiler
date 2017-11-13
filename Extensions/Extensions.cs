using System;
using System.Collections;
using System.Collections.Generic;

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

        public static TResult Cast<TInput, TResult>(this TInput input)
            where TResult : class
            where TInput : class
        {
            return input as TResult;
        }
    }
}