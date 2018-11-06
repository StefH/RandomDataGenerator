
namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsEmailAddress : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool Male { get; set; } = true;

        public bool Female { get; set; } = true;

        public bool Left2Right { get; set; } = true;
    }
}