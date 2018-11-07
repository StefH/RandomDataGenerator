using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlInteger : UserControlIntegerDesignable
    {
        public UserControlInteger()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsInteger options)
        {
            base.SetOptionsAndUpdateControls(options);

            ctrlMin.Value = FieldOptions.Min;
            ctrlMax.Value = FieldOptions.Max;
            chkConvertToString.Checked = FieldOptions.ValueAsString;
        }

        public override FieldOptionsInteger GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Min = (int)ctrlMin.Value;
            FieldOptions.Max = (int)ctrlMax.Value;
            FieldOptions.ValueAsString = chkConvertToString.Checked;

            return FieldOptions;
        }

        private void MinValueChanged(object sender, EventArgs e)
        {
            ctrlMax.Minimum = ctrlMin.Value;
        }

        private void MaxValueChanged(object sender, EventArgs e)
        {
            ctrlMin.Maximum = ctrlMax.Value;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlIntegerDesignable : BaseUserControl<FieldOptionsInteger>
    {
    }
}