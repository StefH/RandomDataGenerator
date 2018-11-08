namespace RandomDataGenerator.Generators
{
    internal class RandomThingsGenerator<T>
    {
        private readonly T _min;
        private readonly T _max;

        public RandomThingsGenerator(T min, T max)
        {
            _min = min;
            _max = max;
        }

        public T Generate()
        {
            return RandomValueGenerator.Next(_min, _max);
        }
    }
}