namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlText
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.ctrlMinLength = new System.Windows.Forms.NumericUpDown();
            this.ctrlMaxLength = new System.Windows.Forms.NumericUpDown();
            this.lblChars = new System.Windows.Forms.Label();
            this.boxCharsAllowed = new System.Windows.Forms.GroupBox();
            this.rbUpper = new System.Windows.Forms.RadioButton();
            this.rbLower = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkLetter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMaxLength)).BeginInit();
            this.boxCharsAllowed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(4, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Length from";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(118, 8);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "to";
            // 
            // ctrlMin
            // 
            this.ctrlMinLength.Location = new System.Drawing.Point(72, 4);
            this.ctrlMinLength.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ctrlMinLength.Name = "ctrlMinLength";
            this.ctrlMinLength.Size = new System.Drawing.Size(40, 20);
            this.ctrlMinLength.TabIndex = 1;
            this.ctrlMinLength.ValueChanged += new System.EventHandler(this.MinLengthValueChanged);
            // 
            // ctrlMax
            // 
            this.ctrlMaxLength.Location = new System.Drawing.Point(140, 5);
            this.ctrlMaxLength.Name = "ctrlMaxLength";
            this.ctrlMaxLength.Size = new System.Drawing.Size(40, 20);
            this.ctrlMaxLength.TabIndex = 3;
            this.ctrlMaxLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ctrlMaxLength.ValueChanged += new System.EventHandler(this.MaxLengthValueChanged);
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(186, 9);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(60, 13);
            this.lblChars.TabIndex = 4;
            this.lblChars.Text = "characters.";
            // 
            // boxCharsAllowed
            // 
            this.boxCharsAllowed.Controls.Add(this.rbUpper);
            this.boxCharsAllowed.Controls.Add(this.rbLower);
            this.boxCharsAllowed.Controls.Add(this.rbBoth);
            this.boxCharsAllowed.Controls.Add(this.chkSpecial);
            this.boxCharsAllowed.Controls.Add(this.chkSpace);
            this.boxCharsAllowed.Controls.Add(this.chkNumber);
            this.boxCharsAllowed.Controls.Add(this.chkLetter);
            this.boxCharsAllowed.Location = new System.Drawing.Point(7, 43);
            this.boxCharsAllowed.Name = "boxCharsAllowed";
            this.boxCharsAllowed.Size = new System.Drawing.Size(370, 120);
            this.boxCharsAllowed.TabIndex = 5;
            this.boxCharsAllowed.TabStop = false;
            this.boxCharsAllowed.Text = "Characters Allowed";
            // 
            // rbUpper
            // 
            this.rbUpper.AutoSize = true;
            this.rbUpper.Location = new System.Drawing.Point(276, 18);
            this.rbUpper.Name = "rbUpper";
            this.rbUpper.Size = new System.Drawing.Size(78, 17);
            this.rbUpper.TabIndex = 6;
            this.rbUpper.Text = "UpperCase";
            this.rbUpper.UseVisualStyleBackColor = true;
            // 
            // rbLower
            // 
            this.rbLower.AutoSize = true;
            this.rbLower.Location = new System.Drawing.Point(182, 18);
            this.rbLower.Name = "rbLower";
            this.rbLower.Size = new System.Drawing.Size(78, 17);
            this.rbLower.TabIndex = 5;
            this.rbLower.Text = "LowerCase";
            this.rbLower.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Checked = true;
            this.rbBoth.Location = new System.Drawing.Point(114, 18);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(47, 17);
            this.rbBoth.TabIndex = 4;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(15, 88);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(61, 17);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkSpace
            // 
            this.chkSpace.AutoSize = true;
            this.chkSpace.Location = new System.Drawing.Point(15, 65);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(57, 17);
            this.chkSpace.TabIndex = 2;
            this.chkSpace.Text = "Space";
            this.chkSpace.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Location = new System.Drawing.Point(15, 42);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(63, 17);
            this.chkNumber.TabIndex = 1;
            this.chkNumber.Text = "Number";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkLetter
            // 
            this.chkLetter.AutoSize = true;
            this.chkLetter.Location = new System.Drawing.Point(15, 19);
            this.chkLetter.Name = "chkLetter";
            this.chkLetter.Size = new System.Drawing.Size(53, 17);
            this.chkLetter.TabIndex = 0;
            this.chkLetter.Text = "Letter";
            this.chkLetter.UseVisualStyleBackColor = true;
            // 
            // UserControlTextRandomLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxCharsAllowed);
            this.Controls.Add(this.lblChars);
            this.Controls.Add(this.ctrlMaxLength);
            this.Controls.Add(this.ctrlMinLength);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "UserControlTextRandomLength";
            this.Size = new System.Drawing.Size(390, 190);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMaxLength)).EndInit();
            this.boxCharsAllowed.ResumeLayout(false);
            this.boxCharsAllowed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown ctrlMinLength;
        private System.Windows.Forms.NumericUpDown ctrlMaxLength;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.GroupBox boxCharsAllowed;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkLetter;
        private System.Windows.Forms.RadioButton rbUpper;
        private System.Windows.Forms.RadioButton rbLower;
        private System.Windows.Forms.RadioButton rbBoth;
    }
}
