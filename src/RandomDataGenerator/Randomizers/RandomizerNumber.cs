using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerNumber<T> : RandomizerAbstract<FieldOptionsNumber<T>>, IRandomizerNumber<T> where T : struct
{
    private readonly RandomThingsGenerator<T> _generator;

    public RandomizerNumber(FieldOptionsNumber<T> options) : base(options)
    {
        _generator = new RandomThingsGenerator<T>(options.Min, options.Max, options.Seed);
    }

    public T? Generate()
    {
        return IsNull() ? null : (T?)_generator.Generate();
    }
}