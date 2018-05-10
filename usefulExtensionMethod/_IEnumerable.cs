﻿using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class _IEnumerable
    {
        public static bool isEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        public static bool isNotEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }

        public static string join<T>(this IEnumerable<T> source, string joiner)
        {
            var result = string.Empty;
            foreach (var item in source)
            {
                result += item + joiner;
            }
            return result.TrimEnd(joiner.ToCharArray());
        }
    }
}