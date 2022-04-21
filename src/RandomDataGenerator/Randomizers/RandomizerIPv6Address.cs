using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerIPv6Address : RandomizerAbstract<FieldOptionsIPv6Address>, IRandomizerString
{
    private readonly int[] _defaultMin = { 0, 0, 0, 0, 0, 0, 0, 0 };
    private readonly int[] _defaultMax = { 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff };

    private readonly RandomThingsGenerator<int>[] _hextets = new RandomThingsGenerator<int>[8];

    public RandomizerIPv6Address(FieldOptionsIPv6Address options) : base(options)
    {
        int[] hextetsMin = string.IsNullOrEmpty(Options.Min) ? _defaultMin : Options.Min!.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();
        int[] hextetsMax = string.IsNullOrEmpty(Options.Max) ? _defaultMax : Options.Max!.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();

        for (int i = 0; i < 8; i++)
        {
            _hextets[i] = new RandomThingsGenerator<int>(hextetsMin[i], hextetsMax[i], options.Seed);
        }
    }

    public string? Generate()
    {
        return IsNull() ? null : string.Join(":", _hextets.Select(gen => $"{gen.Generate():X4}").ToArray());
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}