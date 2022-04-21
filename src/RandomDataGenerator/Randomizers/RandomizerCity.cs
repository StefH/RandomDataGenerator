using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerCity : RandomizerAbstract<FieldOptionsCity>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;

    public RandomizerCity(FieldOptionsCity options) : base(options)
    {
        _generator = new RandomStringFromListGenerator(ListData.Instance.CityNames);
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