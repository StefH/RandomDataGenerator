using System.ComponentModel;

namespace RandomDataGenerator.Enums
{
    public enum SubFieldType
    {
        None,

        // Numbers
        [Description("Integer")]
        Integer,

        [Description("Integer Fixed")]
        IntegerFixed,


        // IT
        [Description("IPv4 Address")]
        IPv4Address,

        [Description("IPv6 Address")]
        IPv6Address,

        [Description("MAC Address")]
        MACAddress,

        [Description("Guid")]
        Guid,

        // Human
        [Description("Full Name")]
        FullName,

        [Description("Last Name")]
        LastName,

        [Description("First Name")]
        FirstName,

        [Description("Email Address")]
        EmailAddress,

        
        // Location
        [Description("Country")]
        Country,

        [Description("City")]
        City,


        // Text
        [Description("Words")]
        TextWords,

        [Description("Random Pattern")]
        TextPattern,

        [Description("Random Length")]
        TextRandomLength,

        [Description("Date / Time")]
        DateTime,

        // Set
        [Description("String List")]
        StringList
    }
}