using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlTextRegex : UserControlTextRegexDesignable
    {
        public UserControlTextRegex()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsTextRegex options)
        {
            base.SetOptionsAndUpdateControls(options);

            txtPattern.Text = FieldOptions.Pattern ?? "[a-z]{1}";
        }

        public override FieldOptionsTextRegex GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Pattern = txtPattern.Text;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlTextRegexDesignable : BaseUserControl<FieldOptionsTextRegex>
    {
    }
}