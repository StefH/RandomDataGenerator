using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RandomDataGenerator.CreditCardValidator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace ConsoleAppClassic
{
    public static class MainTest
    {
        public static void Run()
        {
            var randomizerTextRegexWithSeed1 = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Seed = 12345, Pattern = @"^[1-9][0-9]{3}([A-RT-Z][A-Z]|[S][BCE-RT-Z])$" });
            var textRegexWithSeed1 = randomizerTextRegexWithSeed1.Generate();
            Write(randomizerTextRegexWithSeed1, textRegexWithSeed1);

            var randomizerTextRegexWithSeed2 = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Seed = 12345, Pattern = @"^[1-9][0-9]{3}([A-RT-Z][A-Z]|[S][BCE-RT-Z])$" });
            var textRegexWithSeed2 = randomizerTextRegexWithSeed2.Generate();
            Write(randomizerTextRegexWithSeed2, textRegexWithSeed2);

            var randomizerBytes = RandomizerFactory.GetRandomizer(new FieldOptionsBytes { Min = 10, Max = 20 });
            var base64 = randomizerBytes.GenerateAsBase64String();
            Write(randomizerBytes, base64);

            var randomizerTextRegex = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Pattern = @"^[1-9][0-9]{3}([A-RT-Z][A-Z]|[S][BCE-RT-Z])$" });
            var textRegex = randomizerTextRegex.Generate();
            Write(randomizerTextRegex, textRegex);

            var randomizerIBAN1 = RandomizerFactory.GetRandomizer(new FieldOptionsIBAN { Type = "BOTH" });
            var IBAN1 = randomizerIBAN1.Generate();
            Write(randomizerIBAN1, IBAN1);

            var randomizerIBAN2 = RandomizerFactory.GetRandomizer(new FieldOptionsIBAN { CountryCode = "NL" });
            var IBAN2 = randomizerIBAN2.Generate();
            Write(randomizerIBAN2, IBAN2);

            var randomizerIBANWithSeed1 = RandomizerFactory.GetRandomizer(new FieldOptionsIBAN { Seed = 123, CountryCode = "NL" });
            var IBANWithSeed1 = randomizerIBANWithSeed1.Generate();
            Write(randomizerIBANWithSeed1, IBANWithSeed1);

            var randomizerIBANWithSeed2 = RandomizerFactory.GetRandomizer(new FieldOptionsIBAN { Seed = 123, CountryCode = "NL" });
            var IBANWithSeed2 = randomizerIBANWithSeed2.Generate();
            Write(randomizerIBANWithSeed2, IBANWithSeed2);

            var randomizerCity = RandomizerFactory.GetRandomizer(new FieldOptionsCity());
            var city = randomizerCity.Generate();
            Write(randomizerCity, city);
            var cityUpper = randomizerCity.Generate(true);
            Write(randomizerCity, cityUpper);

            var randomizerCountry = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());
            var country = randomizerCountry.Generate();
            Write(randomizerCountry, country);

            var randomizerMAC = RandomizerFactory.GetRandomizer(new FieldOptionsMACAddress { Min = "00-11-22-33-44-55", Max = "aa-bb-cc-dd-ee-ff", Separator = "-" });
            var mac = randomizerMAC.Generate();
            Write(randomizerMAC, mac);

            var randomizerIPv4 = RandomizerFactory.GetRandomizer(new FieldOptionsIPv4Address { Min = "127.0.2.233", Max = "128.190.255.244" });
            var ipv4 = randomizerIPv4.Generate();
            Write(randomizerIPv4, ipv4);

            var randomizerIPv6 = RandomizerFactory.GetRandomizer(new FieldOptionsIPv6Address { Min = "0000:0001:0000:0000:0020:ff00:0042:8000", Max = "2001:0db8:0120:0000:0030:ff00:aa42:8329" });
            var ipv6 = randomizerIPv6.Generate();
            Write(randomizerIPv6, ipv6);
            var ipv6Lower = randomizerIPv6.Generate(false);
            Write(randomizerIPv6, ipv6Lower);

            var randomizerTimeSpan = RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan { From = TimeSpan.FromDays(1), To = TimeSpan.FromDays(7) });
            var ts = randomizerTimeSpan.Generate();
            Write(randomizerTimeSpan, ts);

            var randomizerTimeSpanC = RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan { From = TimeSpan.FromDays(1), To = TimeSpan.FromDays(7), IncludeMilliseconds = false, Format = "c" });
            var tsC = randomizerTimeSpanC.GenerateAsString();
            Write(randomizerTimeSpanC, tsC);

            var randomizerDateTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { From = DateTime.Today.AddYears(-1) });
            var date = randomizerDateTime.Generate();
            Write(randomizerDateTime, date);
            var dateAsString = randomizerDateTime.GenerateAsString();
            Write(randomizerDateTime, dateAsString);

            var randomizerDateTimeNoTime = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { IncludeTime = false });
            var dateNoTime = randomizerDateTimeNoTime.Generate();
            Write(randomizerDateTimeNoTime, dateNoTime);

            var randomizerDateTimeWithFormat = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime { Format = "yyyy/MM/dd" });
            var dateWithFormat = randomizerDateTimeWithFormat.GenerateAsString();
            Write(randomizerDateTimeNoTime, dateWithFormat);

            var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var firstname = randomizerFirstName.Generate();
            Write(randomizerFirstName, firstname);

            var randomizerLastName = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var lastname = randomizerLastName.Generate();
            Write(randomizerLastName, lastname);

            var randomizerBoolean = RandomizerFactory.GetRandomizer(new FieldOptionsBoolean());
            var b = randomizerBoolean.Generate();
            Write(randomizerBoolean, b);

            var randomizerByte = RandomizerFactory.GetRandomizer(new FieldOptionsByte());
            var bt = randomizerByte.Generate();
            Write(randomizerByte, bt);

            var randomizerShort = RandomizerFactory.GetRandomizer(new FieldOptionsShort());
            var sh = randomizerShort.Generate();
            Write(randomizerShort, sh);

            var randomizerInteger = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var integer = randomizerInteger.Generate();
            Write(randomizerInteger, integer);

            var randomizerLong = RandomizerFactory.GetRandomizer(new FieldOptionsLong());
            var @long = randomizerInteger.Generate();
            Write(randomizerLong, @long);

            var randomizerFloat = RandomizerFactory.GetRandomizer(new FieldOptionsFloat());
            var flt = randomizerFloat.Generate();
            Write(randomizerFloat, flt);

            var randomizerDouble = RandomizerFactory.GetRandomizer(new FieldOptionsDouble());
            var dbl = randomizerDouble.Generate();
            Write(randomizerDouble, dbl);

            var randomizerGuid = RandomizerFactory.GetRandomizer(new FieldOptionsGuid());
            var guid = randomizerGuid.Generate();
            Write(randomizerGuid, guid);
            var guidAsString = randomizerGuid.GenerateAsString();
            Write(randomizerGuid, guidAsString);

            var randomizerStringList = RandomizerFactory.GetRandomizer(new FieldOptionsStringList { Values = new[] { "1", "b", "c" }.ToList() });
            var stringListValue = randomizerStringList.Generate();
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
            var lipsum = randomizerTextLipsum.Generate();
            Write(randomizerTextLipsum, lipsum);

            var randomizerTextPattern = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Pattern = "\\xLLnn_**ss\\x" });
            var textPattern = randomizerTextPattern.Generate();
            Write(randomizerTextPattern, textPattern);

            var randomizerTextWords = RandomizerFactory.GetRandomizer(new FieldOptionsTextWords { Min = 10, Max = 10 });
            var words = randomizerTextWords.Generate();
            Write(randomizerTextWords, words);

            properties = new Dictionary<string, object>();
            var fieldOptionsTimeSpan2 = FieldOptionsFactory.GetFieldOptions("TimeSpan", properties);
            var randomizerTimeSpan2 = RandomizerFactory.GetRandomizerAsDynamic(fieldOptionsTimeSpan2);
            TimeSpan? ts2 = randomizerTimeSpan2.Generate();
            Write(randomizerTimeSpan2, ts2);

            var randomizerNaughtyStrings = RandomizerFactory.GetRandomizer(new FieldOptionsTextNaughtyStrings { Categories = "NumericStrings, TrickUnicode" });
            var naughtyString = randomizerNaughtyStrings.Generate();
            Write(randomizerNaughtyStrings, naughtyString);

            var randomizerNaughtyStringsNullCategory = RandomizerFactory.GetRandomizer(new FieldOptionsTextNaughtyStrings());
            var naughtyString2 = randomizerNaughtyStringsNullCategory.Generate();
            Write(randomizerNaughtyStringsNullCategory, naughtyString2);

            var randomizerEmail = RandomizerFactory.GetRandomizer(new FieldOptionsEmailAddress());
            var email = randomizerEmail.Generate();
            Write(randomizerEmail, email);

            foreach (var cardIssuer in Enum.GetValues(typeof(CardIssuer)).Cast<CardIssuer>())
            {
                var randomizerCCN = RandomizerFactory.GetRandomizer(new FieldOptionsCCN { CardIssuer = cardIssuer });
                var CCN = randomizerCCN.Generate();
                Write(randomizerCCN, CCN, $" ({cardIssuer})");
            }
        }

        private static void Write<T>(object randomizer, T value, string? extra = null)
        {
            var genericType = randomizer.GetType().GetTypeInfo().GenericTypeArguments.FirstOrDefault();
            Console.WriteLine("{0}{1}{2} --> '{3}'",
                randomizer.GetType().Name,
                genericType != null ? $"[{genericType.Name}]" : string.Empty,
                extra != null ? extra : string.Empty,
                value
            );
        }
    }
}