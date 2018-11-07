using System;
using System.Globalization;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public abstract class RandomizerAbstract<TOptions> where TOptions : FieldOptionsAbstract
    {
        protected readonly Random Rnd = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), NumberStyles.HexNumber));
        protected readonly TOptions Options;

        protected RandomizerAbstract(TOptions options)
        {
            Options = options;
        }

        protected virtual bool IsNull()
        {
            return Options.UseNullValues && Rnd.Next(0, 10) == 5; // 10% chance on null
        }
    }
}