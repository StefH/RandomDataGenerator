using System;

namespace RandomDataGenerator.Randomizers;

public interface IRandomizerDateTime
{
    DateTime? Generate();

    string? GenerateAsString();
}