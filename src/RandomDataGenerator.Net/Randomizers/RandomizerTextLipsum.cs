using NLipsum.Core;
using RandomDataGenerator.Net.FieldOptions;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerTextLipsum : RandomizerAbstract<FieldOptionsTextLipsum>, IRandomizerString
    {
        private readonly LipsumGenerator _generator = new LipsumGenerator();

        public RandomizerTextLipsum(FieldOptionsTextLipsum options) : base(options)
        {
            
        }

        public string GetData()
        {
            return IsNull() ? null : _generator.GenerateLipsum(Options.Paragraphs);
        }
    }
}