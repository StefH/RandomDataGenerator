using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlCommonOptions : UserControlCommonOptionsDesignable
    {
        public UserControlCommonOptions()
        {
            InitEventsForControls();

            InitializeComponent();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsAbstract options)
        {
            base.SetOptionsAndUpdateControls(options);

            chkAllowNull.Checked = FieldOptions.UseNullValues;
        }

        public override FieldOptionsAbstract GetFieldOptionsT()
        {
            FieldOptions.UseNullValues = chkAllowNull.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlCommonOptionsDesignable : BaseUserControl<FieldOptionsAbstract>
    {
    }
}