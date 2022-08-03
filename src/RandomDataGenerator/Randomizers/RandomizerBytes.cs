using System;
using System.Text;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerBytes : RandomizerAbstract<FieldOptionsBytes>, IRandomizerBytes
{
    private readonly RandomValueGenerator _randomValueGenerator;

    public RandomizerBytes(FieldOptionsBytes options)
        : base(options)
    {
        _randomValueGenerator = RandomValueGeneratorFactory.Create(options.Seed);
    }

    public byte[] Generate()
    {
        return _randomValueGenerator.NextBytes(Options.Min, Options.Max);
    }

    public string GenerateAsString(Encoding? encoding)
    {
        return (encoding ?? Encoding.UTF8).GetString(Generate());
    }

    public string GenerateAsUTF8String()
    {
        return GenerateAsString(Encoding.UTF8);
    }

    public string GenerateAsASCIIString()
    {
        return GenerateAsString(Encoding.ASCII);
    }

    public string GenerateAsBase64String()
    {
        return Convert.ToBase64String(Generate());
    }
}