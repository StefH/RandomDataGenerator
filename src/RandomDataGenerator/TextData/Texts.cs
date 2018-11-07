using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace RandomDataGenerator.TextData
{
    public sealed class Texts
    {
        public IEnumerable<string> LastNames { get; }
        public IEnumerable<string> MaleNames { get; }
        public IEnumerable<string> FemaleNames { get; }
        public IEnumerable<string> CityNames { get; }
        public IEnumerable<string> CountryNames { get; }
        public IEnumerable<string> Directions { get; }
        public IEnumerable<string> StreetTypes { get; }
        public IEnumerable<string> TopLevelDomains { get; }

        Texts()
        {
            LastNames = GetResourceAsLines("LastNames");
            MaleNames = GetResourceAsLines("MaleNames");
            FemaleNames = GetResourceAsLines("FemaleNames");
            CityNames = GetResourceAsLines("CityNames");
            CountryNames = GetResourceAsLines("CountryNames");
            Directions = new[] { "North", "East", "South", "West" };
            StreetTypes = new[] { "St.", "Ln.", "Ave.", "Way", "Blvd.", "Ct." };
            TopLevelDomains = new[] { "com", "net", "org", "us", "gov", "nl" };
        }

        public static Texts Instance => Nested.TextInstance;

        // ReSharper disable once ClassNeverInstantiated.Local
        class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as before field-init
            static Nested()
            {
            }

            internal static readonly Texts TextInstance = new Texts();
        }

        private Stream GetResourceAsStream(string resourceName)
        {
            return typeof(Texts).GetTypeInfo().Assembly.GetManifestResourceStream($"RandomDataGenerator.TextData.{resourceName}.txt");
        }

        private IEnumerable<string> GetResourceAsLines(string fileName)
        {
            var stream = GetResourceAsStream(fileName);
            using (var reader = new StreamReader(stream, Encoding.ASCII))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}