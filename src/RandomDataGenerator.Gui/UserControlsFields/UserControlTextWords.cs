using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlTextWords : BaseUserControl<FieldOptionsTextWords> //UserControlTextWordsDesignable
    {
        public UserControlTextWords()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public sealed override void SetOptionsAndUpdateControls(FieldOptionsTextWords options)
        {
            base.SetOptionsAndUpdateControls(options);

            ctrlMin.Value = FieldOptions.Min;
            ctrlMax.Value = FieldOptions.Max;
        }

        public override FieldOptionsTextWords GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Min = (int)ctrlMin.Value;
            FieldOptions.Max = (int)ctrlMax.Value;

            return FieldOptions;
        }

        private void EventValueChangedMin(object sender, System.EventArgs e)
        {
            ctrlMax.Minimum = ctrlMin.Value;
        }

        private void EventValueChangedMax(object sender, System.EventArgs e)
        {
            ctrlMin.Maximum = ctrlMax.Value;
        }
    }
}