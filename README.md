# RandomDataGenerator.Net
This is a simple generator to create random data.

## NuGet

[![NuGet Badge](https://img.shields.io/nuget/v/RandomDataGenerator.Net)](https://www.nuget.org/packages/RandomDataGenerator.Net)

## Supported Random Data 

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

## Usage

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

## Usage (as SQL Data Generator GUI)
You can also use a UI to generate SQL insert table statements.
![Random Data Generator - 1](https://github.com/StefH/RandomDataGenerator/blob/master/resources/screen-01.png "Screen 1")

![Random Data Generator - 2](https://github.com/StefH/RandomDataGenerator/blob/master/resources/screen-02.png "Screen 2")


## Copyright

### Referenced files / projects
- https://github.com/gustavofrizzo/CreditCardValidator
- http://www.cambiaresearch.com/articles/13/csharp-randomprovider-class
- http://www.codeproject.com/Articles/423229/CsharpRandomStringGenerator
- https://github.com/SaladLab/NetLegacySupport/tree/master/core/ConcurrentDictionary/System/Collections/Concurrent
- https://raw.githubusercontent.com/SimonCropp/NaughtyStrings/master/src/NaughtyStrings/TheNaughtyStrings.cs

### NuGet dependencies
- [Fare](https://github.com/moodmosaic/Fare)