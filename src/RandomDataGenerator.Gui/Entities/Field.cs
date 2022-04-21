using System;
using System.Xml.Serialization;
using RandomDataGenerator.Enums;
using RandomDataGenerator.Gui.Extensions;

namespace RandomDataGenerator.Gui.Entities;

public class Field
{
    [XmlIgnore]
    public string Name => FieldType.GetEnumDescription();

    public FieldType FieldType { get; set; }

    [XmlIgnore] 
    public SubField[] SubFields { get; set; } = Array.Empty<SubField>();
}