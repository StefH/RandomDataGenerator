using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerLastName : RandomizerAbstract<FieldOptionsLastName>, IRandomizerString
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

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}