using System.Collections.Generic;
using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;
using RandomDataGenerator.Net.TextData;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerFullName : RandomizerAbstract<FieldOptionsFullName>, IRandomizerString
    {
        private readonly RandomIntegerGenerator _integerGenerator;
        private readonly RandomStringFromListGenerator _lastNamesGenerator;
        private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

        public RandomizerFullName(FieldOptionsFullName options)
            : base(options)
        {
            _lastNamesGenerator = new RandomStringFromListGenerator(Texts.Instance.LastNames);

            if (options.Male)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.MaleNames));
            }

            if (options.Female)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.FemaleNames));
            }

            _integerGenerator = new RandomIntegerGenerator(0, _genderSetGenerators.Count);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            int maleOrFemale = _integerGenerator.Generate();

            var firstNamesSet = _genderSetGenerators[maleOrFemale];
            string firstName = firstNamesSet.Generate();
            string lastname = _lastNamesGenerator.Generate();

            return $"{firstName} {lastname}";
        }
    }
}