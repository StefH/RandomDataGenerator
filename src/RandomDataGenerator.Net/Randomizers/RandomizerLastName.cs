using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;
using RandomDataGenerator.Net.TextData;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerLastName : RandomizerAbstract<FieldOptionsLastName>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _lastNamesGenerator;

        public RandomizerLastName(FieldOptionsLastName options)
            : base(options)
        {
            _lastNamesGenerator = new RandomStringFromListGenerator(Texts.Instance.LastNames);
        }

        public string Generate()
        {
            return IsNull() ? null : _lastNamesGenerator.Generate();
        }
    }
}