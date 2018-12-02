using System.Collections.Generic;

namespace RandomDataGenerator.Generators
{
    internal class RandomStringFromListGenerator : RandomItemFromListGenerator<string>
    {
        public RandomStringFromListGenerator(IEnumerable<string> list) : base(list)
        {
        }
    }
}