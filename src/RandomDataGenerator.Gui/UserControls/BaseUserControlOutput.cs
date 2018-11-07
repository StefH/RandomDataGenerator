using System.Windows.Forms;
using RandomDataGenerator.Gui.Generation;

namespace RandomDataGenerator.Gui.UserControls
{
    public abstract class BaseUserControlOutput<TOptions> : UserControl where TOptions : BaseGenerateOptions, new()
    {
        protected TOptions GenerateOptions;

        protected BaseUserControlOutput()
            : this(new TOptions())
        {
        }

        protected BaseUserControlOutput(TOptions options)
        {
            GenerateOptions = options;
        }

        public virtual void UpdateControls(TOptions options)
        {
            GenerateOptions = options;
        }

        public virtual TOptions GetGenerateOptions()
        {
            return GenerateOptions;
        }
    }
}