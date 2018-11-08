using System;
using System.Linq;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace ConsoleAppClassic
{
    public static class MainTest
    {
        public static void Run()
        {
            var randomizerCity = RandomizerFactory.GetRandomizer(new FieldOptionsCity());
            string city = randomizerCity.Generate();
            Write(randomizerCity, city);

            var randomizerCountry = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());
            string country = randomizerCountry.Generate();
            Write(randomizerCountry, country);

            var randomizerDateTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { DateFrom = DateTime.Today.AddDays(-1888) });
            DateTime? date = randomizerDateTime.Generate();
            Write(randomizerDateTime, date);

            var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            string firstname = randomizerFirstName.Generate();
            Write(randomizerFirstName, firstname);

            var randomizerInteger = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            int? integer = randomizerInteger.Generate();
            Write(randomizerInteger, integer);

            var randomizerGuid = RandomizerFactory.GetRandomizer(new FieldOptionsGuid());
            Guid? guid = randomizerGuid.Generate();
            Write(randomizerGuid, guid);
            string guidAsString = randomizerGuid.GenerateAsString();
            Write(randomizerGuid, guidAsString);

            var randomizerStringList = RandomizerFactory.GetRandomizer(new FieldOptionsStringList { Values = new[] { "1", "b" }.ToList() });
            string stringListValue = randomizerStringList.Generate();
            Write(randomizerStringList, stringListValue);

            var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = false, UseSpecial = false });
            string text = randomizerText.Generate();
            Write(randomizerText, text);

            var randomizerTextLipsum = RandomizerFactory.GetRandomizer(new FieldOptionsTextLipsum { Paragraphs = 1 });
            string lipsum = randomizerTextLipsum.Generate();
            Write(randomizerTextLipsum, lipsum);

            var randomizerTextPattern = RandomizerFactory.GetRandomizer(new FieldOptionsTextPattern { Pattern = "\\xLLnn_**ss\\x" });
            string textPattern = randomizerTextPattern.Generate();
            Write(randomizerTextPattern, textPattern);

            var randomizerTextWords = RandomizerFactory.GetRandomizer(new FieldOptionsTextWords { Min = 10, Max = 10 });
            string words = randomizerTextWords.Generate();
            Write(randomizerTextWords, words);
        }

        private static void Write<T>(object randomizer, T value)
        {
            Console.WriteLine("{0} --> '{1}'", randomizer.GetType().Name, value);
        }
    }
}