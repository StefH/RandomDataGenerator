using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerLastName : RandomizerAbstract<FieldOptionsLastName>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _lastNamesGenerator;

    public RandomizerLastName(FieldOptionsLastName options) : base(options)
    {
        _lastNamesGenerator = new RandomStringFromListGenerator(ListData.Instance.LastNames);
    }

    public string? Generate()
    {
        return IsNull() ? null : _lastNamesGenerator.Generate();
    }

    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}