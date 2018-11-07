using System;
using System.Linq;
using System.Windows.Forms;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.Generation;
using RandomDataGenerator.Gui.Properties;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    public partial class MainForm
    {
        private void ClickBrowseFile(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog
            {
                Filter = Resources.FileFilter_sql_all,
                FileName = txtOutputFile.Text,
                Title = Resources.SelectOutputFile
            };

            var result = fileBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtOutputFile.Text = fileBrowser.FileName;
            }
        }

        private void ClickGenerate(object sender, EventArgs e)
        {
            var userControlSQL = panelOutput.FindControl<UserControlOutputSQL>();

            var generate = new GenerateSQL(userControlSQL.GetGenerateOptions());

            var fields = listBoxFields.Items.OfType<DataField>().ToList();
            generate.Spawn(fields, (int)numTotalRecords.Value, txtOutputFile.Text);

            toolStripStatusLabel1.Text = string.Format(Resources.Output_GeneratedRecords, (int)numTotalRecords.Value, txtOutputFile.Text);
        }
    }
}