
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsLong : FieldOptionsNumber<long>
    {
        public override long Min { get; set; }

        public override long Max { get; set; } = 999999999999;
    }
}