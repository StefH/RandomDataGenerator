using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlText : UserControlTextRandomLengthDesignable
    {
        public UserControlText()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsText options)
        {
            base.SetOptionsAndUpdateControls(options);

            ctrlMinLength.Value = FieldOptions.Min;
            ctrlMaxLength.Value = FieldOptions.Max;
            chkLetter.Checked = FieldOptions.UseLetter;
            chkSpace.Checked = FieldOptions.UseSpace;
            chkSpecial.Checked = FieldOptions.UseSpecial;
            chkNumber.Checked = FieldOptions.UseNumber;

            if (FieldOptions.UseLowercase && FieldOptions.UseUppercase)
            {
                rbBoth.Checked = true;
            }
            else
            {
                rbUpper.Checked = FieldOptions.UseUppercase;
                rbLower.Checked = FieldOptions.UseLowercase;
            }
        }

        public override FieldOptionsText GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Min = (int)ctrlMinLength.Value;
            FieldOptions.Max = (int)ctrlMaxLength.Value;

            FieldOptions.UseLowercase = rbLower.Checked;
            FieldOptions.UseUppercase = rbUpper.Checked;
            FieldOptions.UseLetter = chkLetter.Checked;
            FieldOptions.UseNumber = chkNumber.Checked;
            FieldOptions.UseSpecial = chkSpecial.Checked;
            FieldOptions.UseSpace = chkSpace.Checked;

            return FieldOptions;
        }

        private void MinLengthValueChanged(object sender, EventArgs e)
        {
            ctrlMaxLength.Minimum = ctrlMinLength.Value;
        }

        private void MaxLengthValueChanged(object sender, EventArgs e)
        {
            ctrlMinLength.Maximum = ctrlMaxLength.Value;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlTextRandomLengthDesignable : BaseUserControl<FieldOptionsText>
    {
    }
}