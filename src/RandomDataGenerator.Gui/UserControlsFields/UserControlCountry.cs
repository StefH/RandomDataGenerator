using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlCountry : UserControlCountryDesignable
    {
        public UserControlCountry()
        {
            InitializeComponent();

            base.OnOptionsChanged(EventArgs.Empty);
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlCountryDesignable : BaseUserControl<FieldOptionsCountry>
    {
    }
}