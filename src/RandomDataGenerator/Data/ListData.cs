﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Fare;
using RandomDataGenerator.Data.Models;

namespace RandomDataGenerator.Data
{
    internal sealed class ListData
    {
        private const char Tab = '\t';

        public IEnumerable<string> LastNames { get; }

        public IEnumerable<string> MaleNames { get; }

        public IEnumerable<string> FemaleNames { get; }

        public IEnumerable<string> CityNames { get; }

        public IEnumerable<string> CountryNames { get; }

        public IEnumerable<string> Directions { get; }

        public IEnumerable<string> StreetTypes { get; }

        public IEnumerable<string> TopLevelDomains { get; }

        public IEnumerable<IBAN> IBANs { get; }

        public IEnumerable<IBAN> BBANs { get; }

        public IEnumerable<string> LoremIpsum { get; }

        public IEnumerable<string> LoremIpsumWords { get; }

        private ListData()
        {
            LastNames = GetResourceAsLines("LastNames");
            MaleNames = GetResourceAsLines("MaleNames");
            FemaleNames = GetResourceAsLines("FemaleNames");
            CityNames = GetResourceAsLines("CityNames");
            CountryNames = GetResourceAsLines("CountryNames");
            Directions = new[] { "North", "East", "South", "West" };
            StreetTypes = new[] { "St.", "Ln.", "Ave.", "Way", "Blvd.", "Ct." };
            TopLevelDomains = new[] { "com", "net", "org", "us", "gov", "nl" };

            Func<string[], IBAN> ibanFunc = (columns) => new IBAN { CountryName = columns[0], CountryCode = columns[1], Generator = new Xeger(columns[2]) };
            IBANs = GetResourceAsItems("IBAN", ibanFunc);
            BBANs = GetResourceAsItems("BBAN", ibanFunc);
            LoremIpsum = GetResourceAsLines("LoremIpsum");
            LoremIpsumWords = GetResourceAsLines("LorumIpsumWords");
        }

        public static ListData Instance => Nested.TextInstance;

        // ReSharper disable once ClassNeverInstantiated.Local
        private class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as before field-init
            static Nested()
            {
            }

            internal static readonly ListData TextInstance = new ListData();
        }

        private static Stream GetResourceAsStream(string resourceName)
        {
            return typeof(ListData).GetTypeInfo().Assembly.GetManifestResourceStream($"RandomDataGenerator.Data.Text.{resourceName}.txt");
        }

        private static IEnumerable<string> GetResourceAsLines(string fileName)
        {
            using (var stream = GetResourceAsStream(fileName))
            {
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        yield return line;
                    }
                }
            }
        }

        private static IEnumerable<T> GetResourceAsItems<T>(string fileName, Func<string[], T> convert)
        {
            var lines = GetResourceAsLines(fileName);
            foreach (var line in lines)
            {
                yield return convert(line.Split(Tab));
            }
        }
    }
}