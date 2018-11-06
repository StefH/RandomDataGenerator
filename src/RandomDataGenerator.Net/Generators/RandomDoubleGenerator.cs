using System;

namespace RandomDataGenerator.Net.Generators
{
    public class RandomDoubleGenerator
    {
        private readonly double _min;
        private readonly double _max;

        public RandomDoubleGenerator(double min, double max)
        {
            if (min >= max)
                throw new ArgumentException("Min must be < Max");

            _min = min;
            _max = max;
        }

        public double Generate()
        {
            return RandomValueGenerator.Next(_min, _max);
        }
    }
}