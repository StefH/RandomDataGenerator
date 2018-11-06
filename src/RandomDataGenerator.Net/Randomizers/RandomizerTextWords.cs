using System;
using NLipsum.Core;
using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
    {
        private readonly LipsumGenerator _generator = new LipsumGenerator();
        private readonly RandomIntegerGenerator _integerGenerator;

        public RandomizerTextWords(FieldOptionsTextWords options) : base(options)
        {
            _integerGenerator = new RandomIntegerGenerator(Math.Min(options.Min, options.Max), Math.Max(options.Min, options.Max) + 1);
        }

        public string Generate()
        {
            return IsNull() ? null : string.Join(" ", _generator.GenerateWords(_integerGenerator.Generate()));
        }
    }
}