//using System;
//using RandomDataGenerator.Enums;

//namespace RandomDataGenerator.FieldOptions
//{
//    static class FieldOptionsFactory
//    {
//        public static FieldOptionsAbstract GetFieldOptions(SubFieldType subFieldType)
//        {
//            string typeName = $"RandomDataGenerator.FieldOptions.FieldOptions{subFieldType}";
//            var type = Type.GetType(typeName);

//            return type != null ? (FieldOptionsAbstract)Activator.CreateInstance(type) : null;
//        }
//    }
//}