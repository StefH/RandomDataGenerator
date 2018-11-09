namespace RandomDataGenerator.FieldOptions
{
    public abstract class FieldOptionsNumberFixed<T> : FieldOptionsAbstract, IFieldOptionsNumber<T> where T : struct
    {
        public abstract T Value { get; set; }
    }
}