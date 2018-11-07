using System;
using NLipsum.Core;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
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