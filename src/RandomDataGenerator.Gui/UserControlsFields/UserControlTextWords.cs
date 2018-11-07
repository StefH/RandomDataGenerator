using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlTextWords : UserControlTextWordsDesignable
    {
        public UserControlTextWords()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override sealed void SetOptionsAndUpdateControls(FieldOptionsTextWords options)
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

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlTextWordsDesignable : BaseUserControl<FieldOptionsTextWords>
    {
    }
}