namespace RandomDataGenerator.Extensions
{
    internal static class StringExtensions
    {
        public static string ToCasedInvariant(this string str, bool toUpper)
        {
            if (str == null)
            {
                return null;
            }

            return toUpper ? str.ToUpperInvariant() : str.ToLowerInvariant();
        }
    }
}