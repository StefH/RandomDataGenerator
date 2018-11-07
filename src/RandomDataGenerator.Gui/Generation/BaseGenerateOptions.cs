using System.Xml.Serialization;

namespace RandomDataGenerator.Gui.Generation
{
    [XmlInclude(typeof(GenerateOptionsSQL))]
    public abstract class BaseGenerateOptions
    {
    }
}