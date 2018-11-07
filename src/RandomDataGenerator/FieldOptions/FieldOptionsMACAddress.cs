
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsMACAddress : FieldOptionsAbstract, IFieldOptionsString
    {
        public bool AddColons { get; set; } = true;

        public bool Uppercase { get; set; } = true;
    }
}