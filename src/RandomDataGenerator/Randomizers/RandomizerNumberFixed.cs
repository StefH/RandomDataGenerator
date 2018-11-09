using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerNumberFixed<T> : IRandomizerNumber<T> where T : struct
    {
        private readonly FieldOptionsNumberFixed<T> _fieldOptions;

        public RandomizerNumberFixed(FieldOptionsNumberFixed<T> options)
        {
            _fieldOptions = options;
        }

        public T? Generate()
        {
            return _fieldOptions.Value;
        }
    }
}