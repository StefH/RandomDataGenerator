using System;
using System.Linq;
using RandomDataGenerator.CreditCardValidator;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerCCN : RandomizerAbstract<FieldOptionsCCN>, IRandomizerString
{
    private readonly RandomizerNumber<int> _randomizerNumberBetween0And10;

    public RandomizerCCN(FieldOptionsCCN options) : base(options)
    {
        _randomizerNumberBetween0And10 = new RandomizerNumber<int>(new FieldOptionsInteger { Min = 0, Max = 10, Seed = options.Seed });
    }

    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        return GenerateRandomCreditCardNumber(Options.CardIssuer, Options.Length);
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }

    private string GenerateRandomCreditCardNumber(CardIssuer cardIssuer, int length)
    {
        var rules = ValidationHelper.GetRulesByLength(cardIssuer, Options.Length);

        if (Options.Length > 0 && rules.Count == 0)
        {
            throw new ArgumentException($"The card number length [{Options.Length}] is not valid for the card issuer [{cardIssuer}].");
        }

        var rule = rules.Count == 0 ? CreditCardData.BrandsData[cardIssuer].Rules.First() : rules.First();

        length = length > 0 ? length : rule.Lengths.First();

        var number = new RandomItemFromListGenerator<string>(Options.Seed, rule.Prefixes).Generate();

        var numberLength = number.Length;
        for (int i = 0; i < length - 1 - numberLength; i++)
        {
            number += _randomizerNumberBetween0And10.Generate();
        }

        number += Luhn.CreateCheckDigit(number);

        return number;
    }
}