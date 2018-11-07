using System.Collections.Generic;
using System.Linq;
using NLipsum.Core;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerEmailAddress : RandomizerAbstract<FieldOptionsEmailAddress>, IRandomizerString
    {
        private readonly LipsumGenerator _generator = new LipsumGenerator();
        private readonly RandomIntegerGenerator _integerGenerator;
        private readonly RandomStringFromListGenerator _topLevelDomainGenerator;
        private readonly RandomStringFromListGenerator _lastNamesGenerator;
        private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

        public RandomizerEmailAddress(FieldOptionsEmailAddress options)
            : base(options)
        {
            _lastNamesGenerator = new RandomStringFromListGenerator(Texts.Instance.LastNames.Select(l => l.ToLower()));
            _topLevelDomainGenerator = new RandomStringFromListGenerator(Texts.Instance.TopLevelDomains.Select(l => l.ToLower()));

            if (options.Male)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.MaleNames.Select(l => l.ToLower())));
            }

            if (options.Female)
            {
                _genderSetGenerators.Add(new RandomStringFromListGenerator(Texts.Instance.FemaleNames.Select(l => l.ToLower())));
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
            string company = _generator.GenerateWord();
            string domain = _topLevelDomainGenerator.Generate();

            return $"{firstName}.{lastname}@{company}.{domain}";
        }
    }
}