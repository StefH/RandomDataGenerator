
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsBytes : FieldOptionsAbstract, IFieldOptionsBytes
    {
        public int Min { get; set; }

        public int Max { get; set; } = 1024;
    }
}