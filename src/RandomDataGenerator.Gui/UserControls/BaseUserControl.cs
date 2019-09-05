using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.Extensions;
using RandomDataGenerator.Gui.UserControlsFields;

namespace RandomDataGenerator.Gui.UserControls
{
    public abstract class BaseUserControl : UserControl, IUserControl
    {
        public event EventHandler OptionsChanged;

        protected BaseUserControl()
        {
            InitControls();
        }

        public virtual void OnOptionsChanged(EventArgs e)
        {
            OptionsChanged?.Invoke(this, e);
        }

        protected virtual void HandleOptionsChangedChanged(object sender, EventArgs e)
        {
            OnOptionsChanged(EventArgs.Empty);
        }

        public virtual void SetOptions(FieldOptionsAbstract options)
        {
            throw new NotImplementedException();
        }

        public virtual FieldOptionsAbstract GetFieldOptions()
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateControls(FieldOptionsAbstract options)
        {
            throw new NotImplementedException();
        }

        private void InitControls()
        {
            if (!(this is UserControlCommonOptions))
            {
                var commonControl = this.FindControl<UserControlCommonOptions>();
                if (commonControl != null)
                {
                    commonControl.OptionsChanged -= OptionsChanged;

                    commonControl.Dispose();
                }
                commonControl = new UserControlCommonOptions
                {
                    Dock = DockStyle.Bottom,
                    Name = "CommonCtrl",
                };
                commonControl.OptionsChanged += OptionsChanged;

                Controls.Add(commonControl);
            }
        }
    }

    public abstract class BaseUserControl<TOptions> : BaseUserControl, IUserControl<TOptions> where TOptions : FieldOptionsAbstract //, new()
    {
        protected TOptions FieldOptions;

        public override void SetOptions(FieldOptionsAbstract options)
        {
            FieldOptions = (TOptions)options;
            SetOptionsAndUpdateControls(FieldOptions);
        }

        public override void UpdateControls(FieldOptionsAbstract options)
        {
            SetOptionsAndUpdateControls((TOptions)options);
        }

        public virtual void SetOptionsAndUpdateControls(TOptions options)
        {
            FieldOptions = options;

            var commonControl = FindControl<UserControlCommonOptions>();
            if (commonControl != null)
            {
                commonControl.SetOptionsAndUpdateControls(options);
            }
        }

        public override FieldOptionsAbstract GetFieldOptions()
        {
            return GetFieldOptionsT();
        }

        public virtual TOptions GetFieldOptionsT()
        {
            var commonControl = FindControl<UserControlCommonOptions>();
            if (commonControl != null)
            {
                FieldOptions.UseNullValues = commonControl.GetFieldOptionsT().UseNullValues;
            }

            return FieldOptions;
        }

        protected void InitEventsForControls()
        {
            foreach (var ctrl in FindControls<NumericUpDown>())
            {
                ctrl.ValueChanged += HandleOptionsChangedChanged;
            }

            foreach (var ctrl in FindControls<RadioButton>())
            {
                ctrl.CheckedChanged += HandleOptionsChangedChanged;
            }

            foreach (var ctrl in FindControls<CheckBox>())
            {
                ctrl.CheckedChanged += HandleOptionsChangedChanged;
            }

            foreach (var ctrl in FindControls<TextBox>())
            {
                ctrl.TextChanged += HandleOptionsChangedChanged;
            }

            foreach (var ctrl in FindControls<DateTimePicker>())
            {
                ctrl.ValueChanged += HandleOptionsChangedChanged;
            }
        }

        protected T FindControl<T>() where T : class
        {
            return FindControls<T>().FirstOrDefault();
        }

        protected IEnumerable<T> FindControls<T>() where T : class
        {
            return Controls.OfType<T>();
        }
    }
}