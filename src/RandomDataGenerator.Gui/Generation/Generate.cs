
namespace RandomDataGenerator.Gui.Generation
{
    public abstract class Generate<T> where T : class, new()
    {
        protected readonly T Options;

        protected Generate(T options)
        {
            Options = options;
        }
    }
}