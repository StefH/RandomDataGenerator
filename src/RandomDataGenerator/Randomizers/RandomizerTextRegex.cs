using Fare;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerTextRegex : RandomizerAbstract<FieldOptionsTextRegex>, IRandomizerString
    {
        private readonly Xeger _generator;

        public RandomizerTextRegex(FieldOptionsTextRegex options) : base(options)
        {
            _generator = new Xeger(Options.Pattern);
        }

        public string Generate()
        {
            return IsNull() || string.IsNullOrEmpty(Options.Pattern) ? null : _generator.Generate();
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}