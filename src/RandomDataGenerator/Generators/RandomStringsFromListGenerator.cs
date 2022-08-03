using System.Collections.Generic;

namespace RandomDataGenerator.Generators;

internal class RandomStringsFromListGenerator : RandomItemsFromListGenerator<string>
{
    public RandomStringsFromListGenerator(IEnumerable<string> list, int? seed = null) : base(seed, list)
    {
    }
}