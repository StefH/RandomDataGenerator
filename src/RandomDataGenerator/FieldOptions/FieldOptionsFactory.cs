using System;
using RandomDataGenerator.Enums;

namespace RandomDataGenerator.FieldOptions
{
    public static class FieldOptionsFactory
    {
        public static FieldOptionsAbstract GetFieldOptions(SubFieldType subFieldType)
        {
            string typeName = $"RandomDataGenerator.FieldOptions.FieldOptions{subFieldType}";
            Type type = Type.GetType(typeName);

            // ReSharper disable once AssignNullToNotNullAttribute
            return (FieldOptionsAbstract)Activator.CreateInstance(type);
        }
    }
}