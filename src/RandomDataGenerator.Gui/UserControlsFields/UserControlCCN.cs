using System;
using RandomDataGenerator.CreditCardValidator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public sealed partial class UserControlCCN : UserControlCCNDesignable
    {
        public UserControlCCN()
        {
            InitializeComponent();

            OnOptionsChanged(EventArgs.Empty);
        }

        public override void SetOptionsAndUpdateControls(FieldOptionsCCN options)
        {
            base.SetOptionsAndUpdateControls(options);

            ctrlLength.Value = FieldOptions.Length;
            cmbCardIssuer.Text = FieldOptions.CardIssuer.ToString();
        }

        public override FieldOptionsCCN GetFieldOptionsT()
        {
            FieldOptions = base.GetFieldOptionsT();

            FieldOptions.Length = (int)ctrlLength.Value;
            FieldOptions.CardIssuer = ParseCardIssuer(cmbCardIssuer.Text);

            return FieldOptions;
        }

        private void LengthChanged(object sender, EventArgs e)
        {
            FieldOptions.Length = (int)ctrlLength.Value;
        }

        private void CardIssuerSelectedValueChanged(object sender, EventArgs e)
        {
            FieldOptions.CardIssuer = ParseCardIssuer(cmbCardIssuer.Text);
        }

        private static CardIssuer ParseCardIssuer(string text)
        {
            return (CardIssuer)Enum.Parse(typeof(CardIssuer), text);
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlCCNDesignable : BaseUserControl<FieldOptionsCCN>
    {
    }
}