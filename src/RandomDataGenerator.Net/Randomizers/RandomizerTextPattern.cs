using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Generators;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerTextPattern : RandomizerAbstract<FieldOptionsTextPattern>, IRandomizerString
    {
        private readonly RandomStringGenerator _generator;

        public RandomizerTextPattern(FieldOptionsTextPattern options)
            : base(options)
        {
            _generator = new RandomStringGenerator();
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.Generate(Options.Pattern);
        }
    }
}