using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
{
    class RandomizerCity : RandomizerAbstract<FieldOptionsCity>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _generator;

        public RandomizerCity(FieldOptionsCity options) : base(options)
        {
            _generator = new RandomStringFromListGenerator(Texts.Instance.CityNames);
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.Generate();
        }
    }
}