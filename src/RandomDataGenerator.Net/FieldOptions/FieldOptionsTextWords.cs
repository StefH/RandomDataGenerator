
namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsTextWords : FieldOptionsAbstract, IFieldOptionsString
    {
        public int Min { get; set; } = 1;

        public int Max { get; set; } = 99;
    }
}