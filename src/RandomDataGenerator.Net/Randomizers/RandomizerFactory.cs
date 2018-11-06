using System;
using RandomDataGenerator.Net.FieldOptions;

namespace RandomDataGenerator.Net.Randomizers
{
    public static class RandomizerFactory
    {
        public static IRandomizerString GetRandomizer(IFieldOptionsString fieldOptions)
        {
            return (IRandomizerString)Create(fieldOptions);
        }

        public static IRandomizerGuid GetRandomizer(IFieldOptionsGuid fieldOptions)
        {
            return (IRandomizerGuid)Create(fieldOptions);
        }

        public static IRandomizerInteger GetRandomizer(IFieldOptionsInteger fieldOptions)
        {
            return (IRandomizerInteger)Create(fieldOptions);
        }

        public static IRandomizerDateTime GetRandomizer(IFieldOptionsDateTime fieldOptions)
        {
            return (IRandomizerDateTime)Create(fieldOptions);
        }

        public static IRandomizerString GetRandomizer(IFieldOptions fieldOptions)
        {
            return (IRandomizerString)Create(fieldOptions);
        }

        private static object Create(object fieldOptions)
        {
            // ReSharper disable once PossibleNullReferenceException
            string typeName = fieldOptions.GetType().FullName.Replace("FieldOptions.FieldOptions", "Randomizers.Randomizer");
            var type = Type.GetType(typeName);

            // ReSharper disable once AssignNullToNotNullAttribute
            return Activator.CreateInstance(type, fieldOptions);
        }
    }
}