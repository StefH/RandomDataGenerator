using System.ComponentModel;

namespace RandomDataGenerator.Enums
{
    public enum FieldType
    {
        None,

        [Description("Numbers")]
        Numbers,

        [Description("IT")]
        IT,

        [Description("Human")]
        Human,

        [Description("Location")]
        Location,

        [Description("Text")]
        Text,

        [Description("Time")]
        Time,

        [Description("Set")]
        Set
    }
}