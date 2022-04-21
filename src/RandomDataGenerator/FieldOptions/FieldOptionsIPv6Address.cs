
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsIPv6Address : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool Uppercase { get; set; }

        public string? Min { get; set; }

        public string? Max { get; set; }
    }
}