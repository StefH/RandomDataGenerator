using System;

namespace RandomDataGenerator.Randomizers;

public interface IRandomizerTimeSpan
{
    TimeSpan? Generate();

    string? GenerateAsString();
}