using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerMACAddress : RandomizerAbstract<FieldOptionsMACAddress>, IRandomizerString
    {
        private readonly RandomThingsGenerator<int> _generator = new RandomThingsGenerator<int>(0, 0xff);

        public RandomizerMACAddress(FieldOptionsMACAddress options)
            : base(options)
        {
        }

        public string Generate()
        {
            return IsNull() ? null : GenerateInternal();
        }

        private string GenerateInternal()
        {
            var list = new string[6];
            for (int idx = 0; idx < list.Length; idx++)
            {
                list[idx] = $"{_generator.Generate():x2}";
            }

            string value = string.Join(Options.AddColons ? ":" : string.Empty, list);

            return value.ToCasedInvariant(Options.Uppercase);
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}