﻿using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIntegerFixed : IRandomizerInteger
    {
        private readonly FieldOptionsIntegerFixed _fieldOptions;

        public RandomizerIntegerFixed(FieldOptionsIntegerFixed options)
        {
            _fieldOptions = options;
        }

        public int? Generate()
        {
            return _fieldOptions.Value;
        }
    }
}