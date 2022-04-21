using System.Collections.Generic;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerFirstName : RandomizerAbstract<FieldOptionsFirstName>, IRandomizerString
{
    private readonly RandomThingsGenerator<int> _numberGenerator;
    private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

    public RandomizerFirstName(FieldOptionsFirstName options) : base(options)
    {
        if (options.Male)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.MaleNames));
        }

        if (options.Female)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.FemaleNames));
        }

        _numberGenerator = new RandomThingsGenerator<int>(0, _genderSetGenerators.Count, options.Seed);
    }

    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int maleOrFemale = _numberGenerator.Generate();

        return _genderSetGenerators[maleOrFemale].Generate();
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}