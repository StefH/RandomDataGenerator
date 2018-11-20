using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using System.Globalization;
using System.Linq;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv6Address : RandomizerAbstract<FieldOptionsIPv6Address>, IRandomizerString
    {
        private readonly int[] defaultMin = new int [] { 0, 0, 0, 0, 0, 0, 0, 0 };
        private readonly int[] defaultMax = new int[] { 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff };

        private readonly RandomThingsGenerator<int> hextet0;
        private readonly RandomThingsGenerator<int> hextet1;
        private readonly RandomThingsGenerator<int> hextet2;
        private readonly RandomThingsGenerator<int> hextet3;
        private readonly RandomThingsGenerator<int> hextet4;
        private readonly RandomThingsGenerator<int> hextet5;
        private readonly RandomThingsGenerator<int> hextet6;
        private readonly RandomThingsGenerator<int> hextet7;

        public RandomizerIPv6Address(FieldOptionsIPv6Address options) : base(options)
        {
            int[] hextetsMin = string.IsNullOrEmpty(Options.Min) ? defaultMin : Options.Min.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();
            int[] hextetsMax = string.IsNullOrEmpty(Options.Max) ? defaultMax : Options.Max.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();

            hextet0 = new RandomThingsGenerator<int>(hextetsMin[0], hextetsMax[0]);
            hextet1 = new RandomThingsGenerator<int>(hextetsMin[1], hextetsMax[1]);
            hextet2 = new RandomThingsGenerator<int>(hextetsMin[2], hextetsMax[2]);
            hextet3 = new RandomThingsGenerator<int>(hextetsMin[3], hextetsMax[3]);
            hextet4 = new RandomThingsGenerator<int>(hextetsMin[4], hextetsMax[4]);
            hextet5 = new RandomThingsGenerator<int>(hextetsMin[5], hextetsMax[5]);
            hextet6 = new RandomThingsGenerator<int>(hextetsMin[6], hextetsMax[6]);
            hextet7 = new RandomThingsGenerator<int>(hextetsMin[7], hextetsMax[7]);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            return $"{hextet0.Generate():X}:{hextet1.Generate():X}:{hextet2.Generate():X}:{hextet3.Generate():X}:{hextet4.Generate():X}:{hextet5.Generate():X}:{hextet6.Generate():X}:{hextet7.Generate():X}";
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}