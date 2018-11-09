using System;
using System.ComponentModel;
using System.Windows.Forms;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlDateTime : UserControlDateTimeDesignable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UserControlDateTime()
        {
            InitializeComponent();

            InitEventsForControls();
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsDateTime options)
        {
            base.SetOptionsAndUpdateControls(options);

            datePickerFrom.Value = FieldOptions.From;
            timePickerFrom.Value = FieldOptions.IncludeTime ? FieldOptions.From : DateTime.Now.Date;

            datePickerTo.Value = FieldOptions.To;
            timePickerTo.Value = FieldOptions.IncludeTime ? FieldOptions.To : DateTime.Now.Date;

            IncludeTime = FieldOptions.IncludeTime;
        }

        public override FieldOptionsDateTime GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.From = datePickerFrom.Value + (chkIncludeTime.Checked ? timePickerFrom.Value.TimeOfDay : new TimeSpan(0));
            FieldOptions.To = datePickerTo.Value + (chkIncludeTime.Checked ? timePickerTo.Value.TimeOfDay : new TimeSpan(0));
            FieldOptions.IncludeTime = chkIncludeTime.Checked;

            return FieldOptions;
        }

        // NotifyPropertyChanged will raise the PropertyChanged event passing the source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool _includeTime;
        public bool IncludeTime
        {
            get => _includeTime;
            set
            {
                if (value != _includeTime)
                {
                    _includeTime = value;

                    if (!value)
                    {
                        timePickerFrom.Value = DateTime.Now.Date;
                        timePickerTo.Value = DateTime.Now.Date;
                    }
                    NotifyPropertyChanged("IncludeTime");
                }
            }
        }

        private void CheckedChangedIncludeTime(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            IncludeTime = checkBox.Checked;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlDateTimeDesignable : BaseUserControl<FieldOptionsDateTime>
    {
    }
}