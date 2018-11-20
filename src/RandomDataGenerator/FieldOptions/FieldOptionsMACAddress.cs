namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsMACAddress : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool AddColons { get; set; } = true;

        public bool Uppercase { get; set; } = true;

        public string Min { get; set; }

        public string Max { get; set; }
    }
}