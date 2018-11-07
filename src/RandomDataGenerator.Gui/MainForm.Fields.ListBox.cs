using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RandomDataGenerator.Enums;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.Properties;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    public partial class MainForm
    {
        void DataFields_ListChanged(object sender, ListChangedEventArgs e)
        {
            var dataFields = (BindingList<DataField>)sender;

            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
            }

            ListHasItems = dataFields.Count > 0;
        }

        private void btnSaveField_Click(object sender, EventArgs e)
        {
            var userControl = panelFieldOptions.FindControl<IUserControl>();

            if (userControl != null)
            {
                var field = (Field)cmbFields.SelectedItem;
                var subField = (SubField)cmbSubFields.SelectedItem;

                int index = _dataFields.FindIndex(f => f.Id == lblHiddenId.Text);

                var dataField = new DataField(txtFieldName.Text, userControl.GetFieldOptions(), field, subField);
                if (index < 0)
                {
                    lblHiddenId.Text = dataField.Id;
                    _dataFields.Add(dataField);
                }
                else
                {
                    /*
                    _dataFields[index].Field = field;
                    _dataFields[index].SubField = subField;
                    _dataFields[index].FieldOptions = userControl.GetFieldOptions();
                    _dataFields[index].Name = txtFieldName.Text;
                    */

                    listBoxFields.SelectedIndexChanged -= listBoxFields_SelectedIndexChanged;
                    _dataFields.RemoveAt(index);
                    _dataFields.Insert(index, dataField);
                    listBoxFields.SelectedIndexChanged += listBoxFields_SelectedIndexChanged;
                    listBoxFields.SelectedIndex = index;
                }
            }
        }

        private void listBoxFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;

            var selectedDataField = (DataField)listBox.SelectedItem;
            IsDataFieldSelected = selectedDataField != null;

            if (selectedDataField != null)
            {
                // Update Hidden Id
                lblHiddenId.Text = selectedDataField.Id;

                // Update name
                txtFieldName.Text = selectedDataField.Name;

                // Update ComboBoxes
                cmbFields.SelectedItem = selectedDataField.Field;
                cmbSubFields.SelectedItem = selectedDataField.SubField;

                // Update FieldOptions
                var baseUserControl = panelFieldOptions.FindControl<BaseUserControl>();
                baseUserControl.UpdateControls(selectedDataField.FieldOptions);

                IsMoveUpFieldEnabled = listBoxFields.SelectedIndex > 0;
                IsMoveDownFieldEnabled = listBoxFields.SelectedIndex < listBoxFields.Items.Count - 1;
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            var field = _dataManager.GetFields().Single(f => f.FieldType == FieldType.Numbers);
            var dataField = new DataField("New Field", new FieldOptionsInteger(), field, field.SubFields.SingleOrDefault(s => s.SubFieldType == SubFieldType.Integer));

            lblHiddenId.Text = dataField.Id;
            _dataFields.Add(dataField);

            listBoxFields.SelectedIndex = -1;

            toolStripStatusLabel1.Text = Resources.NewFieldAdded;
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            var dataField = (DataField)listBoxFields.SelectedItem;

            var result = MessageBox.Show($"Do you want to remove the field [{dataField.Name}]?", Resources.RemoveField, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _dataFields.Remove(dataField);
                ListHasItems = listBoxFields.Items.Count > 0;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxFields, -1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxFields, 1);
        }

        private void MoveItem(ListBox listBox, int direction)
        {
            // Checking selected item
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
            {
                // No selected item - nothing to do
                return;
            }

            // Calculate new index using move direction
            int newIndex = listBox.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
            {
                // Index out of range - nothing to do
                return;
            }

            var selectedDataField = (DataField)listBox.SelectedItem;

            // Removing removable element
            _dataFields.Remove(selectedDataField);

            // Insert it in new position
            _dataFields.Insert(newIndex, selectedDataField);

            // Restore selection
            listBox.SetSelected(newIndex, true);
        }

        private bool _listHasItems;
        public bool ListHasItems
        {
            get => _listHasItems;
            set
            {
                if (value != _listHasItems)
                {
                    _listHasItems = value;
                    NotifyPropertyChanged("ListHasItems");
                }
            }
        }

        private bool _isMoveUpFieldEnabled;
        public bool IsMoveUpFieldEnabled
        {
            get => _isMoveUpFieldEnabled;
            set
            {
                if (value != _isMoveUpFieldEnabled)
                {
                    _isMoveUpFieldEnabled = value;
                    NotifyPropertyChanged("IsMoveUpFieldEnabled");
                }
            }
        }

        private bool _isMoveDownFieldEnabled;
        public bool IsMoveDownFieldEnabled
        {
            get => _isMoveDownFieldEnabled;
            set
            {
                if (value != _isMoveDownFieldEnabled)
                {
                    _isMoveDownFieldEnabled = value;
                    NotifyPropertyChanged("IsMoveDownFieldEnabled");
                }
            }
        }

        private bool _isDataFieldSelected;
        public bool IsDataFieldSelected
        {
            get => _isDataFieldSelected;
            set
            {
                if (value != _isDataFieldSelected)
                {
                    _isDataFieldSelected = value;
                    NotifyPropertyChanged("IsDataFieldSelected");
                }
            }
        }
    }
}