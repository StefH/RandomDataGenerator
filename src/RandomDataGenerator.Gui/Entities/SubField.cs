using System.Xml.Serialization;
using RandomDataGenerator.Enums;
using RandomDataGenerator.Gui.Extensions;

namespace RandomDataGenerator.Gui.Entities
{
    public class SubField
    {
        [XmlIgnore]
        public string Name => SubFieldType.GetEnumDescription();

        public SubFieldType SubFieldType { get; set; }
    }
}