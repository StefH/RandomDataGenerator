// Copied from https://github.com/gustavofrizzo/CreditCardValidator
using System;
using System.Linq;
using RandomDataGenerator.Extensions;

namespace RandomDataGenerator.CreditCardValidator;

public static class Luhn
{
    // Convert to int.
    private static readonly Func<char, int> CharToInt = c => c - '0';

    private static readonly Func<int, bool> IsEven = i => i % 2 == 0;

    // New Double Concept => 7 * 2 = 14 => 1 + 4 = 5.
    private static readonly Func<int, int> DoubleDigit = i => (i * 2).ToString().ToCharArray().Select(CharToInt).Sum();

    public static string CreateCheckDigit(string number)
    {
        if (!ValidationHelper.IsAValidNumber(number))
        {
            throw new ArgumentException("Invalid number. Just numbers and white spaces are accepted in the string.");
        }

        var digitsSum = number
            .RemoveWhiteSpace()
            .ToCharArray()
            .Reverse()
            .Select(CharToInt)
            .Select((digit, index) => IsEven(index) ? DoubleDigit(digit) : digit)
            .Sum();

        digitsSum *= 9;

        return digitsSum
            .ToString()
            .ToCharArray()
            .Last()
            .ToString();
    }
}