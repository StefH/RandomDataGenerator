using System;
using System.Linq;
using RandomDataGenerator.Data;
using RandomDataGenerator.Data.Models;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerIBAN : RandomizerAbstract<FieldOptionsIBAN>, IRandomizerString
{
    private readonly RandomItemFromListGenerator<IBAN> _itemGenerator;

    public RandomizerIBAN(FieldOptionsIBAN options) : base(options)
    {
        Func<IBAN, bool>? predicate = null;

        if (!string.IsNullOrEmpty(options.CountryCode))
        {
            predicate = iban => iban.CountryCode == options.CountryCode;
        }

        // Set the list to IBAN as default
        var list = ListData.Instance.IBANs; 
        switch (options.Type)
        {
            case "BBAN":
                list = ListData.Instance.BBANs;
                break;

            case "BOTH":
                list = list.Union(ListData.Instance.BBANs);
                break;
        }

        _itemGenerator = new RandomItemFromListGenerator<IBAN>(options.Seed, list, predicate);
    }

    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        var iban = _itemGenerator.Generate();
        return iban.Generator.Generate();
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}