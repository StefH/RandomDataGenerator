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
        private const string Prefix = "RandomDataGenerator.FieldOptions.FieldOptions";

        public static FieldOptionsAbstract GetFieldOptions(SubFieldType subFieldType)
        {
            Type type = Type.GetType($"{Prefix}{subFieldType}", true);

            return (FieldOptionsAbstract)Activator.CreateInstance(type);
        }

        public static FieldOptionsAbstract GetFieldOptions([NotNull] string name, [NotNull] Dictionary<string, object> properties)
        {
            Check.NotNullOrEmpty(name, nameof(name));
            Check.NotNull(properties, nameof(properties));

            Type type = Type.GetType($"{Prefix}{name}", true);
            var fieldOptionsProperties = type.GetAllPublicProperties();

            var fieldOptions = (FieldOptionsAbstract)Activator.CreateInstance(type);
            foreach (PropertyInfo propertyInfo in fieldOptionsProperties)
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