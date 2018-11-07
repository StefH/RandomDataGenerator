using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv4Address : RandomizerAbstract<FieldOptionsIPv4Address>, IRandomizerString
    {
        private readonly RandomIntegerGenerator _firstOctet = new RandomIntegerGenerator(1, 0xff);
        private readonly RandomIntegerGenerator _otherOctets = new RandomIntegerGenerator(0, 0xff);

        public RandomizerIPv4Address(FieldOptionsIPv4Address options)
            : base(options)
        {
        }

        public string Generate()
        {
            return IsNull() ? null : $"{_firstOctet.Generate()}:{_otherOctets.Generate()}:{_otherOctets.Generate()}:{_otherOctets.Generate()}";
        }
    }
}