using System;

namespace RandomDataGenerator.Generators;

internal static class RandomValueGeneratorFactory
{
    private static readonly RandomValueGenerator Value = new(Environment.TickCount);

    public static RandomValueGenerator Create(int? seed)
    {
        return seed is null ? Value : new RandomValueGenerator(seed.Value);
    }
}