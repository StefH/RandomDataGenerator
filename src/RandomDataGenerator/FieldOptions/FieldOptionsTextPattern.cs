using System;

namespace RandomDataGenerator.FieldOptions
{
    [Obsolete("Use FieldOptionsTextRegex")]
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
        public string Pattern { get; set; } = "*";
    }
}