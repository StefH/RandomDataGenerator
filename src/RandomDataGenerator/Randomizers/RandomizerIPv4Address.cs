using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerIPv4Address : RandomizerAbstract<FieldOptionsIPv4Address>, IRandomizerString
{
    private readonly RandomThingsGenerator<byte>[] _octetsGenerator = new RandomThingsGenerator<byte>[4];

    public RandomizerIPv4Address(FieldOptionsIPv4Address options) : base(options)
    {
        byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? new byte[] { 0, 0, 0, 0 } : Options.Min!.Split('.').Select(byte.Parse).ToArray();
        byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? new byte[] { 0xff, 0xff, 0xff, 0xff } : Options.Max!.Split('.').Select(byte.Parse).ToArray();

        for (int i = 0; i < 4; i++)
        {
            _octetsGenerator[i] = new RandomThingsGenerator<byte>(octetsMin[i], octetsMax[i], options.Seed);
        }
    }

    public string? Generate()
    {
        return IsNull() ? null : string.Join(".", _octetsGenerator.Select(gen => $"{gen.Generate()}").ToArray());
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}