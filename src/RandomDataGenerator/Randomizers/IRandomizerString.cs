namespace RandomDataGenerator.Randomizers;

public interface IRandomizerString
{
    string? Generate();

    string? Generate(bool upperCase);
}