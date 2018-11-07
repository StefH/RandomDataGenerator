using System;

namespace RandomDataGenerator.Generators
{
    public class RandomIntegerGenerator
    {
        private readonly Random _rnd = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        private readonly int _min;
        private readonly int _max;

        public RandomIntegerGenerator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public int Generate()
        {
            return _rnd.Next(_min, _max);
        }
    }
}