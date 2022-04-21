namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsMACAddress : FieldOptionsAbstract, IFieldOptionsString
    {
        public string Separator { get; set; } = ":";

        public bool Uppercase { get; set; } = true;

        public string? Min { get; set; }

        public string? Max { get; set; }
    }
}