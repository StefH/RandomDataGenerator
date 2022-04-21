using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerEmailAddress : RandomizerAbstract<FieldOptionsEmailAddress>, IRandomizerString
{
    private readonly RandomizerTextWords _wordGenerator;
    private readonly RandomThingsGenerator<int> _numberGenerator;
    private readonly RandomStringFromListGenerator _topLevelDomainGenerator;
    private readonly RandomStringFromListGenerator _lastNamesGenerator;
    private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

    public RandomizerEmailAddress(FieldOptionsEmailAddress options) : base(options)
    {
        _lastNamesGenerator = new RandomStringFromListGenerator(ListData.Instance.LastNames.Select(l => l.ToLower()));
        _topLevelDomainGenerator = new RandomStringFromListGenerator(ListData.Instance.TopLevelDomains.Select(l => l.ToLower()));

        if (options.Male)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.MaleNames.Select(l => l.ToLower())));
        }

        if (options.Female)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.FemaleNames.Select(l => l.ToLower())));
        }

        _numberGenerator = new RandomThingsGenerator<int>(0, _genderSetGenerators.Count, options.Seed);
        _wordGenerator = new RandomizerTextWords(new FieldOptionsTextWords { Min = 1, Max = 1});
    }

    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int maleOrFemale = _numberGenerator.Generate();
        var firstNamesSet = _genderSetGenerators[maleOrFemale];

        string firstName = firstNamesSet.Generate()!;
        string lastname = _lastNamesGenerator.Generate()!;
        string company = _wordGenerator.Generate()!;
        string domain = _topLevelDomainGenerator.Generate()!;

        return $"{firstName}.{lastname}@{company}.{domain}";
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}