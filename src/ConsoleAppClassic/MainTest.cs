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
            var f = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            Write(f.GetData());

            var g = RandomizerFactory.GetRandomizer(new FieldOptionsGuid());
            Write(g.GetData());
            Write(g.GetDataAsString());

            var i = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            Write(i.GetData());

            var d = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { DateFrom = DateTime.Today.AddDays(-1888) });
            Write(d.GetData());

            var s = RandomizerFactory.GetRandomizer(new FieldOptionsStringList { Values = new[] { "1", "b" }.ToList() });
            Write(s.GetData());

            var t = RandomizerFactory.GetRandomizer(new FieldOptionsTextWords { Min = 10, Max = 10 });
            Write(t.GetData());

            var ip = RandomizerFactory.GetRandomizer(new FieldOptionsTextLipsum { Paragraphs = 1 });
            Write(ip.GetData());
        }

        private static void Write<T>(T value)
        {
            Console.WriteLine("--> '{0}'", value);
        }
    }
}