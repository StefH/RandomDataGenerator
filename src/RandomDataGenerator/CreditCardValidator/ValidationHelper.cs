// Copied from https://github.com/gustavofrizzo/CreditCardValidator

using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Extensions;

namespace RandomDataGenerator.CreditCardValidator;

internal static class ValidationHelper
{
    public static bool IsAValidNumber(string number)
    {
        number = number.RemoveWhiteSpace();

        return number.ToCharArray().All(char.IsNumber) && !string.IsNullOrEmpty(number);
    }

    internal static List<Rule> GetRulesByLength(CardIssuer cardIssuer, int length)
    {
        var rules = CreditCardData.BrandsData[cardIssuer].Rules;

        return rules.Where(rule => rule.Lengths.Contains(length)).ToList();
    }
}