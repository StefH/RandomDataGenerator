using System.Collections.Concurrent;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using Xunit.Abstractions;

namespace RandomDataGenerator.Tests
{
	public class CityRandomizerTests
	{
		private readonly ITestOutputHelper _output;

		public CityRandomizerTests(ITestOutputHelper output)
		{
			this._output = output;
		}


		[Fact]
		public void CityDistributionMustBeUniform()
		{
			var locationGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsCity { ValueAsString = true, UseNullValues = false });
			var concurrentDictionary = new ConcurrentDictionary<string, long>();
			Parallel.For(0, 1000, i =>
			{
				Parallel.For(0, 1000, j =>
				{
					var location = locationGenerator.Generate();
					concurrentDictionary.AddOrUpdate(location, _ => 1, (k, v) => v + 1);
				});
			});
			var topCount = concurrentDictionary.OrderByDescending(pair => pair.Value).First();
			var bottomCount = concurrentDictionary.OrderBy(pair => pair.Value).First();
			_output.WriteLine($"{topCount}");
			_output.WriteLine($"{bottomCount}");
			Assert.True(topCount.Value/bottomCount.Value<2);
		}
	}
}