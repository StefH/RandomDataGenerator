using System;

namespace RandomDataGenerator.Net.Generators
{
    public class RandomTimeGenerator
    {
        private readonly TimeSpan _min;
        private readonly TimeSpan _max;

        public RandomTimeGenerator(TimeSpan min, TimeSpan max)
        {
            if (min >= max)
                throw new ArgumentException("Min must be < Max");

            _min = min;
            _max = max;
        }

        public TimeSpan Generate()
        {
            return RandomValueGenerator.Next(_min, _max);
        }
    }
}