namespace RandomDataGenerator.Gui.UserControlsFields
{
    partial class UserControlCCN
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbCardIssuer = new System.Windows.Forms.ComboBox();
            this.lblCardIssuer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlLength)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLength
            // 
            this.ctrlLength.Location = new System.Drawing.Point(107, 40);
            this.ctrlLength.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.ctrlLength.Name = "ctrlLength";
            this.ctrlLength.Size = new System.Drawing.Size(75, 20);
            this.ctrlLength.TabIndex = 3;
            this.ctrlLength.ValueChanged += new System.EventHandler(this.LengthChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(3, 42);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(199, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(89, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "0 = default length";
            // 
            // cmbCardIssuer
            // 
            this.cmbCardIssuer.FormattingEnabled = true;
            this.cmbCardIssuer.Items.AddRange(new object[] {
            "Any",
            "AmericanExpress",
            "ChinaUnionPay",
            "Dankort",
            "DinersClub",
            "Discover",
            "Hipercard",
            "JCB",
            "Laser",
            "Maestro",
            "MasterCard",
            "RuPay",
            "Switch",
            "Visa"});
            this.cmbCardIssuer.Location = new System.Drawing.Point(107, 3);
            this.cmbCardIssuer.Name = "cmbCardIssuer";
            this.cmbCardIssuer.Size = new System.Drawing.Size(121, 21);
            this.cmbCardIssuer.TabIndex = 5;
            this.cmbCardIssuer.Text = "Any";
            this.cmbCardIssuer.SelectedValueChanged += new System.EventHandler(this.CardIssuerSelectedValueChanged);
            // 
            // lblCardIssuer
            // 
            this.lblCardIssuer.AutoSize = true;
            this.lblCardIssuer.Location = new System.Drawing.Point(3, 6);
            this.lblCardIssuer.Name = "lblCardIssuer";
            this.lblCardIssuer.Size = new System.Drawing.Size(57, 13);
            this.lblCardIssuer.TabIndex = 6;
            this.lblCardIssuer.Text = "CardIssuer";
            // 
            // UserControlCCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCardIssuer);
            this.Controls.Add(this.cmbCardIssuer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ctrlLength);
            this.Controls.Add(this.lblLength);
            this.Name = "UserControlCCN";
            this.Size = new System.Drawing.Size(350, 98);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.NumericUpDown ctrlLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbCardIssuer;
        private System.Windows.Forms.Label lblCardIssuer;
    }
}