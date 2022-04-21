using RandomDataGenerator.CreditCardValidator;

namespace RandomDataGenerator.FieldOptions;

public class FieldOptionsCCN : FieldOptionsAbstract, IFieldOptionsString
{
    public CardIssuer CardIssuer { get; set; } = CardIssuer.AmericanExpress;

    public int Length { get; set; } = 0;
}