using System;

namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsDateTime : FieldOptionsAbstract, IFieldOptionsDateTime
    {
        public const string DefaultFormat = "s"; // "s" -> sortable date/time pattern

        public string Format { get; set; } = DefaultFormat;

        public DateTime From { get; set; } = DateTime.UtcNow.Date;

        public DateTime To { get; set; } = DateTime.UtcNow.Date.AddYears(1);

        public bool IncludeTime { get; set; } = true;
    }
}