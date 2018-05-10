namespace System
{
    public static class _object
    {
        public static int toInt(this object source, int defaultValue = 0)
        {
            if (source == null) return defaultValue;

            return source.ToString().toInt(defaultValue);
        }
    }
}