using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Gui.UserControls
{
    public interface IUserControl
    {
        void SetOptions(FieldOptionsAbstract options);

        FieldOptionsAbstract GetFieldOptions();

        void UpdateControls(FieldOptionsAbstract options);
    }

    public interface IUserControl<TOptions>
    {
        TOptions GetFieldOptionsT();

        void SetOptionsAndUpdateControls(TOptions options);
    }
}