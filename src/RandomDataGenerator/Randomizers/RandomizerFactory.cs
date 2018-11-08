using System;
using System.Collections.Concurrent;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers
{
    public static class RandomizerFactory
    {
        private static readonly ConcurrentDictionary<string, object> Cache = new ConcurrentDictionary<string, object>();

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

#if NET20 || NET35
        public static object GetRandomizerAsDynamic(FieldOptionsAbstract fieldOptions)
        {
            return Create<object>(fieldOptions);
        }
#else
        public static dynamic GetRandomizerAsDynamic(object fieldOptions)
        {
            return Create<object>(fieldOptions);
        }
#endif
        private static T Create<T>(object fieldOptions)
        {
            string fieldOptionsFullName = fieldOptions.GetType().FullName;
            string key = fieldOptionsFullName + fieldOptions.GetHashCode();

            if (!Cache.ContainsKey(key))
            {
                // ReSharper disable once PossibleNullReferenceException
                string typeName = fieldOptionsFullName.Replace("FieldOptions.FieldOptions", "Randomizers.Randomizer");
                var type = Type.GetType(typeName, true);

                Cache.TryAdd(key, Activator.CreateInstance(type, fieldOptions));
            }

            return (T)Cache[key];
        }
    }
}