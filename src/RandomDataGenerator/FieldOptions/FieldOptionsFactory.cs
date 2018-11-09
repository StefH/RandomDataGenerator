using System;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;
using RandomDataGenerator.Enums;
using RandomDataGenerator.Validation;

namespace RandomDataGenerator.FieldOptions
{
    public static class FieldOptionsFactory
    {
        private const string Namespace = "RandomDataGenerator.FieldOptions";

        public static FieldOptionsAbstract GetFieldOptions(SubFieldType subFieldType)
        {
            Type type = Type.GetType($"{Namespace}.FieldOptions{subFieldType}", true);

            return (FieldOptionsAbstract)Activator.CreateInstance(type);
        }

        public static FieldOptionsAbstract GetFieldOptions([NotNull] string name, [NotNull] Dictionary<string, object> properties)
        {
            Check.NotNullOrEmpty(name, nameof(name));
            Check.NotNull(properties, nameof(properties));

            // Generate classname
            string className = !name.StartsWith("FieldOptions") ? $"FieldOptions{name}" : name;

            // Create type based on classname
            Type type = Type.GetType($"{Namespace}.{className}", true);
            var fieldOptions = (FieldOptionsAbstract)Activator.CreateInstance(type);

            // Loop all settable properties and set value if it's defined as an argument
            foreach (PropertyInfo propertyInfo in type.GetPublicSettableProperties())
            {
                bool exists = properties.ContainsKey(propertyInfo.Name);
                if (exists)
                {
                    propertyInfo.SetValue(fieldOptions, properties[propertyInfo.Name], null);
                }
            }

            return fieldOptions;
        }
    }
}