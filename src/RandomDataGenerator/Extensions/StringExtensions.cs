using System.Linq;

namespace RandomDataGenerator.Extensions;

internal static class StringExtensions
{
    public static string? ToCasedInvariant(this string? str, bool toUpper)
    {
        if (str == null)
        {
            return null;
        }

        return toUpper ? str.ToUpperInvariant() : str.ToLowerInvariant();
    }

    public static string RemoveWhiteSpace(this string input)
    {
        return new string(input.ToCharArray()
            .Where(c => !char.IsWhiteSpace(c))
            .ToArray());
    }
}