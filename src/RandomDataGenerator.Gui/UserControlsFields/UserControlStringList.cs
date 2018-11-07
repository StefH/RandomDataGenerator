using System;
using System.ComponentModel;
using System.Linq;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlStringList : UserControlFixedSetDesignable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly BindingList<string> _values = new BindingList<string>();

        public UserControlStringList()
        {
            InitializeComponent();

            InitEventsForControls();

            listBoxValues.DataSource = _values;
            _values.ListChanged += ValuesChanged;
        }

        void ValuesChanged(object sender, ListChangedEventArgs e)
        {
            var dataFields = (BindingList<string>)sender;

            ListHasItems = dataFields.Count > 0;
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsStringList options)
        {
            base.SetOptionsAndUpdateControls(options);
            
            _values.Clear();
            foreach (string value in options.Values)
            {
                _values.Add(value);
            }
            
            chkConvertToString.Checked = FieldOptions.ValueAsString;
        }

        public override FieldOptionsStringList GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Values = _values.ToList();
            FieldOptions.ValueAsString = chkConvertToString.Checked;

            return FieldOptions;
        }

        private void ButtonAddFieldClick(object sender, EventArgs e)
        {
            _values.Add(txtValue.Text);
        }

        private void ButtonDeleteFieldClick(object sender, EventArgs e)
        {
            var value = (string)listBoxValues.SelectedItem;
            _values.Remove(value);
        }

        // NotifyPropertyChanged will raise the PropertyChanged event passing the source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
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
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlFixedSetDesignable : BaseUserControl<FieldOptionsStringList>
    {
    }
}