namespace System
{
    public static class _T
    {
        public static bool In<T>(this T source, params T[] para)
        {
            foreach (var m in para)
            {
                if (source.Equals(m))
                    return true;
            }
            return false;
        }

        public static bool NotIn<T>(this T source, params T[] para)
        {
            foreach (var m in para)
            {
                if (source.Equals(m))
                    return false;
            }
            return true;
        }
    }
}