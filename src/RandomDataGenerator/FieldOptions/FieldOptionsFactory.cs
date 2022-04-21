using System;
using System.Collections.Generic;
using System.Reflection;
using RandomDataGenerator.Enums;
using Stef.Validation;

namespace RandomDataGenerator.FieldOptions;

public static class FieldOptionsFactory
{
    private const string Namespace = "RandomDataGenerator.FieldOptions";

    public static FieldOptionsAbstract GetFieldOptions(SubFieldType subFieldType)
    {
        var type = Type.GetType($"{Namespace}.FieldOptions{subFieldType}", true)!;

        return (FieldOptionsAbstract)Activator.CreateInstance(type);
    }

    public static FieldOptionsAbstract GetFieldOptions(string name, Dictionary<string, object> properties)
    {
        Guard.NotNullOrEmpty(name, nameof(name));
        Guard.NotNull(properties, nameof(properties));

        // Generate classname
        var className = !name.StartsWith("FieldOptions") ? $"FieldOptions{name}" : name;

        // Create type based on classname
        var type = Type.GetType($"{Namespace}.{className}", true)!;
        var fieldOptions = (FieldOptionsAbstract)Activator.CreateInstance(type);

        // Loop all settable properties and set value if it's defined as an argument
        foreach (var propertyInfo in type.GetPublicSettableProperties())
        {
            var exists = properties.ContainsKey(propertyInfo.Name);
            if (exists)
            {
                propertyInfo.SetValue(fieldOptions, properties[propertyInfo.Name], null);
            }
        }

        return fieldOptions;
    }
}