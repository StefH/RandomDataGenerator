using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;
using RandomDataGenerator.TextData;
using RandomDataGenerator.TextData.Models;
using System;
using Fare;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerIBAN : RandomizerAbstract<FieldOptionsIBAN>, IRandomizerString
    {
        private readonly RandomItemFromListGenerator<IBAN> _itemGenerator;

        public RandomizerIBAN(FieldOptionsIBAN options) : base(options)
        {
            Func<IBAN, bool> predicate = null;

            if (!string.IsNullOrEmpty(options.CountryCode))
            {
                predicate = (iban) => iban.CountryCode == options.CountryCode;
            }

            _itemGenerator = new RandomItemFromListGenerator<IBAN>(ListData.Instance.IBANs, predicate);
        }

        public string Generate()
        {
            if (IsNull())
            {
                return null;
            }

            var iban = _itemGenerator.Generate();
            return iban.Generator.Generate();
        }

        public string Generate(bool upperCase)
        {
            return Generate().ToCasedInvariant(upperCase);
        }
    }
}