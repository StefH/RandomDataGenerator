using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using System;
using System.Text;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerBytes : RandomizerAbstract<FieldOptionsBytes>, IRandomizerBytes
    {
        public RandomizerBytes(FieldOptionsBytes options)
            : base(options)
        {
        }

        public byte[] Generate()
        {
            return RandomValueGenerator.NextBytes(Options.Min, Options.Max);
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