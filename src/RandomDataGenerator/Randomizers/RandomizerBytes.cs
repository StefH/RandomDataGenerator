using System;
using System.Text;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerBytes : RandomizerAbstract<FieldOptionsBytes>, IRandomizerBytes
    {
        private readonly RandomValueGenerator c = new RandomValueGenerator();

        public RandomizerBytes(FieldOptionsBytes options)
            : base(options)
        {
        }

        public byte[] Generate()
        {
            return c.NextBytes(Options.Min, Options.Max);
        }

        public string GenerateAsString(Encoding encoding)
        {
            return (encoding ?? Encoding.UTF8).GetString(Generate());
        }

        public string GenerateAsUTF8String()
        {
            return GenerateAsString(Encoding.UTF8);
        }

        public string GenerateAsASCIIString()
        {
            return GenerateAsString(Encoding.ASCII);
        }

        public string GenerateAsBase64String()
        {
            return Convert.ToBase64String(Generate());
        }
    }
}