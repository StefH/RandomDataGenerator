using System.Collections.Generic;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlGuid : UserControlGUIDDesignable
    {
        public UserControlGuid()
        {
            InitializeComponent();

            InitEventsForControls();

            formatComboBox.DataSource = new List<string> { "N", "D", "B", "P", "X" };
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsGuid options)
        {
            base.SetOptionsAndUpdateControls(options);

            chkUppercase.Checked = FieldOptions.Uppercase;

            formatComboBox.SelectedItem = FieldOptions.Format;
        }

        public override FieldOptionsGuid GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Uppercase = chkUppercase.Checked;

            FieldOptions.Format = formatComboBox.Text;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlGUIDDesignable : BaseUserControl<FieldOptionsGuid>
    {
    }
}