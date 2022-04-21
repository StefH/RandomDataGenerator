using System.ComponentModel;

namespace RandomDataGenerator.Enums
{
    public enum SubFieldType
    {
        None,

        // Numbers
        [Description("Boolean")]
        Boolean,

        [Description("Short")]
        Short,

        [Description("Integer")]
        Integer,

        [Description("Long")]
        Long,

        [Description("Float")]
        Float,

        [Description("Double")]
        Double,

        [Description("CCN")]
        CCN,


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

        [Description("Text Pattern")]
        TextPattern,

        [Description("Text Regex")]
        TextRegex,

        [Description("Text Lipsum")]
        TextLipsum,

        [Description("Random Text")]
        Text,

        [Description("Naughty Strings")]
        TextNaughtyStrings,

        [Description("Date / Time")]
        DateTime,

        // Set
        [Description("String List")]
        StringList
    }
}