namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlInteger
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
            this.lblIntegerMin = new System.Windows.Forms.Label();
            this.lblIntegerMax = new System.Windows.Forms.Label();
            this.ctrlMin = new System.Windows.Forms.NumericUpDown();
            this.ctrlMax = new System.Windows.Forms.NumericUpDown();
            this.lblConvertToString = new System.Windows.Forms.Label();
            this.chkConvertToString = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntegerMin
            // 
            this.lblIntegerMin.AutoSize = true;
            this.lblIntegerMin.Location = new System.Drawing.Point(4, 6);
            this.lblIntegerMin.Name = "lblIntegerMin";
            this.lblIntegerMin.Size = new System.Drawing.Size(48, 13);
            this.lblIntegerMin.TabIndex = 0;
            this.lblIntegerMin.Text = "Minimum";
            // 
            // lblIntegerMax
            // 
            this.lblIntegerMax.AutoSize = true;
            this.lblIntegerMax.Location = new System.Drawing.Point(4, 40);
            this.lblIntegerMax.Name = "lblIntegerMax";
            this.lblIntegerMax.Size = new System.Drawing.Size(51, 13);
            this.lblIntegerMax.TabIndex = 2;
            this.lblIntegerMax.Text = "Maximum";
            // 
            // ctrlMin
            // 
            this.ctrlMin.Location = new System.Drawing.Point(108, 4);
            this.ctrlMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ctrlMin.Name = "ctrlMin";
            this.ctrlMin.Size = new System.Drawing.Size(75, 20);
            this.ctrlMin.TabIndex = 1;
            this.ctrlMin.ValueChanged += new System.EventHandler(this.MinValueChanged);
            // 
            // ctrlMax
            // 
            this.ctrlMax.Location = new System.Drawing.Point(108, 38);
            this.ctrlMax.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.Size = new System.Drawing.Size(75, 20);
            this.ctrlMax.TabIndex = 3;
            this.ctrlMax.Value = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ctrlMax.ValueChanged += new System.EventHandler(this.MaxValueChanged);
            // 
            // lblConvertToString
            // 
            this.lblConvertToString.AutoSize = true;
            this.lblConvertToString.Location = new System.Drawing.Point(4, 72);
            this.lblConvertToString.Name = "lblConvertToString";
            this.lblConvertToString.Size = new System.Drawing.Size(84, 13);
            this.lblConvertToString.TabIndex = 4;
            this.lblConvertToString.Text = "Convert to string";
            // 
            // chkConvertToString
            // 
            this.chkConvertToString.AutoSize = true;
            this.chkConvertToString.Location = new System.Drawing.Point(108, 72);
            this.chkConvertToString.Name = "chkConvertToString";
            this.chkConvertToString.Size = new System.Drawing.Size(15, 14);
            this.chkConvertToString.TabIndex = 5;
            this.chkConvertToString.UseVisualStyleBackColor = true;
            // 
            // UserControlInteger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkConvertToString);
            this.Controls.Add(this.lblConvertToString);
            this.Controls.Add(this.ctrlMax);
            this.Controls.Add(this.ctrlMin);
            this.Controls.Add(this.lblIntegerMax);
            this.Controls.Add(this.lblIntegerMin);
            this.Name = "UserControlInteger";
            this.Size = new System.Drawing.Size(350, 120);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntegerMin;
        private System.Windows.Forms.Label lblIntegerMax;
        private System.Windows.Forms.NumericUpDown ctrlMin;
        private System.Windows.Forms.NumericUpDown ctrlMax;
        private System.Windows.Forms.Label lblConvertToString;
        private System.Windows.Forms.CheckBox chkConvertToString;
    }
}
