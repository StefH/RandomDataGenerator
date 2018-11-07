namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsTextPattern : FieldOptionsAbstract, IFieldOptionsString
    {
        /// <summary>
        /// L - for upper case letter
        /// l - for lower case letter
        /// n - for number
        /// s - for special character
        /// _ - for space character
        /// * - for any character
        /// \ - for character as-is
        /// </summary>
        public string Pattern { get; set; }

        //public bool UseUppercase { get; set; } = true;

        //public bool UseLowercase { get; set; } = true;

        //public bool UseLetter { get; set; } = true;

        //public bool UseNumber { get; set; } = true;

        //public bool UseSpace { get; set; } = true;

        //public bool UseSpecial { get; set; }
    }
}