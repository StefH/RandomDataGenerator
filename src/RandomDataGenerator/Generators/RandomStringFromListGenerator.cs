using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Generators
{
    public class RandomStringFromListGenerator
    {
        private readonly string[] _list;

        public RandomStringFromListGenerator(IEnumerable<string> list)
        {
            _list = list.ToArray();
        }

        public string Generate()
        {
            return _list.Length > 0 ? _list[RandomValueGenerator.Next(0, _list.Length)] : string.Empty;
        }
    }
}