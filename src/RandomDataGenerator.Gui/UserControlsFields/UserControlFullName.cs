﻿using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlFullName : UserControlFullNameDesignable
    {
        public UserControlFullName()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsFullName options)
        {
            base.SetOptionsAndUpdateControls(options);

            if (FieldOptions.Male && FieldOptions.Female)
            {
                rbBoth.Checked = true;
            }
            else
            {
                rbMale.Checked = FieldOptions.Male;
                rbFemale.Checked = FieldOptions.Female;
            }
        }

        public override FieldOptionsFullName GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Male = rbBoth.Checked || rbMale.Checked;
            FieldOptions.Female = rbBoth.Checked || rbFemale.Checked;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlFullNameDesignable : BaseUserControl<FieldOptionsFullName>
    {
    }
}