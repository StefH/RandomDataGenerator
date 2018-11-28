using RandomDataGenerator.TextData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace RandomDataGenerator.TextData
{
    internal sealed class ListData
    {
        public IEnumerable<string> LastNames { get; }

        public IEnumerable<string> MaleNames { get; }

        public IEnumerable<string> FemaleNames { get; }

        public IEnumerable<string> CityNames { get; }

        public IEnumerable<string> CountryNames { get; }

        public IEnumerable<string> Directions { get; }

        public IEnumerable<string> StreetTypes { get; }

        public IEnumerable<string> TopLevelDomains { get; }

        public IEnumerable<IBAN> IBANs { get; }

        ListData()
        {
            LastNames = GetResourceAsLines("LastNames");
            MaleNames = GetResourceAsLines("MaleNames");
            FemaleNames = GetResourceAsLines("FemaleNames");
            CityNames = GetResourceAsLines("CityNames");
            CountryNames = GetResourceAsLines("CountryNames");
            Directions = new[] { "North", "East", "South", "West" };
            StreetTypes = new[] { "St.", "Ln.", "Ave.", "Way", "Blvd.", "Ct." };
            TopLevelDomains = new[] { "com", "net", "org", "us", "gov", "nl" };
            IBANs = GetResourceAsItems("IBAN", (columns) =>
            {
                return new IBAN
                {
                    CountryCode = columns[0],
                    Number = int.Parse(columns[1]),
                    Format = columns[2],
                    Pattern = columns[3]
                };
            });
        }

        public static ListData Instance => Nested.TextInstance;

        // ReSharper disable once ClassNeverInstantiated.Local
        class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as before field-init
            static Nested()
            {
            }

            internal static readonly ListData TextInstance = new ListData();
        }

        private Stream GetResourceAsStream(string resourceName)
        {
            return typeof(ListData).GetTypeInfo().Assembly.GetManifestResourceStream($"RandomDataGenerator.Data.Text.{resourceName}.txt");
        }

        private IEnumerable<string> GetResourceAsLines(string fileName)
        {
            var stream = GetResourceAsStream(fileName);
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        private IEnumerable<T> GetResourceAsItems<T>(string fileName, Func<string[], T> convert)
        {
            var lines = GetResourceAsLines(fileName);
            foreach (string line in lines)
            {
                yield return convert(line.Split('\t'));
            }
        }
    }
}