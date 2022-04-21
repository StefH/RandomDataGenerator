using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Generators;

/// <summary>
/// Copyright http://www.codeproject.com/Articles/423229/CsharpRandomStringGenerator
/// 
/// This class can generate random strings and supports following settings:
/// 1) 6 character sets (UpperCase, LowerCase, Numeric, Space and Special characters)
/// 2) Variable number of the character sets in use
/// 3) Minimal number of each type of the characters
/// 4) Pattern driven string generation
/// 5) Unique string generation
/// 6) Using each character only once
/// It can be easily used for generation of a password or an identificator.
///
/// Stef: Replaced RNGCryptoServiceProvider by Random for netstandard1.3
/// </summary>
internal class RandomStringGenerator
{
    public RandomStringGenerator(
        int? seed = null,
        bool useUpperCaseCharacters = true,
        bool useLowerCaseCharacters = true,
        bool useNumericCharacters = true,
        bool useSpecialCharacters = true,
        bool useSpaces = true)
    {
        _useUpperCaseCharacters = useUpperCaseCharacters;
        _useLowerCaseCharacters = useLowerCaseCharacters;
        _useNumericCharacters = useNumericCharacters;
        _useSpecialCharacters = useSpecialCharacters;
        _useSpaceCharacters = useSpaces;

        _currentGeneralCharacters = new char[0]; // avoiding null exceptions
        UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        NumericCharacters = "0123456789".ToCharArray();
        SpecialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]<>|~".ToCharArray();
        _currentSpaceCharacters = " ".ToCharArray();

