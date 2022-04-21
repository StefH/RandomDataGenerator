#if !NETSTANDARD1_3
using System.Xml.Serialization;
#endif

namespace RandomDataGenerator.FieldOptions
{
#if !NETSTANDARD1_3
    [XmlInclude(typeof(FieldOptionsBytes))]
    [XmlInclude(typeof(FieldOptionsCCN))]
    [XmlInclude(typeof(FieldOptionsCity))]
    [XmlInclude(typeof(FieldOptionsCountry))]
    [XmlInclude(typeof(FieldOptionsDateTime))]
    [XmlInclude(typeof(FieldOptionsEmailAddress))]
    [XmlInclude(typeof(FieldOptionsFirstName))]
    [XmlInclude(typeof(FieldOptionsIBAN))]
    [XmlInclude(typeof(FieldOptionsNumber<byte>))]
    [XmlInclude(typeof(FieldOptionsNumber<short>))]
    [XmlInclude(typeof(FieldOptionsNumber<int>))]
    [XmlInclude(typeof(FieldOptionsNumber<long>))]
    [XmlInclude(typeof(FieldOptionsNumber<float>))]
    [XmlInclude(typeof(FieldOptionsNumber<double>))]
    [XmlInclude(typeof(FieldOptionsFullName))]
    [XmlInclude(typeof(FieldOptionsGuid))]
    [XmlInclude(typeof(FieldOptionsInteger))]
    [XmlInclude(typeof(FieldOptionsIPv4Address))]
    [XmlInclude(typeof(FieldOptionsIPv6Address))]
    [XmlInclude(typeof(FieldOptionsLastName))]
    [XmlInclude(typeof(FieldOptionsMACAddress))]
    [XmlInclude(typeof(FieldOptionsTextPattern))]
    [XmlInclude(typeof(FieldOptionsTextRegex))]
    [XmlInclude(typeof(FieldOptionsTextNaughtyStrings))]
    [XmlInclude(typeof(FieldOptionsText))]
    [XmlInclude(typeof(FieldOptionsTextWords))]
    [XmlInclude(typeof(FieldOptionsStringList))]
#endif
    public abstract class FieldOptionsAbstract
    {
        public bool UseNullValues { get; set; }

        public bool ValueAsString { get; set; }

        public int? Seed { get; set; }

        public FieldOptionsAbstract Clone()
        {
            return (FieldOptionsAbstract)MemberwiseClone();
        }
    }
}