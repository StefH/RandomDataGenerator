
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsInteger : FieldOptionsNumber<int>
    {
        public override int Min { get; set; }

        public override int Max { get; set; } = int.MaxValue;
    }
}