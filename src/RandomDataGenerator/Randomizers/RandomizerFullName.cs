using System.Collections.Generic;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerFullName : RandomizerAbstract<FieldOptionsFullName>, IRandomizerString
    {
        private readonly RandomThingsGenerator<int> _numberGenerator;
        private readonly RandomStringFromListGenerator _lastNamesGenerator;
        private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

        public RandomizerFullName(FieldOptionsFullName options) : base(options)
        {
            _lastNamesGenerator = new RandomStringFromListGenerator(ListData.Instance.LastNames);

            if (options.Male)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.MaleNames));
            }

            if (options.Female)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.FemaleNames));
            }

            _numberGenerator = new RandomThingsGenerator<int>(0, _genderSetGenerators.Count);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            int maleOrFemale = _numberGenerator.Generate();

            var firstNamesSet = _genderSetGenerators[maleOrFemale];
            string firstName = firstNamesSet.Generate();
            string lastname = _lastNamesGenerator.Generate();

            return $"{firstName} {lastname}";
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}