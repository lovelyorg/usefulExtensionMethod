namespace System
{
    public static class _Datetime
    {
        public static Int64 timestamp(this DateTime t)
        {
            Int64 result = (t.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            return result;
        }
    }
}