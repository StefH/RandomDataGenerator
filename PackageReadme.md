## RandomDataGenerator.Net
This is a simple generator to create random data.

### Supported Random Data 

- Bytes
- Cities
- Countries
- Credit Card Numbers
- DateTime
- Email Addresses
- First/Last Names
- Guids
- IBANs
- IP Addresses (V4 and V6)
- Lorum Ipsum Text
- MAC Addresses
- NaughtyStrings
- Numbers (integer, long, float, double, byte, ...)
- Text Regex Patterns
- Words

### Usage

``` csharp
// Generate a random text with a Regular expression
var randomizerTextRegex = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Pattern = @"^[0-9]{4}[A-Z]{2}" });
string textRegex = randomizerTextRegex.Generate();

// Generate a random first name
var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
string firstName = randomizerFirstName.Generate();

// Generate a random text (no numbers or special characters allowed)
var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = false, UseSpecial = false });
string text = randomizerText.Generate();
```

### Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=StefH) and [Dapper Plus](https://dapper-plus.net/?utm_source=StefH) are major sponsors and proud to contribute to the development of **RandomDataGenerator.Net**.

[![Entity Framework Extensions](https://raw.githubusercontent.com/StefH/resources/main/sponsor/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=StefH)

[![Dapper Plus](https://raw.githubusercontent.com/StefH/resources/main/sponsor/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=StefH)