using System.Collections.Generic;
using System.Linq;
using NLipsum.Core;
using RandomDataGenerator.Net.Extensions;
using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;
using RandomDataGenerator.Net.TextData;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerEmailAddress : RandomizerAbstract<FieldOptionsEmailAddress>, IRandomizerString
    {
        private readonly RandomIntegerGenerator _integerGenerator;
        private readonly LipsumGenerator _generator = new LipsumGenerator();
        private readonly RandomStringFromListGenerator _topLevelDomainsGenerator;
        private readonly RandomStringFromListGenerator _lastNamesGenerator;
        private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

        public RandomizerEmailAddress(FieldOptionsEmailAddress options)
            : base(options)
        {
            _lastNamesGenerator = new RandomStringFromListGenerator(Texts.Instance.LastNames.Select(l => l.ToLower()));
            _topLevelDomainsGenerator = new RandomStringFromListGenerator(Texts.Instance.TopLevelDomains.Select(l => l.ToLower()));

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

        public string GetData()
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
            string domain = _topLevelDomainsGenerator.Generate();

            return $"{firstName}.{lastname}@{company}.{domain}";
        }
    }
}