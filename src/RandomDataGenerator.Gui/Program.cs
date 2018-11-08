using System;
using System.Windows.Forms;

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
                // Text = $"RandomDataGenerator.Gui {VersionInfo.AssemblyVersion}"
                Text = "RandomDataGenerator.Gui"
            };
            Application.Run(form);
        }
    }
}