        MinUpperCaseCharacters = MinLowerCaseCharacters = MinNumericCharacters = MinSpecialCharacters = MinSpaceCharacters = 0;
        RepeatCharacters = true;
        _patternDriven = false;
        Pattern = string.Empty;
        _existingStrings = new List<string>();
        _random = seed.HasValue ? new Random(seed.Value) : new Random();
    }

    #region character sets managers
    /// <summary>
    /// True if we need to use upper case characters
    /// </summary>
    public bool UseUpperCaseCharacters
    {
        get => _useUpperCaseCharacters;
        set
        {
            if (_currentUpperCaseCharacters != null)
                _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentUpperCaseCharacters).ToArray();

            if (_currentUpperCaseCharacters != null && value)
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(_currentUpperCaseCharacters).ToArray();

            _useUpperCaseCharacters = value;
        }
    }

    /// <summary>
    /// Sets or gets upper case character set.
    /// </summary>
    public char[] UpperCaseCharacters
    {
        get => _currentUpperCaseCharacters;
        set
        {
            if (UseUpperCaseCharacters)
            {
                if (_currentUpperCaseCharacters != null)
                    _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentUpperCaseCharacters).ToArray();

                _currentGeneralCharacters = _currentGeneralCharacters.Concat(value).ToArray();
            }
            _currentUpperCaseCharacters = value;
        }
    }

    /// <summary>
    /// True if we need to use lower case characters
    /// </summary>
    public bool UseLowerCaseCharacters
    {
        get => _useLowerCaseCharacters;
        set
        {
            if (_currentLowerCaseCharacters != null)
                _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentLowerCaseCharacters).ToArray();

            if (_currentLowerCaseCharacters != null && value)
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(_currentLowerCaseCharacters).ToArray();

            _useLowerCaseCharacters = value;
        }
    }

    /// <summary>
    /// Sets or gets lower case character set.
    /// </summary>
    public char[] LowerCaseCharacters
    {
        get => _currentLowerCaseCharacters;
        set
        {
            if (UseLowerCaseCharacters)
            {
                if (_currentLowerCaseCharacters != null)
                    _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentLowerCaseCharacters).ToArray();

                _currentGeneralCharacters = _currentGeneralCharacters.Concat(value).ToArray();
            }
            _currentLowerCaseCharacters = value;
        }
    }

    /// <summary>
    /// True if we need to use numeric characters
    /// </summary>
    public bool UseNumericCharacters
    {
        get => _useNumericCharacters;
        set
        {
            if (_currentNumericCharacters != null)
                _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentNumericCharacters).ToArray();

            if (_currentNumericCharacters != null && value)
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(_currentNumericCharacters).ToArray();

            _useNumericCharacters = value;
        }
    }

    /// <summary>
    /// True if we need to use numeric characters
    /// </summary>
    public bool UseSpaces
    {
        get => _useSpaceCharacters;
        set
        {
            if (_currentSpaceCharacters != null)
                _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentSpaceCharacters).ToArray();

            if (_currentSpaceCharacters != null && value)
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(_currentSpaceCharacters).ToArray();

            _useSpaceCharacters = value;
        }
    }

    /// <summary>
    /// Sets or gets numeric character set.
    /// </summary>
    public char[] NumericCharacters
    {
        get => _currentNumericCharacters;
        set
        {
            if (UseNumericCharacters)
            {
                if (_currentNumericCharacters != null)
                    _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentNumericCharacters).ToArray();
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(value).ToArray();
            }
            _currentNumericCharacters = value;
        }
    }

    /// <summary>
    /// True if we need to use special characters
    /// </summary>
    public bool UseSpecialCharacters
    {
        get => _useSpecialCharacters;
        set
        {
            if (_currentSpecialCharacters != null)
                _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentSpecialCharacters).ToArray();

            if (_currentSpecialCharacters != null && value)
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(_currentSpecialCharacters).ToArray();

            _useSpecialCharacters = value;
        }
    }

    /// <summary>
    /// Sets or gets special character set.
    /// </summary>
    public char[] SpecialCharacters
    {
        get => _currentSpecialCharacters;
        set
        {
            if (UseSpecialCharacters)
            {
                if (_currentSpecialCharacters != null)
                    _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentSpecialCharacters).ToArray();
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(value).ToArray();
            }
            _currentSpecialCharacters = value;
        }
    }

    /// <summary>
    /// Sets or gets spaces character set.
    /// </summary>
    public char[] SpaceCharacters
    {
        get => _currentSpaceCharacters;
        set
        {
            if (UseSpaces)
            {
                if (_currentSpaceCharacters != null)
                    _currentGeneralCharacters = _currentGeneralCharacters.Except(_currentSpaceCharacters).ToArray();
                _currentGeneralCharacters = _currentGeneralCharacters.Concat(value).ToArray();
            }
            _currentSpaceCharacters = value;
        }
    }
    #endregion

    #region character limits

    /// <summary>
    /// Sets or gets minimal number of the upper case characters in generated strings.
    /// </summary>
    public int MinUpperCaseCharacters { get; set; }

    /// <summary>
    /// Sets or gets minimal number of the lower case characters in generated strings.
    /// </summary>
    public int MinLowerCaseCharacters { get; set; }

    /// <summary>
    /// Sets or gets minimal number of the numeric characters in generated strings.
    /// </summary>
    public int MinNumericCharacters { get; set; }

    /// <summary>
    /// Sets or gets minimal number of the special characters in generated strings.
    /// </summary>
    public int MinSpecialCharacters { get; set; }

    /// <summary>
    /// Sets or gets minimal number of the special characters in generated strings.
    /// </summary>
    public int MinSpaceCharacters { get; set; }
    #endregion

    #region pattern
    private string _pattern;

    /// <summary>
    /// Defines the pattern to be followed to generate a string.
    /// This value is ignored if it equals empty string.
    /// Patterns are:
    /// L - for upper case letter
    /// l - for lower case letter
    /// n - for number
    /// s - for special character
    /// _ - for space character
    /// * - for any character
    /// \ - for character as-is
    /// </summary>
    private string Pattern
    {
        get => _pattern;
        set
        {
            _patternDriven = !string.IsNullOrEmpty(value);
            _pattern = value;
        }
    }
    #endregion

    #region generators
    /// <summary>
    /// Generate a string which follows the pattern.
    /// Possible characters are:
    /// L - for upper case letter
    /// l - for lower case letter
    /// n - for number
    /// s - for special character
    /// * - for any character
    /// \ - for character as-is
    /// </summary>
    /// <param name="pattern">The pattern to follow while generation</param>
    /// <returns>A random string which follows the pattern</returns>
    public string Generate(string pattern)
    {
        Pattern = pattern;
        string res = GenerateString(pattern.Length);
        Pattern = string.Empty;

        return res;
    }

    /// <summary>
    /// Generate a string of a variable length from MinLength to MaxLength. The possible 
    /// character sets should be defined before calling this function.
    /// </summary>
    /// <param name="minLength">Minimal length of a string</param>
    /// <param name="maxLength">Maximal length of a string</param>
    /// <returns>A random string from the selected range of length</returns>
    public string Generate(int minLength, int maxLength)
    {
        if (minLength < 0)
            throw new ArgumentException("Minimal length should be greater than 0");

        if (maxLength < minLength)
            throw new ArgumentException("Maximal length should be greater than minimal");

        if (minLength == maxLength)
        {
            return GenerateString(minLength);
        }

        int length = minLength + (GetRandomInt() % (maxLength - minLength));
        return GenerateString(length);
    }

    /// <summary>
    /// Generate a string of a fixed length. The possible 
    /// character sets should be defined before calling this function.
    /// </summary>
    /// <param name="fixedLength">The length of a string</param>
    /// <returns>A random string of the desirable length</returns>
    public string Generate(int fixedLength)
    {
        if (fixedLength < 0)
            throw new ArgumentException("Minimal length should be greater than 0");

        return GenerateString(fixedLength);
    }

    /// <summary>
    /// Main generation method which chooses the algorithm to use for the generation.
    /// It checks some exceptional situations as well.
    /// </summary>
    private string GenerateString(int length)
    {
        if (length == 0)
            throw new ArgumentException("You can't generate a string of a zero length");
        if (!UseUpperCaseCharacters && !UseLowerCaseCharacters && !UseNumericCharacters && !UseSpecialCharacters && !UseSpaces)
            throw new ArgumentException("There should be at least one character set in use");
        if (!RepeatCharacters && (_currentGeneralCharacters.Length < length))
            throw new ArgumentException("There is not enough characters to create a string without repeats");

        string result; // This string will contain the result
        if (_patternDriven)
        {
            // Using the pattern to generate a string
            result = PatternDrivenAlgo(Pattern);
        }
        else if (MinUpperCaseCharacters == 0 && MinLowerCaseCharacters == 0 &&
                 MinNumericCharacters == 0 && MinSpecialCharacters == 0 && MinSpaceCharacters == 0)
        {
            // Using the simpliest algorithm in this case
            result = SimpleGenerateAlgo(length);
        }
        else
        {
            // Paying attention to limits
            result = GenerateAlgoWithLimits(length);
        }

        // Support for unique strings
        // Recursion, but possibility of the stack overflow is low for big strings (> 3 chars).
        if (UniqueStrings && _existingStrings.Contains(result))
        {
            return GenerateString(length);
        }

        AddExistingString(result); // Saving history
        return result;
    }

    /// <summary>
    /// Generate a random string following the pattern
    /// </summary>
    private string PatternDrivenAlgo(string pattern)
    {
        string result = string.Empty;

        var characters = new List<char>();
        bool bNextCharacterIsAsIs = false;
        foreach (char character in pattern)
        {
            char newChar;
            if (bNextCharacterIsAsIs)
            {
                newChar = character;
                bNextCharacterIsAsIs = false;
            }
            else
            {
                switch (character)
                {
                    case 'L':
                    {
                        newChar = GetRandomCharFromArray(_currentUpperCaseCharacters, characters);
                        break;
                    }
                    case 'l':
                    {
                        newChar = GetRandomCharFromArray(_currentLowerCaseCharacters, characters);
                        break;
                    }
                    case 'n':
                    {
                        newChar = GetRandomCharFromArray(_currentNumericCharacters, characters);
                        break;
                    }
                    case 's':
                    {
                        newChar = GetRandomCharFromArray(_currentSpecialCharacters, characters);
                        break;
                    }
                    case '_':
                    {
                        newChar = GetRandomCharFromArray(_currentSpaceCharacters, characters);
                        break;
                    }
                    case '*':
                    {
                        newChar = GetRandomCharFromArray(_currentGeneralCharacters, characters);
                        break;
                    }
                    case '\\':
                    {
                        // next character is taken just as is
                        bNextCharacterIsAsIs = true;
                        continue;
                    }
                    default:
                    {
                        throw new Exception("The character '" + character + "' is not supported");
                    }
                }
            }

            characters.Add(newChar);
            result += newChar;
        }

        return result;
    }

    /// <summary>
    /// The simpliest algorithm of the random string generation. It doesn't pay attention to
    /// limits and patterns.
    /// </summary>
    private string SimpleGenerateAlgo(int length)
    {
        string result = string.Empty;

        // No special limits
        for (int i = 0; i < length; i++)
        {
            char newChar = _currentGeneralCharacters[GetRandomInt() % _currentGeneralCharacters.Length];
            if (!RepeatCharacters && result.Contains(newChar))
            {
                do
                {
                    newChar = _currentGeneralCharacters[GetRandomInt() % _currentGeneralCharacters.Length];
                } while (result.Contains(newChar));
            }
            result += newChar;
        }
        return result;
    }

    /// <summary>
    /// Generate a random string with specified number of minimal characters of each character set.
    /// </summary>
    private string GenerateAlgoWithLimits(int length)
    {
        // exceptional situations
        if (MinUpperCaseCharacters + MinLowerCaseCharacters + MinNumericCharacters + MinSpecialCharacters + MinSpaceCharacters > length)
        {
            throw new ArgumentException("Sum of MinUpperCaseCharacters, MinLowerCaseCharacters," +
                                        " MinNumericCharacters and MinSpecialCharacters is greater than length");
        }
        if (!RepeatCharacters && (MinUpperCaseCharacters > _currentUpperCaseCharacters.Length))
            throw new ArgumentException("Can't generate a string with this number of MinUpperCaseCharacters");
        if (!RepeatCharacters && (MinLowerCaseCharacters > _currentLowerCaseCharacters.Length))
            throw new ArgumentException("Can't generate a string with this number of MinLowerCaseCharacters");
        if (!RepeatCharacters && (MinNumericCharacters > _currentNumericCharacters.Length))
            throw new ArgumentException("Can't generate a string with this number of MinNumericCharacters");
        if (!RepeatCharacters && (MinSpaceCharacters > _currentSpaceCharacters.Length))
            throw new ArgumentException("Can't generate a string with this number of MinSpaceCharacters");
        if (!RepeatCharacters && (MinSpecialCharacters > _currentSpecialCharacters.Length))
            throw new ArgumentException("Can't generate a string with this number of MinSpecialCharacters");
        int allowedNumberOfGeneralCharacters = length - MinUpperCaseCharacters - MinLowerCaseCharacters
                                               - MinNumericCharacters - MinSpecialCharacters - MinSpaceCharacters;

        string result = string.Empty;
        // generation character set in order to support unique characters
        var characters = new List<char>();

        // adding chars to an array
        for (int i = 0; i < MinUpperCaseCharacters; i++)
            characters.Add(GetRandomCharFromArray(UpperCaseCharacters, characters));
        for (int i = 0; i < MinLowerCaseCharacters; i++)
            characters.Add(GetRandomCharFromArray(LowerCaseCharacters, characters));
        for (int i = 0; i < MinNumericCharacters; i++)
            characters.Add(GetRandomCharFromArray(NumericCharacters, characters));
        for (int i = 0; i < MinSpecialCharacters; i++)
            characters.Add(GetRandomCharFromArray(SpecialCharacters, characters));
        for (int i = 0; i < MinSpaceCharacters; i++)
            characters.Add(GetRandomCharFromArray(SpaceCharacters, characters));
        for (int i = 0; i < allowedNumberOfGeneralCharacters; i++)
            characters.Add(GetRandomCharFromArray(_currentGeneralCharacters, characters));

        // generating result
        for (int i = 0; i < length; i++)
        {
            int position = GetRandomInt() % characters.Count;
            char currentChar = characters[position];
            characters.RemoveAt(position);
            result += currentChar;
        }
        return result;
    }
    #endregion

    /// <summary>
    /// True if characters can be repeated.
    /// </summary>
    public bool RepeatCharacters;

    /// <summary>
    /// True if it's not possible to create similar strings.
    /// </summary>
    public bool UniqueStrings;

    /// <summary>
    /// Adding the string to the history array to support unique string generation.
    /// </summary>
    public void AddExistingString(string s)
    {
        _existingStrings.Add(s);
    }

    #region misc tools
    /// <summary>
    /// A 16bit integer number generator.
    /// </summary>
    /// <returns>A random integer value from 0 to 65576</returns>
    private int GetRandomInt()
    {
        byte[] buffer = new byte[2]; // 16 bit = 2^16 = 65576 (more than necessary)

        _random.NextBytes(buffer);

        int index = BitConverter.ToInt16(buffer, 0);
        if (index < 0)
        {
            index = -index; // manage negative random values
        }

        return index;
    }

    /// <summary>
    /// Get a random char from the selected array of chars. It pays attention to
    /// the RepeatCharacters flag.
    /// </summary>
    /// <param name="array">Source of symbols</param>
    /// <param name="existentItems">Existing symbols. Can be null if RepeatCharacters flag is false</param>
    /// <returns>A random character from the array</returns>
    private char GetRandomCharFromArray(char[] array, List<char> existentItems)
    {
        char character;
        do
        {
            character = array[GetRandomInt() % array.Length];
        } while (!RepeatCharacters && existentItems.Contains(character));

        return character;
    }
    #endregion

    #region internal state
    private bool _useUpperCaseCharacters, _useLowerCaseCharacters, _useNumericCharacters, _useSpecialCharacters, _useSpaceCharacters;
    private bool _patternDriven;
    private char[]? _currentUpperCaseCharacters;
    private char[]? _currentLowerCaseCharacters;
    private char[]? _currentNumericCharacters;
    private char[]? _currentSpecialCharacters;
    private char[]? _currentSpaceCharacters;
    private char[]? _currentGeneralCharacters; // All used characters
    private readonly List<string> _existingStrings; // History
    private readonly Random _random;
    #endregion
}