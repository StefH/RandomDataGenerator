using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerMACAddress : RandomizerAbstract<FieldOptionsMACAddress>, IRandomizerString
    {
        private readonly RandomThingsGenerator<byte>[] octets = new RandomThingsGenerator<byte>[6];

        public RandomizerMACAddress(FieldOptionsMACAddress options) : base(options)
        {
            byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? new byte[] { 0, 0, 0, 0, 0, 0 } : Options.Min.Split(':').Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();
            byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff } : Options.Max.Split(':').Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();

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
            string value = string.Join(Options.AddColons ? ":" : string.Empty, octets.Select(gen => $"{gen.Generate():X2}").ToArray());

            return value.ToCasedInvariant(Options.Uppercase);
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}