using System.Collections.Generic;

namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsStringList : FieldOptionsAbstract, IFieldOptions
    {
        public List<string> Values { get; set; } = new List<string>();
    }
}