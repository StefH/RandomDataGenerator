namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsTextNaughtyStrings : FieldOptionsAbstract, IFieldOptionsString
    {
        internal static string All = "All";

        /// <summary>
        /// A comma separated string from one or more from these categories:
        ///
        /// All
        /// Changinglengthwhenlowercased
        /// CommandInjectionRuby
        /// Emoji
        /// FileInclusion
        /// Humaninjection
        /// JapaneseEmoticons
        /// KnownCVEsandVulnerabilities
        /// MSDOSWindowsSpecialFilenames
        /// NumericStrings
        /// OghamText
        /// QuotationMarks
        /// ReservedStrings
        /// RightToLeftStrings
        /// SQLInjection
        /// ScriptInjection
        /// ScunthorpeProblem
        /// ServerCodeInjection
        /// SpecialCharacters
        /// SpecialUnicodeCharactersUnion
        /// Stringswhichcontaintwobyteletters
        /// Terminalescapecodes
        /// TrickUnicode
        /// TwoByteCharacters
        /// UnicodeNumbers
        /// UnicodeSubscriptSuperscriptAccents
        /// UnicodeSymbols
        /// UnicodeUpsidedown
        /// Unicodefont
        /// UnwantedInterpolation
        /// ZalgoText
        /// iOSVulnerabilities
        ///
        /// When null, the 'All' category is used.
        /// </summary>
        public string Categories { get; set; } = All;
    }
}