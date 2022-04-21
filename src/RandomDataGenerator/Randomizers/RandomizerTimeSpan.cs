using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public class RandomizerTimeSpan : RandomizerAbstract<FieldOptionsTimeSpan>, IRandomizerTimeSpan
{
    private readonly RandomThingsGenerator<TimeSpan> _generator;

    public RandomizerTimeSpan(FieldOptionsTimeSpan options) : base(options)
    {
        _generator = new RandomThingsGenerator<TimeSpan>(options.From, options.To, options.Seed);
    }

    public TimeSpan? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        var ts = _generator.Generate();

        return Options.IncludeMilliseconds ? ts : new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
    }

    public string? GenerateAsString()
    {
        TimeSpan? ts = Generate();

        string format = !string.IsNullOrEmpty(Options.Format) ? Options.Format : FieldOptionsTimeSpan.DefaultFormat;
        return ts != null ? string.Format($"{{0:{format}}}", ts) : null;
    }
}