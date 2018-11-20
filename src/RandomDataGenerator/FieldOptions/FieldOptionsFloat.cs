
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsFloat : FieldOptionsNumber<float>
    {
        public override float Min { get; set; }

        public override float Max { get; set; } = float.MaxValue;
    }
}