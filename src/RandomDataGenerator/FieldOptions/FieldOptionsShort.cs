namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsShort : FieldOptionsNumber<short>
    {
        public override short Min { get; set; }

        public override short Max { get; set; } = short.MaxValue;
    }
}