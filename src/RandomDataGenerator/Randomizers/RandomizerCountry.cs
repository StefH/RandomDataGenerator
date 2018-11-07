using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
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