
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsFullName : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool Male { get; set; } = true;

        public bool Female { get; set; } = true;

        public bool Left2Right { get; set; } = true;
    }
}