using System;
using System.Globalization;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerDateTime : RandomizerAbstract<FieldOptionsDateTime>, IRandomizerDateTime
{
    private readonly RandomThingsGenerator<DateTime> _generator;

    public RandomizerDateTime(FieldOptionsDateTime options)
        : base(options)
    {
        _generator = new RandomThingsGenerator<DateTime>(options.From, options.To, options.Seed);
    }

    public DateTime? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        DateTime value = _generator.Generate();
        return Options.IncludeTime ? value : value.Date;
    }

    public string? GenerateAsString()
    {
        DateTime? date = Generate();

        string format = !string.IsNullOrEmpty(Options.Format) ? Options.Format : FieldOptionsDateTime.DefaultFormat;
        return date?.ToString(format, CultureInfo.InvariantCulture);
    }
}