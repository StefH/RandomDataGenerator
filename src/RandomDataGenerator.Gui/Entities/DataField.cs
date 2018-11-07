using System.ComponentModel;
using System.Globalization;
using System.Xml.Serialization;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace RandomDataGenerator.Gui.Entities
{
    public sealed class DataField : IDataField, IListItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private dynamic _randomizer;

        public DataField()
            : this(string.Empty, null, null, null)
        {
        }

        public DataField(string name, FieldOptionsAbstract fieldOptions, Field field, SubField subField)
        {
            _name = name;
            _field = field;
            _subField = subField;
            _fieldOptions = fieldOptions != null ? fieldOptions.Clone() : null;
            Id = GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        public dynamic GetData()
        {
            dynamic rand = RandomizerFactory.GetRandomizerAsDynamic(FieldOptions);
            return rand.Generate();
        }
        [XmlIgnore]
        public string Id { get; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private FieldOptionsAbstract _fieldOptions;
        public FieldOptionsAbstract FieldOptions
        {
            get => _fieldOptions;
            set
            {
                if (value != _fieldOptions)
                {
                    _fieldOptions = value;
                    NotifyPropertyChanged("FieldOptions");
                }
            }
        }

        private Field _field;
        public Field Field
        {
            get => _field;
            set
            {
                if (value != _field)
                {
                    _field = value;
                    NotifyPropertyChanged("Field");
                }
            }
        }

        private SubField _subField;
        public SubField SubField
        {
            get => _subField;
            set
            {
                if (value != _subField)
                {
                    _subField = value;
                    NotifyPropertyChanged("SubField");
                }
            }
        }

        // NotifyPropertyChanged will raise the PropertyChanged event passing the source property that is being updated.
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}