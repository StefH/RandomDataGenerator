using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

public static class RandomizerFactory
{
    private static readonly ConcurrentDictionary<string, object> Cache = new();

    public static IRandomizerBytes GetRandomizer(IFieldOptionsBytes fieldOptions)
    {
        return Create<IRandomizerBytes>(fieldOptions);
    }

    public static IRandomizerString GetRandomizer(IFieldOptionsString fieldOptions)
    {
        return Create<IRandomizerString>(fieldOptions);
    }

    public static IRandomizerGuid GetRandomizer(IFieldOptionsGuid fieldOptions)
    {
        return Create<IRandomizerGuid>(fieldOptions);
    }

    public static IRandomizerNumber<T> GetRandomizer<T>(IFieldOptionsNumber<T> fieldOptions) where T : struct
    {
        return Create<IRandomizerNumber<T>>(fieldOptions);
    }

    public static IRandomizerDateTime GetRandomizer(IFieldOptionsDateTime fieldOptions)
    {
        return Create<IRandomizerDateTime>(fieldOptions);
    }

    public static IRandomizerTimeSpan GetRandomizer(IFieldOptionsTimeSpan fieldOptions)
    {
        return Create<IRandomizerTimeSpan>(fieldOptions);
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
        string key = $"{fieldOptions.GetType().FullName}_{fieldOptions.GetHashCode()}";

        if (!Cache.ContainsKey(key))
        {
            Cache.TryAdd(key, CreateRandomizer(fieldOptions));
        }

        return (T)Cache[key];
    }

    private static object CreateRandomizer(object fieldOptions)
    {
        Type fieldOptionsType = fieldOptions.GetType();
        string fieldOptionsFullName = fieldOptionsType.FullName ?? string.Empty;

        string typeName;
        if (fieldOptionsType.GetTypeInfo().BaseType?.Name.EndsWith("Number`1") == true)
        {
            var genericType = fieldOptionsType.GetTypeInfo().BaseType.GetTypeInfo().GetGenericTypeArguments().FirstOrDefault();
            if (RandomValueGenerator.SupportedTypes.Contains(genericType))
            {
                typeName = fieldOptionsFullName.Replace($"FieldOptions.{fieldOptionsType.Name}", $"Randomizers.RandomizerNumber`1[{genericType}]");
            }
            else
            {
                throw new NotSupportedException($"The type '{genericType}' is not supported.");
            }
        }
        else
        {
            typeName = fieldOptionsFullName.Replace("FieldOptions.FieldOptions", "Randomizers.Randomizer");
        }

        var type = Type.GetType(typeName, true);
        return Activator.CreateInstance(type!, fieldOptions);
    }
}