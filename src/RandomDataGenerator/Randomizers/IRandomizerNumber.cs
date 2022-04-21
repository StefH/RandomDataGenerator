namespace RandomDataGenerator.Randomizers;

public interface IRandomizerNumber<T> where T : struct
{
    T? Generate();
}