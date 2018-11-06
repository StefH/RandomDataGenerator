using System;
using System.Collections.Concurrent;
using RandomDataGenerator.Net.FieldOptions;

namespace RandomDataGenerator.Net.Randomizers
{
    public static class RandomizerFactory
    {
        private static readonly ConcurrentDictionary<Type, object> Cache = new ConcurrentDictionary<Type, object>();

        public static IRandomizerString GetRandomizer(IFieldOptionsString fieldOptions)
        {
            return Create<IRandomizerString>(fieldOptions);
        }

        public static IRandomizerGuid GetRandomizer(IFieldOptionsGuid fieldOptions)
        {
            return Create<IRandomizerGuid>(fieldOptions);
        }

        public static IRandomizerInteger GetRandomizer(IFieldOptionsInteger fieldOptions)
        {
            return Create<IRandomizerInteger>(fieldOptions);
        }

        public static IRandomizerDateTime GetRandomizer(IFieldOptionsDateTime fieldOptions)
        {
            return Create<IRandomizerDateTime>(fieldOptions);
        }

        public static IRandomizerString GetRandomizer(IFieldOptions fieldOptions)
        {
            return Create<IRandomizerString>(fieldOptions);
        }

        private static T Create<T>(object fieldOptions)
        {
            Type key = fieldOptions.GetType();

            if (!Cache.ContainsKey(key))
            {
                // ReSharper disable once PossibleNullReferenceException
                string typeName = key.FullName.Replace("FieldOptions.FieldOptions", "Randomizers.Randomizer");
                var type = Type.GetType(typeName);

                // ReSharper disable once AssignNullToNotNullAttribute
                Cache.TryAdd(key, Activator.CreateInstance(type, fieldOptions));
            }

            return (T)Cache[key];
        }
    }
}