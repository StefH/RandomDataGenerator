
namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsTextLipsum : FieldOptionsAbstract, IFieldOptionsString
    {
        public int Paragraphs { get; set; } = 1;
    }
}