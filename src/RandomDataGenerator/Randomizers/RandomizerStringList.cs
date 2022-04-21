using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerStringList : RandomizerAbstract<FieldOptionsStringList>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;

    public RandomizerStringList(FieldOptionsStringList options)
        : base(options)
    {
        _generator = new RandomStringFromListGenerator(options.Values);
    }

    public string? Generate()
    {
        return IsNull() ? null : _generator.Generate();
    }

    public string? Generate(bool upperCase)
    {
        return IsNull() ? null : _generator.Generate().ToCasedInvariant(upperCase);
    }
}