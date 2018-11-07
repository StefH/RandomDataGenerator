using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlIPv6Address : UserControlIPv6AddressDesignable
    {
        public UserControlIPv6Address()
        {
            InitializeComponent();

            base.OnOptionsChanged(EventArgs.Empty);
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlIPv6AddressDesignable : BaseUserControl<FieldOptionsIPv6Address>
    {
    }
}