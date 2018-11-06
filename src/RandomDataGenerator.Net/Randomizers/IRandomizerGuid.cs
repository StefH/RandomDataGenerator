using System;

namespace RandomDataGenerator.Net.Randomizers
{
    public interface IRandomizerGuid
    {
        Guid? GetData();

        string GetDataAsString();
    }
}