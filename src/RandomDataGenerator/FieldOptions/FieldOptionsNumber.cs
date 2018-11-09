namespace RandomDataGenerator.FieldOptions
{
    public abstract class FieldOptionsNumber<T> : FieldOptionsAbstract, IFieldOptionsNumber<T> where T : struct
    {
        public virtual T Min { get; set; }

        public virtual T Max { get; set; }
    }
}