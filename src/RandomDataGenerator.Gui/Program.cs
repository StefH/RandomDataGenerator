using System;
using System.Windows.Forms;
using RandomDataGenerator.Enums;

namespace RandomDataGenerator.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new MainForm
            {
                Text = $"RandomDataGenerator {VersionInfo.AssemblyVersion}"
            };
            Application.Run(form);
        }
    }
}
