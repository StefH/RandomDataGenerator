using System;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Gui.UserControls
{
    static class UserControlFactory
    {
        public static IUserControl GetUserControl(FieldOptionsAbstract fieldOptions)
        {
            string typeName = fieldOptions.GetType().FullName
                .Replace("RandomDataGenerator.FieldOptions.FieldOptions", "RandomDataGenerator.Gui.UserControlsFields.UserControl");

            var type = Type.GetType(typeName);
            if (type != null)
            {
                var userControl = (IUserControl)Activator.CreateInstance(type, new object[] { });
                userControl.SetOptions(fieldOptions);

                return userControl;
            }

            return null;
        }
    }
}