using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv4Address : RandomizerAbstract<FieldOptionsIPv4Address>, IRandomizerString
    {
        private readonly RandomThingsGenerator<byte>[] octets = new RandomThingsGenerator<byte>[4];

        public RandomizerIPv4Address(FieldOptionsIPv4Address options) : base(options)
        {
            byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? new byte[] { 0, 0, 0, 0 } : Options.Min.Split('.').Select(x => byte.Parse(x)).ToArray();
            byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? new byte[] { 0xff, 0xff, 0xff, 0xff } : Options.Max.Split('.').Select(x => byte.Parse(x)).ToArray();

            for (int i = 0; i < 4; i++)
            {
                octets[i] = new RandomThingsGenerator<byte>(octetsMin[i], octetsMax[i]);
            }
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            return string.Join(":", octets.Select(gen => $"{gen.Generate()}").ToArray());
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}