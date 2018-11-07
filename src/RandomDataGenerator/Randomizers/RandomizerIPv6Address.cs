using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    class RandomizerIPv6Address : RandomizerAbstract<FieldOptionsIPv6Address>, IRandomizerString
    {
        private readonly RandomIntegerGenerator _generator = new RandomIntegerGenerator(0, 0xffff);

        public RandomizerIPv6Address(FieldOptionsIPv6Address options)
            : base(options)
        {
        }

        public string Generate()
        {
            // Example 2001:0:5ef5:79fd:38e2:30c1:ad54:e6f8
            return IsNull() ? null : $"2001:0:{_generator.Generate():X}:{_generator.Generate():X}:{_generator.Generate():X}:{_generator.Generate():X}:{_generator.Generate():X}:{_generator.Generate():X}";
        }
    }
}