using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlMACAddress : UserControlMACAddressDesignable
    {
        public UserControlMACAddress()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsMACAddress options)
        {
            base.SetOptionsAndUpdateControls(options);

            chkAddColons.Checked = FieldOptions.Separator == ":";
            chkUppercase.Checked = FieldOptions.Uppercase;
        }

        public override FieldOptionsMACAddress GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Separator = chkAddColons.Checked ? ":" : string.Empty;
            FieldOptions.Uppercase = chkUppercase.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlMACAddressDesignable : BaseUserControl<FieldOptionsMACAddress>
    {
    }
}