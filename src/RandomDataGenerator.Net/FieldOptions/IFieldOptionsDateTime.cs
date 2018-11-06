using System;

namespace RandomDataGenerator.Net.FieldOptions
{
    public interface IFieldOptionsDateTime
    {
        DateTime DateFrom { get; set; }

        DateTime DateTo { get; set; }

        bool IncludeTime { get; set; }
    }
}
