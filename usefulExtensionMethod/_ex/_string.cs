using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System
{
    public static class _string
    {
        public static bool isEmpty(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        public static bool isNotEmpty(this string source)
        {
            return !string.IsNullOrWhiteSpace(source);
        }

        public static bool isNumber(this string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }

        public static int toInt(this string source)
        {
            return Convert.ToInt32(source);
        }

        public static int tryToInt(this string source, int defaultValue = default(int))
        {
            int result;
            if (int.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static Int64 toInt64(this string source)
        {
            return Convert.ToInt64(source);
        }

        public static Int64 tryToInt64(this string source, Int64 defaultValue = default(Int64))
        {
            Int64 result;
            if (long.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static double toDouble(this string source)
        {
            return Convert.ToDouble(source);
        }

        public static double tryToDouble(this string source, double defaultValue = default(double))
        {
            double result;
            if (double.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static decimal toDecimal(this string source)
        {
            return Convert.ToDecimal(source);
        }

        public static decimal tryToDecimal(this string source, decimal defaultValue = default(decimal))
        {
            decimal result;
            if (decimal.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static DateTime toDate(this string source)
        {
            return Convert.ToDateTime(source);
        }

        public static DateTime tryToDate(this string source, DateTime defaultValue = default(DateTime))
        {
            DateTime result;
            if (DateTime.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        /// <summary>
        /// 将字符串按照长度n分割成数组
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IEnumerable<string> split(this string s, int n)
        {
            var lastGroupItemLength = s.Length % n;
            var groupLength = s.Length / n + (lastGroupItemLength == 0 ? 0 : 1);

            var result = new List<string>();
            int i;
            for (i = 0; i < groupLength - 1; i++)
            {
                result.Add(s.Substring(i * n, n));
            }
            result.Add(s.Substring(i * n, lastGroupItemLength != 0 ? lastGroupItemLength : n));
            return result;
        }
    }
}