namespace System
{
    public static class _T
    {
        public static bool In<T>(this T source, params T[] para) where T : struct
        {
            foreach (var m in para)
            {
                if (source.Equals(m))
                    return true;
            }
            return false;
        }

        public static bool NotIn(this int source, int[] para)
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