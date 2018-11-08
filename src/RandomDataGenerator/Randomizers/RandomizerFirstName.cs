using System.Collections.Generic;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerFirstName : RandomizerAbstract<FieldOptionsFirstName>, IRandomizerString
    {
        private readonly RandomThingsGenerator<int> _numberGenerator;
        private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

        public RandomizerFirstName(FieldOptionsFirstName options)
            : base(options)
        {
            if (options.Male)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.MaleNames));
            }

            if (options.Female)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.FemaleNames));
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

            return _genderSetGenerators[maleOrFemale].Generate();
        }
    }
}