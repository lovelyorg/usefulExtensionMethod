using System.Text.RegularExpressions;

namespace System
{
    public static class _String
    {
        public static bool isEmpty(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        public static bool isNumber(this string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }

        public static bool isNotEmpty(this string source)
        {
            return !string.IsNullOrWhiteSpace(source);
        }

        public static int toInt(this string source, int defaultValue = -1)
        {
            int result;
            if (int.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static double toDouble(this string source, double defaultValue = -1)
        {
            double result;
            if (double.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static decimal toDecimal(this string source, decimal defaultValue = -1)
        {
            decimal result;
            if (decimal.TryParse(source, out result))
                return result;
            return defaultValue;
        }

        public static DateTime toDate(this string source, DateTime defaultValue = default(DateTime))
        {
            DateTime result;
            if (DateTime.TryParse(source, out result))
                return result;
            return default(DateTime);
        }
    }
}