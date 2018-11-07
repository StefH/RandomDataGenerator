using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlLastName : UserControlLastNameDesignable
    {
        public UserControlLastName()
        {
            InitializeComponent();

            OnOptionsChanged(EventArgs.Empty);
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlLastNameDesignable : BaseUserControl<FieldOptionsLastName>
    {
    }
}