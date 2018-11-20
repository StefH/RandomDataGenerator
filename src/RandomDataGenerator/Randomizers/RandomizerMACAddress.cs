using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerMACAddress : RandomizerAbstract<FieldOptionsMACAddress>, IRandomizerString
    {
        private readonly byte[] defaultMin = new byte[] { 0, 0, 0, 0, 0, 0 };
        private readonly byte[] defaultMax = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };

        private readonly RandomThingsGenerator<byte>[] octets = new RandomThingsGenerator<byte>[6];

        public RandomizerMACAddress(FieldOptionsMACAddress options) : base(options)
        {
            byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? defaultMin : Options.Min.Split(Options.Separator.First()).Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();
            byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? defaultMax : Options.Max.Split(Options.Separator.First()).Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();

            for (int i = 0; i < 6; i++)
            {
                octets[i] = new RandomThingsGenerator<byte>(octetsMin[i], octetsMax[i]);
            }
        }

        public string Generate()
        {
            return IsNull() ? null : GenerateInternal();
        }

        private string GenerateInternal()
        {
            string value = string.Join(Options.Separator, octets.Select(gen => $"{gen.Generate():X2}").ToArray());

            return value.ToCasedInvariant(Options.Uppercase);
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}