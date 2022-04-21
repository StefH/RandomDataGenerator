// Copied from https://github.com/gustavofrizzo/CreditCardValidator
using System.Collections.Generic;

namespace RandomDataGenerator.CreditCardValidator;

internal class BrandInfo
{
    public List<Rule> Rules { get; set; } = new();

    public string BrandName { get; set; } = "Unknown";

    public bool SkipLuhn { get; set; } = false;
}