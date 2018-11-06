using System;

namespace RandomDataGenerator.Net.Randomizers
{
    public interface IRandomizerGuid
    {
        Guid? Generate();

        string GenerateAsString();
    }
}