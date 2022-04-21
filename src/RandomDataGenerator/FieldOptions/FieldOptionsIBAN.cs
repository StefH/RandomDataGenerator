
namespace RandomDataGenerator.FieldOptions
{
    public class FieldOptionsIBAN : FieldOptionsAbstract, IFieldOptionsString
    {
        public string? CountryCode { get; set; }

        /// <summary>
        /// The type can be IBAN (default), BBAN or BOTH. In case the value is null, IBAN is used as default.
        /// </summary>
        public string Type { get; set; } = "IBAN";
    }
}