namespace System.Data
{
    public static class _DataTable
    {
        public static bool isEmpty(this DataTable source)
        {
            return source == null || source.Rows == null || source.Rows.Count == 0;
        }

        public static bool isNotEmpty(this DataTable source)
        {
            return !isEmpty(source);
        }

        public static void forEach(this DataRowCollection source, Action<DataRow> action)
        {
            if (source != null && source.Count > 0)
            {
                for (var i = 0; i < source.Count; i++)
                {
                    action(source[i]);
                }
            }
        }

        public static string getValue(this DataRow source, string columName)
        {
            var temp = source[columName];
            if (temp != null)
                return temp.ToString().Trim();
            return string.Empty;
        }
    }
}