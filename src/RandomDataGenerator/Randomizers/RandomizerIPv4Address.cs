using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using System.Linq;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIPv4Address : RandomizerAbstract<FieldOptionsIPv4Address>, IRandomizerString
    {
        public RandomizerIPv4Address(FieldOptionsIPv4Address options)
            : base(options)
        {
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            int[] octetsMin = string.IsNullOrEmpty(Options.Min) ? new[] { 0, 0, 0, 0 } : Options.Min.Split('.').Select(x => int.Parse(x)).ToArray();
            int[] octetsMax = string.IsNullOrEmpty(Options.Max) ? new[] { 0xff, 0xff, 0xff, 0xff } : Options.Max.Split('.').Select(x => int.Parse(x)).ToArray();

            int rnd0 = new RandomThingsGenerator<int>(octetsMin[0], octetsMax[0]).Generate();
            int rnd1 = new RandomThingsGenerator<int>(octetsMin[1], octetsMax[1]).Generate();
            int rnd2 = new RandomThingsGenerator<int>(octetsMin[2], octetsMax[2]).Generate();
            int rnd3 = new RandomThingsGenerator<int>(octetsMin[3], octetsMax[3]).Generate();

            return $"{rnd0}:{rnd1}:{rnd2}:{rnd3}";
        }
    }
}