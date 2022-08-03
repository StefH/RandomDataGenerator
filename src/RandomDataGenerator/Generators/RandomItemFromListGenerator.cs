using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Generators;

internal class RandomItemFromListGenerator<T>
{
    private readonly RandomValueGenerator _randomValueGenerator;
    private readonly T[] _list;

    public RandomItemFromListGenerator(int? seed, IEnumerable<T> list, Func<T, bool>? predicate = null)
    {
        _list = predicate == null ? list.ToArray() : list.Where(predicate).ToArray();
        _randomValueGenerator = RandomValueGeneratorFactory.Create(seed);
    }

    public T? Generate()
    {
        return _list.Length > 0 ? _list[_randomValueGenerator.Next(0, _list.Length - 1)] : default;
    }
}