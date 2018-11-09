using System;

namespace RandomDataGenerator.FieldOptions
{
    public interface IFieldOptionsDateTime
    {
        DateTime From { get; set; }

        DateTime To { get; set; }

        bool IncludeTime { get; set; }
    }
}
