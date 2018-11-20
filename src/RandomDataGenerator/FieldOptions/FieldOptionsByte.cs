
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsByte : FieldOptionsNumber<byte>
    {
        public override byte Min { get; set; }

        public override byte Max { get; set; } = byte.MaxValue;
    }
}