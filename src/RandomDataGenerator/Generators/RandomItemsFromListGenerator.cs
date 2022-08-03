using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Generators;

internal class RandomItemsFromListGenerator<T>
{
    private readonly RandomValueGenerator _randomValueGenerator;
    private readonly T[] _list;

    public RandomItemsFromListGenerator(int? seed, IEnumerable<T> list, Func<T, bool>? predicate = null)
    {
        _list = predicate == null ? list.ToArray() : list.Where(predicate).ToArray();
        _randomValueGenerator = RandomValueGeneratorFactory.Create(seed);
    }

    public List<T> Generate(int count)
    {
        var list = new List<T>(count);
        for (int i = 0; i < count; i++)
        {
            int index = _randomValueGenerator.Next(0, _list.Length - 1);
            list.Add(_list[index]);
        }

        return list;
    }
}