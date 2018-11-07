using System;
using System.Linq;
using System.Windows.Forms;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.Generation;
using RandomDataGenerator.Gui.Project;
using RandomDataGenerator.Gui.Properties;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    public partial class MainForm
    {
        private string _projectSettingsFileName;

        private void ClickEventMenuSave(object sender, EventArgs e)
        {
            var userControlSQL = (BaseUserControlOutput<GenerateOptionsSQL>)panelOutput.FindControl<UserControlOutputSQL>();

            var settings = new ProjectSettings
            {
                Date = DateTime.Now,
                Name = userControlSQL.GetGenerateOptions().Table,
                DataFields = listBoxFields.Items.OfType<DataField>().ToList(),
                GenerateOptions = userControlSQL.GetGenerateOptions(),
                OutputFile = txtOutputFile.Text,
                TotalRecords = (int)numTotalRecords.Value
            };

            var fileBrowser = new SaveFileDialog
            {
                Filter = Resources.FileFilter_xml_all,
                Title = Resources.SaveThisTable,
                FileName = settings.Name + ".xml"
            };

            var result = fileBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                _projectSettingsFileName = fileBrowser.FileName;
                ProjectHelper.Save(settings, _projectSettingsFileName);

                toolStripStatusLabel1.Text = string.Format(Resources.ProjectSettingsSaved, _projectSettingsFileName);
            }
        }

        private void ClickEventMenuLoad(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog
            {
                Filter = Resources.FileFilter_xml_all,
                Title = Resources.LoadSettings,
                FileName = _projectSettingsFileName
            };

            var result = fileBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                _projectSettingsFileName = fileBrowser.FileName;
                var settings = ProjectHelper.Load(_projectSettingsFileName);

                txtOutputFile.Text = settings.OutputFile;
                numTotalRecords.Value = settings.TotalRecords;

                var generateOptions = (GenerateOptionsSQL)settings.GenerateOptions;
                var userControlSQL = (BaseUserControlOutput<GenerateOptionsSQL>)panelOutput.FindControl<UserControlOutputSQL>();
                userControlSQL.UpdateControls(generateOptions);

                listBoxFields.SelectedIndexChanged -= listBoxFields_SelectedIndexChanged;
                _dataFields.Clear();
                foreach (var dataField in settings.DataFields)
                {
                    // Fix Field and SubField
                    dataField.Field = _dataManager.GetFields().FirstOrDefault(f => f.Name == dataField.Field.Name);
                    dataField.SubField = _dataManager.GetSubFields().FirstOrDefault(sf => sf.Name == dataField.SubField.Name);

                    _dataFields.Add(dataField);
                }
                listBoxFields.SelectedIndex = -1;
                listBoxFields.SelectedIndexChanged += listBoxFields_SelectedIndexChanged;

                toolStripStatusLabel1.Text = string.Format(Resources.ProjectSettingsLoaded, _projectSettingsFileName);
            }
        }

        private void ClickEventMenuExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}