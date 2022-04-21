
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsIPv4Address : FieldOptionsAbstract, IFieldOptionsString
    {
        public string? Min { get; set; }

        public string? Max { get; set; }
    }
}