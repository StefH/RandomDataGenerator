using System;
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

            string guid = Guid.NewGuid().ToString();
            return Options.Uppercase ? guid.ToUpperInvariant() : guid.ToLowerInvariant();
        }
    }
}