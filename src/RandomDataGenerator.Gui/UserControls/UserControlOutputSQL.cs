using RandomDataGenerator.Gui.Generation;

namespace RandomDataGenerator.Gui.UserControls
{
    public partial class UserControlOutputSQL : UserControlOutputSQLDesignable
    {
        public UserControlOutputSQL()
        {
        }

        public UserControlOutputSQL(GenerateOptionsSQL options)
            : base(options)
        {
            InitializeComponent();
        }

        public override void UpdateControls(GenerateOptionsSQL options)
        {
            base.UpdateControls(options);

            numRecordsPerInsert.Value = options.RecordsPerInsert;
            chkIncludeFieldNames.Checked = options.IncludeFieldNames;
            txtTableName.Text = options.Table;
        }

        public override GenerateOptionsSQL GetGenerateOptions()
        {
            GenerateOptions.IncludeFieldNames = chkIncludeFieldNames.Checked;
            GenerateOptions.RecordsPerInsert = (int) numRecordsPerInsert.Value;
            GenerateOptions.Table = txtTableName.Text;

            return GenerateOptions;
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlOutputSQLDesignable : BaseUserControlOutput<GenerateOptionsSQL>
    {
        public UserControlOutputSQLDesignable()
        {
        }

        public UserControlOutputSQLDesignable(GenerateOptionsSQL options)
            : base(options)
        {
        }
    }
}