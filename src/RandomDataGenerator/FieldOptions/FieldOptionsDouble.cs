
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsDouble : FieldOptionsNumber<double>
    {
        public override double Min { get; set; }

        public override double Max { get; set; } = double.MaxValue;
    }
}