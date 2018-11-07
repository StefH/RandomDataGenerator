using System.Xml.Serialization;

namespace RandomDataGenerator.FieldOptions
{
#if !NETSTANDARD1_3
    [XmlInclude(typeof(FieldOptionsCity))]
    [XmlInclude(typeof(FieldOptionsCountry))]
    [XmlInclude(typeof(FieldOptionsDateTime))]
    [XmlInclude(typeof(FieldOptionsEmailAddress))]
    [XmlInclude(typeof(FieldOptionsFirstName))]
    [XmlInclude(typeof(FieldOptionsIntegerFixed))]
    [XmlInclude(typeof(FieldOptionsFullName))]
    [XmlInclude(typeof(FieldOptionsGuid))]
    [XmlInclude(typeof(FieldOptionsInteger))]
    [XmlInclude(typeof(FieldOptionsIPv4Address))]
    [XmlInclude(typeof(FieldOptionsIPv6Address))]
    [XmlInclude(typeof(FieldOptionsLastName))]
    [XmlInclude(typeof(FieldOptionsMACAddress))]
    [XmlInclude(typeof(FieldOptionsTextPattern))]
    [XmlInclude(typeof(FieldOptionsText))]
    [XmlInclude(typeof(FieldOptionsTextWords))]
    [XmlInclude(typeof(FieldOptionsStringList))]
#endif
    public abstract class FieldOptionsAbstract
    {
        public bool UseNullValues { get; set; }

        public bool ValueAsString { get; set; }

        public FieldOptionsAbstract Clone()
        {
            return (FieldOptionsAbstract)MemberwiseClone();
        }
    }
}