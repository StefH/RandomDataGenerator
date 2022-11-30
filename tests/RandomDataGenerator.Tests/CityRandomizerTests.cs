using System.Collections.Concurrent;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using Xunit.Abstractions;

namespace RandomDataGenerator.Tests;

public class CityRandomizerTests
{
    private readonly ITestOutputHelper _output;
    private static readonly Random Random = new(420);
    private static readonly object RandLock = new();

    public CityRandomizerTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    public void CityDistributionMustBeUniform(int degree)
    {
        var locationGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsCity { ValueAsString = true, UseNullValues = false });
        var concurrentDictionary = new ConcurrentDictionary<string, long>();
        var options = new ParallelOptions { MaxDegreeOfParallelism = degree };
        Parallel.For(0, 1000, options, i =>
        {
            Parallel.For(0, 1000, options, j =>
            {
                var location = locationGenerator.Generate();
                concurrentDictionary.AddOrUpdate(location, _ => 1, (k, v) => v + 1);
            });
        });
        var topCount = concurrentDictionary.OrderByDescending(pair => pair.Value).First();
        var bottomCount = concurrentDictionary.OrderBy(pair => pair.Value).First();

        _output.WriteLine($"{topCount}");
        _output.WriteLine($"{bottomCount}");

        Assert.True(topCount.Value / bottomCount.Value < 2);
        Assert.NotEqual(topCount.Key, bottomCount.Key);
    }

    [Fact]
    public void TwoRandomCitiesMustNotBeTheSame()
    {
        var locationGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsCity { ValueAsString = true, UseNullValues = false });
        var locationOne = locationGenerator.Generate();
        var locationTwo = locationGenerator.Generate();

        Assert.NotEqual(locationOne, locationTwo);
    }

    [Fact]
    public void SystemRandomDistributionMustBeUniform()
    {
        var concurrentDictionary = new ConcurrentDictionary<int, long>();
        Parallel.For(0, 1000, i =>
        {
            Parallel.For(0, 1000, j =>
            {
                int index;
                lock (RandLock)
                {
                    index = Random.Next(0, 2000);
                }

                concurrentDictionary.AddOrUpdate(index, _ => 1, (k, v) => v + 1);
            });
        });

        var topCount = concurrentDictionary.OrderByDescending(pair => pair.Value).First();
        var bottomCount = concurrentDictionary.OrderBy(pair => pair.Value).First();

        _output.WriteLine($"{topCount}");
        _output.WriteLine($"{bottomCount}");

        Assert.True(topCount.Value / bottomCount.Value < 2);
        Assert.NotEqual(topCount.Key, bottomCount.Key);
    }
}