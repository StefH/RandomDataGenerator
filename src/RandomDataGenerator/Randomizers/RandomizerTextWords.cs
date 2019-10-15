using System;
using System.Linq;
using System.Text;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
    {
        private readonly RandomStringFromListGenerator _generator;
        private readonly RandomValueGenerator _randomValueGenerator;

        public RandomizerTextWords(FieldOptionsTextWords options) : base(options)
        {
            _randomValueGenerator = new RandomValueGenerator(Options.Seed ?? Environment.TickCount);

            var words = ListData.Instance.LoremIpsum.SelectMany(l => l.Split(' '));
            _generator = new RandomStringFromListGenerator(words, options.Seed);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            int max = _randomValueGenerator.Next(Options.Min, Options.Max);
            var sb = new StringBuilder(Options.Max);
            for (int i = 0; i < Options.Max - Options.Min + 1; i++)
            {
                sb.Append(_generator.Generate());
            }

            return sb.ToString();
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}