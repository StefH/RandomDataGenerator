﻿using RandomDataGenerator.Net.FieldOptions;

namespace RandomDataGenerator.Net.Randomizers
{
    class RandomizerIntegerFixed : IRandomizerInteger
    {
        private readonly FieldOptionsIntegerFixed _fieldOptions;

        public RandomizerIntegerFixed(FieldOptionsIntegerFixed options)
        {
            _fieldOptions = options;
        }

        public int? GetData()
        {
            return _fieldOptions.Value;
        }
    }
}