using System;
using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;

namespace RandomDataGenerator.Net.Randomizers
{
    public class RandomizerDateTime : RandomizerAbstract<FieldOptionsDateTime>, IRandomizerDateTime
    {
        private const string Format = "yyyy-M-dd hh:mm:ss";
        private readonly RandomDateTimeGenerator _generator;

        public RandomizerDateTime(FieldOptionsDateTime options)
            : base(options)
        {
            _generator = new RandomDateTimeGenerator(options.DateFrom, options.DateTo);
        }

        public DateTime? GetData()
        {
            if (IsNull())
            {
                return null;
            }

            DateTime value = _generator.Generate();
            return Options.IncludeTime ? value : value.Date;
        }

        public string GetDataAsString()
        {
            DateTime? date = GetData();
            return date?.ToString(Format);
        }
    }
}