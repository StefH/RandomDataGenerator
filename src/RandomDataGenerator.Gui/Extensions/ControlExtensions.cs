using System.Linq;
using System.Windows.Forms;

namespace RandomDataGenerator.Gui.Extensions
{
    public static class ControlExtensions
    {
        public static T FindControl<T>(this Control parent) where T : class
        {
            return parent.Controls.OfType<T>().FirstOrDefault();
        }
    }
}