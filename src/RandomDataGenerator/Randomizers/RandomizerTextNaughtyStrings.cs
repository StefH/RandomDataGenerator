using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerTextNaughtyStrings : RandomizerAbstract<FieldOptionsTextNaughtyStrings>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _naughtyStringCategoryGenerator;

    public RandomizerTextNaughtyStrings(FieldOptionsTextNaughtyStrings options) : base(options)
    {
        Type type = typeof(TheNaughtyStrings);

        var allStrings = new List<string>(TheNaughtyStrings.All);

        var categories = options.Categories
            .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .Where(s => s != FieldOptionsTextNaughtyStrings.All);
        foreach (string category in categories)
        {
            if (type.GetField(category).GetValue(null) is IList<string> strings)
            {
                allStrings.AddRange(strings);
            }
        }

        _naughtyStringCategoryGenerator = new RandomStringFromListGenerator(allStrings);
    }

    public string? Generate()
    {
        return IsNull() ? null : _naughtyStringCategoryGenerator.Generate();
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}