using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Generators
{
    internal class RandomItemFromListGenerator<T>
    {
        private readonly T[] _list;

        public RandomItemFromListGenerator(IEnumerable<T> list, Func<T, bool> predicate = null)
        {
            _list = predicate == null ? list.ToArray() : list.Where(predicate).ToArray();
        }

        public T Generate()
        {
            return _list.Length > 0 ? _list[RandomValueGenerator.Next(0, _list.Length)] : default(T);
        }
    }
}