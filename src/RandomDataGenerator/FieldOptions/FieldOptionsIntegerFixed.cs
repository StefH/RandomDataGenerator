namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsIntegerFixed : FieldOptionsAbstract, IFieldOptionsInteger
    {
        public int Value { get; set; } = 42;
    }
}