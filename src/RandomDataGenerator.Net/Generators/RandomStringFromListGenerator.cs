using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RandomDataGenerator.Net.Generators
{
    public class RandomStringFromListGenerator
    {
        private readonly string[] _list;
        private readonly Random _rnd = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), NumberStyles.HexNumber));

        public RandomStringFromListGenerator(IEnumerable<string> list)
        {
            _list = list.ToArray();
        }

        public string Generate()
        {
            return _list[_rnd.Next(_list.Length)];
        }
    }
}