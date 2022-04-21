using System;

namespace RandomDataGenerator.Randomizers;

public interface IRandomizerGuid
{
    Guid? Generate();

    string? GenerateAsString();
}