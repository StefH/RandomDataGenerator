using System;

namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsDateTime : FieldOptionsAbstract, IFieldOptionsDateTime
    {
        public const string DefaultFormat = "s"; // "s" -> sortable date/time pattern

        public string Format { get; set; } = DefaultFormat;

        public DateTime From { get; set; } = DateTime.Now.Date;

        public DateTime To { get; set; } = DateTime.Now.AddYears(1).Date;

        public bool IncludeTime { get; set; } = true;
    }
}