using System;

namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsDateTime : FieldOptionsAbstract, IFieldOptionsDateTime
    {
        public DateTime DateFrom { get; set; } = DateTime.Now.Date;

        public DateTime DateTo { get; set; }= DateTime.Now.AddYears(1).Date;

        public bool IncludeTime { get; set; } = true;
    }
}