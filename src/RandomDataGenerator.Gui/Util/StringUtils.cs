
namespace RandomDataGenerator.Gui.Util
{
    public static class StringUtils
    {
        public static string MakeSafeSQL(object value)
        {
            if (value == null)
            {
                return "NULL";
            }

            string strValue = value.ToString();

            return !string.IsNullOrEmpty(strValue) ? strValue.Replace("'", "''") : string.Empty;
        }

        public static string AddSQLQuotes(object value)
        {
            if (value == null)
            {
                return AddSQLQuotes("NULL");
            }

            return $"'{MakeSafeSQL(value)}'";
        }
    }
}