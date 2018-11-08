using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerInteger : RandomizerAbstract<FieldOptionsInteger>, IRandomizerInteger
    {
        private readonly RandomThingsGenerator<int> _generator;

        public RandomizerInteger(FieldOptionsInteger options): base(options)
        {
            _generator = new RandomThingsGenerator<int>(options.Min, options.Max);
        }

        public int? Generate()
        {
            return IsNull() ? null : (int?)_generator.Generate();
        }
    }
}