using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv6Address : RandomizerAbstract<FieldOptionsIPv6Address>, IRandomizerString
    {
        private readonly int[] defaultMin = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        private readonly int[] defaultMax = new int[] { 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff };

        private readonly RandomThingsGenerator<int>[] hextets = new RandomThingsGenerator<int>[8];

        public RandomizerIPv6Address(FieldOptionsIPv6Address options) : base(options)
        {
            int[] hextetsMin = string.IsNullOrEmpty(Options.Min) ? defaultMin : Options.Min.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();
            int[] hextetsMax = string.IsNullOrEmpty(Options.Max) ? defaultMax : Options.Max.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();

            for (int i = 0; i < 8; i++)
            {
                hextets[i] = new RandomThingsGenerator<int>(hextetsMin[i], hextetsMax[i], options.Seed);
            }
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            return string.Join(":", hextets.Select(gen => $"{gen.Generate():X4}").ToArray());
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}