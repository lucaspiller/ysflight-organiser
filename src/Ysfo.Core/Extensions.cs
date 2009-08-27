using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        // returns a string In Title Case (all words uppercase)
        public static String ToTitleCase(this String input)
        {
            // check not null
            if (input == null)
            {
                return null;
            }

            // convert other characters to spaces
            input = Regex.Replace(input, "([^a-zA-Z0-9-]+)", " ");

            // uppercase first character of each word
            input = Regex.Replace(input.ToLower(), @"(^|\W).", m => m.Value.ToUpper());

            return input;
        }
    }
}
