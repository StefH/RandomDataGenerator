using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerCountry : RandomizerAbstract<FieldOptionsCountry>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;

    public RandomizerCountry(FieldOptionsCountry options) : base(options)
    {
        _generator = new RandomStringFromListGenerator(ListData.Instance.CountryNames);
    }

    public string? Generate()
    {
        return IsNull() ? null : _generator.Generate();
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}