using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlGUID : UserControlGUIDDesignable
    {
        public UserControlGUID()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsGuid options)
        {
            base.SetOptionsAndUpdateControls(options);

            chkUppercase.Checked = FieldOptions.Uppercase;
        }

        public override FieldOptionsGuid GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Uppercase = chkUppercase.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlGUIDDesignable : BaseUserControl<FieldOptionsGuid>
    {
    }
}