namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsTextRegex : FieldOptionsAbstract, IFieldOptionsString
    {
        /// <summary>
        /// Use any valid Regex pattern to generate a string.
        /// </summary>
        public string Pattern { get; set; } = null!;
    }
}