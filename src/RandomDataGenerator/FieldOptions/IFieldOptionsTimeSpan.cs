using System;

namespace RandomDataGenerator.FieldOptions
{
    public interface IFieldOptionsTimeSpan
    {
        /// <summary>
        /// Allowed values are "c", "g" and "G".
        /// See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings
        /// </summary>
        string Format { get; set; }

        TimeSpan From { get; set; }

        TimeSpan To { get; set; }
    }
}
