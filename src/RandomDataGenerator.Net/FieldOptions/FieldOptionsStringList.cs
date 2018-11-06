using System.Collections.Generic;

namespace RandomDataGenerator.Net.FieldOptions
{
    public class FieldOptionsStringList : FieldOptionsAbstract, IFieldOptions
    {
        public List<string> Values { get; set; } = new List<string>();
    }
}