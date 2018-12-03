using System;
using System.ComponentModel;
using System.Windows.Forms;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    public partial class MainForm
    {
        void cmbFields_SelectedValueChanged(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;
            var selectedValue = (Field)cmb.SelectedItem;

            cmbSubFields.DataSource = new BindingList<SubField>(_dataManager.GetSubFields(selectedValue.FieldType));
            cmbSubFields.SelectedIndex = 0;
        }

        void cmbSubFields_SelectedValueChanged(object sender, EventArgs e)
        {
            // Remove Current
            var oldControl = panelFieldOptions.FindControl<IUserControl>();
            if (oldControl != null)
            {
                var baseUserControl = oldControl as BaseUserControl;

                if (baseUserControl != null)
                {
                    baseUserControl.OptionsChanged -= UpdateUserControlExampleText;
                }

                ((UserControl)oldControl).Dispose();
            }

            var cmb = (ComboBox)sender;
            var selectedValue = (SubField)cmb.SelectedItem;
            var subFieldType = selectedValue.SubFieldType;
            var fieldOptions = FieldOptionsFactory.GetFieldOptions(subFieldType);
            var userControl = UserControlFactory.GetUserControl(fieldOptions);

            if (userControl != null)
            {
                var control = (Control)userControl;
                var baseUserControl = (BaseUserControl)userControl;

                baseUserControl.OptionsChanged += UpdateUserControlExampleText;
                UpdateUserControlExampleText(userControl, EventArgs.Empty);

                control.Dock = DockStyle.Top;
                control.Location = new System.Drawing.Point(0, 0);
                control.Name = "userControl_" + baseUserControl.GetType().Name;
                control.TabIndex = 2;

                panelFieldOptions.Controls.Add(control);
            }
        }

        #region Example UserControl
        void UpdateUserControlExampleText(object sender, EventArgs e)
        {
            var baseUserControl = (BaseUserControl)sender;
            UpdateUserControlExampleText(baseUserControl);
        }

        void UserControlExample_RefreshClicked(object sender, EventArgs e)
        {
            var baseUserControl = panelFieldOptions.FindControl<BaseUserControl>();
            UpdateUserControlExampleText(baseUserControl);
        }

        private void UpdateUserControlExampleText(BaseUserControl baseUserControl)
        {
            var dummyDataField = new DataField(null, baseUserControl.GetFieldOptions(), null, null);

            object value = "N/A";
            try
            {
                value = dummyDataField.Generate();
            }
            catch
            {
                // Just ignore exception
            }
            
            userControlExample.txtExample.Text = value != null ? value.ToString() : "NULL";
        }
        #endregion
    }
}