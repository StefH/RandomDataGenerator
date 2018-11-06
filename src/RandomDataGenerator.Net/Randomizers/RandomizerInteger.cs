using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerInteger : RandomizerAbstract<FieldOptionsInteger>, IRandomizerInteger
    {
        private readonly RandomIntegerGenerator _generator;

        public RandomizerInteger(FieldOptionsInteger options): base(options)
        {
            _generator = new RandomIntegerGenerator(options.Min, options.Max);
        }

        public int? Generate()
        {
            return IsNull() ? null : (int?)_generator.Generate();
        }
    }
}