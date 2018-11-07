using NLipsum.Core;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerTextLipsum : RandomizerAbstract<FieldOptionsTextLipsum>, IRandomizerString
    {
        private readonly LipsumGenerator _generator = new LipsumGenerator();

        public RandomizerTextLipsum(FieldOptionsTextLipsum options) : base(options)
        {
            
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.GenerateLipsum(Options.Paragraphs);
        }
    }
}