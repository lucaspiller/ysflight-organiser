using System;
using System.Collections.Generic;

namespace Ysfo.Core
{
    internal static class Extensions
    {
        // adds ForEach to IEnumerable
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
            {
                action(item);
            }
        }
    }
}
