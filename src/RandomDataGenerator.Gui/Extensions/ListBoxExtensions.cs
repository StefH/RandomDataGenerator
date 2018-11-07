using System.Windows.Forms;
using RandomDataGenerator.Gui.Entities;

namespace RandomDataGenerator.Gui.Extensions
{
    public class ListBoxObjectFindresult<T>
    {
        public T Item { get; internal set; }
        public int Index { get; internal set; }
    }

    public static class ListBoxExtensions
    {
        public static ListBoxObjectFindresult<T> FindItem<T>(this ListBox listBox, string id) where T : IListItem
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i] is T)
                {
                    var existingDataField = (T)listBox.Items[i];
                    if (existingDataField.Id == id)
                    {
                        return new ListBoxObjectFindresult<T>
                        {
                            Item = existingDataField,
                            Index = i
                        };
                    }
                }
            }

            return null;
        }
    }
}
