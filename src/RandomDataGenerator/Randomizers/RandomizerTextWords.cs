using System;
using NLipsum.Core;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
    {
        private readonly LipsumGenerator _generator = new LipsumGenerator();
        private readonly RandomThingsGenerator<int> _numberGenerator;

        public RandomizerTextWords(FieldOptionsTextWords options) : base(options)
        {
            _numberGenerator = new RandomThingsGenerator<int>(Math.Min(options.Min, options.Max), Math.Max(options.Min, options.Max) + 1);
        }

        public string Generate()
        {
            return IsNull() ? null : string.Join(" ", _generator.GenerateWords(_numberGenerator.Generate()));
        }
        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}