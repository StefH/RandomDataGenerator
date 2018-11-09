
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsFloat : FieldOptionsNumber<float>
    {
        public override float Min { get; set; }

        public override float Max { get; set; } = 99999999.0F;
    }
}