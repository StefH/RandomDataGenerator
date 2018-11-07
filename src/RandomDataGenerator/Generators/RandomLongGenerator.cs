using System;

namespace RandomDataGenerator.Generators
{
    public class RandomLongGenerator
    {
        private readonly long _min;
        private readonly long _max;

        public RandomLongGenerator(long min, long max)
        {
            if (min >= max)
                throw new ArgumentException("Min must be < Max");

            _min = min;
            _max = max;
        }

        public long Generate()
        {
            return RandomValueGenerator.Next(_min, _max);
        }
    }
}