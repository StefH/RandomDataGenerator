using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using System.Linq;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv4Address : RandomizerAbstract<FieldOptionsIPv4Address>, IRandomizerString
    {
        private readonly RandomThingsGenerator<byte> octet0;
        private readonly RandomThingsGenerator<byte> octet1;
        private readonly RandomThingsGenerator<byte> octet2;
        private readonly RandomThingsGenerator<byte> octet3;

        public RandomizerIPv4Address(FieldOptionsIPv4Address options) : base(options)
        {
            byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? new byte[] { 0, 0, 0, 0 } : Options.Min.Split('.').Select(x => byte.Parse(x)).ToArray();
            byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? new byte[] { 0xff, 0xff, 0xff, 0xff } : Options.Max.Split('.').Select(x => byte.Parse(x)).ToArray();

            octet0 = new RandomThingsGenerator<byte>(octetsMin[0], octetsMax[0]);
            octet1 = new RandomThingsGenerator<byte>(octetsMin[1], octetsMax[1]);
            octet2 = new RandomThingsGenerator<byte>(octetsMin[2], octetsMax[2]);
            octet3 = new RandomThingsGenerator<byte>(octetsMin[3], octetsMax[3]);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            return $"{octet0.Generate()}:{octet1.Generate()}:{octet2.Generate()}:{octet3.Generate()}";
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}