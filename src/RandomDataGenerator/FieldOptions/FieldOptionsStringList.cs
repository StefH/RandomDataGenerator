using System.Collections.Generic;

namespace RandomDataGenerator.FieldOptions;

public class FieldOptionsStringList : FieldOptionsAbstract, IFieldOptionsString
{
    public List<string> Values { get; set; } = new();
}