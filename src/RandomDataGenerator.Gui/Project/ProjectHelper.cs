using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using RandomDataGenerator.Gui.Properties;

namespace RandomDataGenerator.Gui.Project
{
    public static class ProjectHelper
    {
        public static void Save(ProjectSettings settings, string fileName)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(settings.GetType());

                using (var streamWriter = new StreamWriter(fileName))
                {
                    xmlSerializer.Serialize(streamWriter, settings);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), Resources.ErrorSave, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ProjectSettings Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            using (var fileStreamReader = File.OpenText(fileName))
            {
                var xmlSerializer = new XmlSerializer(typeof(ProjectSettings));

                try
                {
                    return (ProjectSettings)xmlSerializer.Deserialize(fileStreamReader);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), Resources.ErrorLoad, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}