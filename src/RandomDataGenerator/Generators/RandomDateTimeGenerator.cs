using System;

namespace RandomDataGenerator.Generators
{
    public class RandomDateTimeGenerator
    {
        private readonly DateTime _min;
        private readonly DateTime _max;

        public RandomDateTimeGenerator(DateTime min, DateTime max)
        {
            if (min >= max)
                throw new ArgumentException("Min must be < Max");

            _min = min;
            _max = max;
        }

        public DateTime Generate()
        {
            return RandomValueGenerator.Next(_min, _max);
        }
    }
}