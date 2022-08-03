using System.Collections.Generic;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;
    private readonly RandomValueGenerator _randomValueGenerator;

    public RandomizerTextWords(FieldOptionsTextWords options) : base(options)
    {
        _randomValueGenerator = RandomValueGeneratorFactory.Create(options.Seed);
        _generator = new RandomStringFromListGenerator(ListData.Instance.LoremIpsumWords, options.Seed);
    }

    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int max = _randomValueGenerator.Next(Options.Min, Options.Max);
        var list = new List<string>(max);
        for (int i = 0; i < max; i++)
        {
            list.Add(_generator.Generate()!);
        }

        return string.Join(" ", list.ToArray());
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}