using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerStringList : RandomizerAbstract<FieldOptionsStringList>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _generator;

        public RandomizerStringList(FieldOptionsStringList options)
            : base(options)
        {
            _generator = new RandomStringFromListGenerator(options.Values);
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.Generate();
        }
    }
}