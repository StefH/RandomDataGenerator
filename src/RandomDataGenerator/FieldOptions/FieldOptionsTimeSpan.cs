using System;

namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsTimeSpan : FieldOptionsAbstract, IFieldOptionsTimeSpan
    {
        public const string DefaultFormat = "c"; // "c" -> Constant (invariant) format

        public string Format { get; set; } = DefaultFormat;

        public bool IncludeMilliseconds { get; set; } = true;

        public TimeSpan From { get; set; }

        public TimeSpan To { get; set; } = TimeSpan.MaxValue;
    }
}