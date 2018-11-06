using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;
using RandomDataGenerator.Net.TextData;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerCountry : RandomizerAbstract<FieldOptionsCountry>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _generator;

        public RandomizerCountry(FieldOptionsCountry options): base(options)
        {
            _generator = new RandomStringFromListGenerator(Texts.Instance.CountryNames);
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.Generate();
        }
    }
}