
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsGuid : FieldOptionsAbstract, IFieldOptionsGuid
    {
        public bool Uppercase { get; set; } = true;

        public string Format { get; set; } = "D";
    }
}