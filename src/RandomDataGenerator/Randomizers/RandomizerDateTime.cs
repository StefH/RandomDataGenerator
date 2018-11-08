using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerDateTime : RandomizerAbstract<FieldOptionsDateTime>, IRandomizerDateTime
    {
        private const string Format = "yyyy-M-dd hh:mm:ss";
        private readonly RandomThingsGenerator<DateTime> _generator;

        public RandomizerDateTime(FieldOptionsDateTime options)
            : base(options)
        {
            _generator = new RandomThingsGenerator<DateTime>(options.DateFrom, options.DateTo);
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

        public string GenerateAsString()
        {
            DateTime? date = Generate();
            return date?.ToString(Format);
        }
    }
}