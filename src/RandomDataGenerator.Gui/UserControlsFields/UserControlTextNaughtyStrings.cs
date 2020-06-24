using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlTextNaughtyStrings : UserControlTextNaughtyStringsDesignable
    {
        public UserControlTextNaughtyStrings()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsTextNaughtyStrings options)
        {
            base.SetOptionsAndUpdateControls(options);

            txtCategories.Text = FieldOptions.Categories;
        }

        public override FieldOptionsTextNaughtyStrings GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Categories = txtCategories.Text;

            return FieldOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlTextNaughtyStringsDesignable : BaseUserControl<FieldOptionsTextNaughtyStrings>
    {
    }
}