using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            var randomizerIPv4 = RandomizerFactory.GetRandomizer(new FieldOptionsIPv4Address { Min = "127.0.2.233", Max = "128.190.255.244" });
            string ipv4 = randomizerIPv4.Generate();
            Write(randomizerIPv4, ipv4);

            var randomizerIPv6 = RandomizerFactory.GetRandomizer(new FieldOptionsIPv6Address { Min = "0000:0001:0000:0000:0020:ff00:0042:8000", Max = "2001:0db8:0120:0000:0030:ff00:aa42:8329" });
            string ipv6 = randomizerIPv6.Generate();
            Write(randomizerIPv6, ipv6);
            string ipv6Lower = randomizerIPv6.Generate(false);
            Write(randomizerIPv6, ipv6Lower);

            var randomizerTimeSpan = RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan { From = TimeSpan.FromDays(1), To = TimeSpan.FromDays(7) });
            TimeSpan? ts = randomizerTimeSpan.Generate();
            Write(randomizerTimeSpan, ts);

            var randomizerTimeSpanC = RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan { From = TimeSpan.FromDays(1), To = TimeSpan.FromDays(7), IncludeMilliseconds = false, Format = "c" });
            string tsC = randomizerTimeSpanC.GenerateAsString();
            Write(randomizerTimeSpanC, tsC);

            var randomizerDateTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { From = DateTime.Today.AddDays(-1888) });
            DateTime? date = randomizerDateTime.Generate();
            Write(randomizerDateTime, date);
            string dateAsString = randomizerDateTime.GenerateAsString();
            Write(randomizerDateTime, dateAsString);

            var randomizerDateTimeNoTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { IncludeTime = false });
            DateTime? dateNoTime = randomizerDateTimeNoTime.Generate();
            Write(randomizerDateTimeNoTime, dateNoTime);

            var randomizerDateTimeWithFormat = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { Format = "yyyy/MM/dd" });
            string dateWithFormat = randomizerDateTimeWithFormat.GenerateAsString();
            Write(randomizerDateTimeNoTime, dateWithFormat);

            var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            string firstname = randomizerFirstName.Generate();
            Write(randomizerFirstName, firstname);

            var randomizerBoolean = RandomizerFactory.GetRandomizer(new FieldOptionsBoolean());
            bool? b = randomizerBoolean.Generate();
            Write(randomizerBoolean, b);

            var randomizerByte = RandomizerFactory.GetRandomizer(new FieldOptionsByte());
            byte? bt = randomizerByte.Generate();
            Write(randomizerByte, bt);


            var randomizerShort = RandomizerFactory.GetRandomizer(new FieldOptionsShort());
            short? sh = randomizerShort.Generate();
            Write(randomizerShort, sh);

            var randomizerInteger = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            int? integer = randomizerInteger.Generate();
            Write(randomizerInteger, integer);

            var randomizerLong = RandomizerFactory.GetRandomizer(new FieldOptionsLong());
            int? @long = randomizerInteger.Generate();
            Write(randomizerLong, @long);

            var randomizerFloat = RandomizerFactory.GetRandomizer(new FieldOptionsFloat());
            float? flt = randomizerFloat.Generate();
            Write(randomizerFloat, flt);

            var randomizerDouble = RandomizerFactory.GetRandomizer(new FieldOptionsDouble());
            double? dbl = randomizerDouble.Generate();
            Write(randomizerDouble, dbl);

            var randomizerGuid = RandomizerFactory.GetRandomizer(new FieldOptionsGuid());
            Guid? guid = randomizerGuid.Generate();
            Write(randomizerGuid, guid);
            string guidAsString = randomizerGuid.GenerateAsString();
            Write(randomizerGuid, guidAsString);

            var randomizerStringList = RandomizerFactory.GetRandomizer(new FieldOptionsStringList { Values = new[] { "1", "b" }.ToList() });
            string stringListValue = randomizerStringList.Generate();
            Write(randomizerStringList, stringListValue);

            var properties = new Dictionary<string, object>
            {
                { "Min", 7 },
                { "Max", 10 },
                { "UseNumber", false },
                { "UseSpecial", false }
            };

            var fieldOptionsText = FieldOptionsFactory.GetFieldOptions("Text", properties);
            var randomizerText = RandomizerFactory.GetRandomizerAsDynamic(fieldOptionsText);
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

            properties = new Dictionary<string, object>();
            var fieldOptionsTimeSpan2 = FieldOptionsFactory.GetFieldOptions("TimeSpan", properties);
            var randomizerTimeSpan2 = RandomizerFactory.GetRandomizerAsDynamic(fieldOptionsTimeSpan2);
            TimeSpan? ts2 = randomizerTimeSpan2.Generate();
            Write(randomizerTimeSpan2, ts2);
        }

        private static void Write<T>(object randomizer, T value)
        {
            Type genericType = randomizer.GetType().GetTypeInfo().GenericTypeArguments.FirstOrDefault();
            Console.WriteLine("{0}{1} --> '{2}'", randomizer.GetType().Name, genericType != null ? $"[{genericType}]" : string.Empty, value);
        }
    }
}