namespace System
{
    public static class _int64
    {
        /// <summary>
        /// timestamp to date
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime toDate(this Int64 source)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))
                  .AddMilliseconds(source);
        }
    }
}