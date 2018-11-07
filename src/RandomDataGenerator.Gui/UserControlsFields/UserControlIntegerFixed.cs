using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlIntegerFixed : UserControlFixedIntegerDesignable
    {
        public UserControlIntegerFixed()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsIntegerFixed options)
        {
            base.SetOptionsAndUpdateControls(options);

            ctrlValue.Value = FieldOptions.Value;
            chkConvertToString.Checked = FieldOptions.ValueAsString;
        }

        public override FieldOptionsIntegerFixed GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Value = (int)ctrlValue.Value;
            FieldOptions.ValueAsString = chkConvertToString.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlFixedIntegerDesignable : BaseUserControl<FieldOptionsIntegerFixed>
    {
    }
}