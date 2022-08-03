namespace RandomDataGenerator.Generators;

internal class RandomThingsGenerator<T>
{
    private readonly RandomValueGenerator _randomValueGenerator;
    private readonly T _min;
    private readonly T _max;

    public RandomThingsGenerator(T min, T max, int? seed)
    {
        _min = min;
        _max = max;
        _randomValueGenerator = RandomValueGeneratorFactory.Create(seed);
    }

    public T Generate()
    {
        return _randomValueGenerator.Next(_min, _max);
    }
}