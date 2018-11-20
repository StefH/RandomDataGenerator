using System;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerGuid : RandomizerAbstract<FieldOptionsGuid>, IRandomizerGuid
    {
        public RandomizerGuid(FieldOptionsGuid options) : base(options)
        {
        }

        public Guid? Generate()
        {
            if (IsNull())
            {
                return null;
            }

            return Guid.NewGuid();
        }

        public string GenerateAsString()
        {
            if (IsNull())
            {
                return null;
            }

            return Guid.NewGuid().ToString().ToCasedInvariant(Options.Uppercase);
        }
    }
}