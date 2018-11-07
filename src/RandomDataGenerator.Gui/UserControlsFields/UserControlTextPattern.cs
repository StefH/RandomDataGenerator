using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlTextPattern : UserControlTextPatternDesignable
    {
        public UserControlTextPattern()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsTextPattern options)
        {
            base.SetOptionsAndUpdateControls(options);

            txtPattern.Text = FieldOptions.Pattern;
            //chkLetter.Checked = FieldOptions.UseLetter;
            //chkSpace.Checked = FieldOptions.UseSpace;
            //chkSpecial.Checked = FieldOptions.UseSpecial;
            //chkNumber.Checked = FieldOptions.UseNumber;

            //if (FieldOptions.UseLowercase && FieldOptions.UseUppercase)
            //{
            //    rbBoth.Checked = true;
            //}
            //else
            //{
            //    rbUpper.Checked = FieldOptions.UseUppercase;
            //    rbLower.Checked = FieldOptions.UseLowercase;
            //}
        }

        public override FieldOptionsTextPattern GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Pattern = txtPattern.Text;
            //FieldOptions.UseLowercase = rbLower.Checked;
            //FieldOptions.UseUppercase = rbUpper.Checked;
            //FieldOptions.UseLetter = chkLetter.Checked;
            //FieldOptions.UseNumber = chkNumber.Checked;
            //FieldOptions.UseSpecial = chkSpecial.Checked;
            //FieldOptions.UseSpace = chkSpace.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlTextPatternDesignable : BaseUserControl<FieldOptionsTextPattern>
    {
    }
}