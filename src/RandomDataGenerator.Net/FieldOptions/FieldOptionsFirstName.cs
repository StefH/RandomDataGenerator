namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsFirstName : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool Male { get; set; } = true;

        public bool Female { get; set; } = true;
    }
}