
namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsText : FieldOptionsAbstract, IFieldOptionsString
    {
        public int Min { get; set; } = 8;
        public int Max { get; set; } = 8;
        public bool UseUppercase { get; set; } = true;
        public bool UseLowercase { get; set; } = true;
        public bool UseLetter { get; set; } = true;
        public bool UseNumber { get; set; } = true;
        public bool UseSpace { get; set; } = true;
        public bool UseSpecial { get; set; } = true;
    }
}