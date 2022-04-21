// Copied from https://github.com/gustavofrizzo/CreditCardValidator
using System.Collections.Generic;

namespace RandomDataGenerator.CreditCardValidator;

internal class Rule
{
    public List<int> Lengths { get; set; } = new();

    public List<string> Prefixes { get; set; }= new();
}