using System.Text;
using JetBrains.Annotations;

namespace RandomDataGenerator.Randomizers
{
    public interface IRandomizerBytes
    {
        byte[] Generate();

        string GenerateAsUTF8String();

        string GenerateAsASCIIString();

        string GenerateAsBase64String();

        string GenerateAsString([CanBeNull] Encoding encoding = null);
    }
}