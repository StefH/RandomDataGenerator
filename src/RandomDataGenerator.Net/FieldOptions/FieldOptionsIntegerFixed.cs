namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsIntegerFixed : FieldOptionsAbstract, IFieldOptionsInteger
    {
        public int Value { get; set; } = 42;
    }
}