using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RandomDataGenerator.Gui.Data;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.Generation;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly DataManager _dataManager = new DataManager();
        private readonly BindingList<DataField> _dataFields = new BindingList<DataField>();

        public MainForm()
        {
            InitializeComponent();

            var userControlSQL = panelOutput.FindControl<UserControlOutputSQL>();
            if (userControlSQL == null)
            {
                userControlSQL = new UserControlOutputSQL(new GenerateOptionsSQL())
                {
                    Dock = DockStyle.Top
                };
                panelOutput.Controls.Add(userControlSQL);
            }

            listBoxFields.DataSource = _dataFields;
            _dataFields.ListChanged += DataFields_ListChanged;

            var fields = _dataManager.GetFields();
            cmbFields.DataSource = fields;
            cmbSubFields.DataSource = fields.First().SubFields;

            cmbFields.SelectedValueChanged += cmbFields_SelectedValueChanged;

            userControlExample.btnRefresh.Click += UserControlExample_RefreshClicked;
        }

        // NotifyPropertyChanged will raise the PropertyChanged event passing the source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}