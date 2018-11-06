using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;
using RandomDataGenerator.Net.TextData;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerCity : RandomizerAbstract<FieldOptionsCity>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _generator;

        public RandomizerCity(FieldOptionsCity options) : base(options)
        {
            _generator = new RandomStringFromListGenerator(Texts.Instance.CityNames);
        }

        public string GetData()
        {
            return IsNull() ? null : _generator.Generate();
        }
    }
}