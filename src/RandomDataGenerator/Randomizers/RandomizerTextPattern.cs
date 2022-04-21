using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerTextPattern : RandomizerAbstract<FieldOptionsTextPattern>, IRandomizerString
{
    private readonly RandomStringGenerator _generator;

    public RandomizerTextPattern(FieldOptionsTextPattern options)
        : base(options)
    {
        _generator = new RandomStringGenerator();
    }

    public string? Generate()
    {
        return IsNull() || string.IsNullOrEmpty(Options.Pattern) ? null : _generator.Generate(Options.Pattern);
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}