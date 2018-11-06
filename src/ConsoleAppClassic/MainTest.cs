using System;
using System.Linq;
using RandomDataGenerator.Net.FieldOptions;
using RandomDataGenerator.Net.Randomizers;

namespace ConsoleAppClassic
{
    public static class MainTest
    {
        public static void Run()
        {
            var randomizerTextPattern = RandomizerFactory.GetRandomizer(new FieldOptionsTextPattern { Pattern = "\\xLLnn_**ss\\x" });
            string textPattern = randomizerTextPattern.Generate();
            Write(randomizerTextPattern, textPattern);

            var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = false, UseSpecial = false });
            string text = randomizerText.Generate();
            Write(randomizerText, text);

            var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            Write(randomizerFirstName, randomizerFirstName.Generate());

            var randomizerGuid = RandomizerFactory.GetRandomizer(new FieldOptionsGuid());
            Write(randomizerGuid, randomizerGuid.Generate());
            Write(randomizerGuid, randomizerGuid.GenerateAsString());

            var randomizerInteger = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            Write(randomizerInteger, randomizerInteger.Generate());

            var randomizerDateTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { DateFrom = DateTime.Today.AddDays(-1888) });
            Write(randomizerDateTime, randomizerDateTime.Generate());

            var randomizerStringList = RandomizerFactory.GetRandomizer(new FieldOptionsStringList { Values = new[] { "1", "b" }.ToList() });
            Write(randomizerStringList, randomizerStringList.Generate());

            var randomizerTextWords = RandomizerFactory.GetRandomizer(new FieldOptionsTextWords { Min = 10, Max = 10 });
            Write(randomizerTextWords, randomizerTextWords.Generate());

            var randomizerTextLipsum = RandomizerFactory.GetRandomizer(new FieldOptionsTextLipsum { Paragraphs = 1 });
            Write(randomizerTextLipsum, randomizerTextLipsum.Generate());
        }

        private static void Write<T>(object randomizer, T value)
        {
            Console.WriteLine("{0} --> '{1}'", randomizer.GetType().Name, value);
        }
    }
}