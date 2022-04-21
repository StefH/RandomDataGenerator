using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerTextLipsum : RandomizerAbstract<FieldOptionsTextLipsum>, IRandomizerString
{
    private const string Newline = "\r\n";
    private readonly RandomStringsFromListGenerator _generator;

    public RandomizerTextLipsum(FieldOptionsTextLipsum options) : base(options)
    {
        _generator = new RandomStringsFromListGenerator(ListData.Instance.LoremIpsum);
    }

    public string? Generate()
    {
        return IsNull() ? null : string.Join(Newline, _generator.Generate(Options.Paragraphs).ToArray());
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}