
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsInteger : FieldOptionsAbstract, IFieldOptionsInteger
    {
        public int Min { get; set; }
        public int Max { get; set; } = 99999999;
    }
}