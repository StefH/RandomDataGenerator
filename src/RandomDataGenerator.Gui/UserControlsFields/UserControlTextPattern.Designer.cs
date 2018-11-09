namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlTextPattern
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
            this.lbPat = new System.Windows.Forms.Label();
            this.boxCharsAllowed = new System.Windows.Forms.GroupBox();
            this.rbUpper = new System.Windows.Forms.RadioButton();
            this.rbLower = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkLetter = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCharsAllowed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPat
            // 
            this.lbPat.AutoSize = true;
            this.lbPat.Location = new System.Drawing.Point(6, 11);
            this.lbPat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPat.Name = "lbPat";
            this.lbPat.Size = new System.Drawing.Size(61, 20);
            this.lbPat.TabIndex = 0;
            this.lbPat.Text = "Pattern";
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
            this.boxCharsAllowed.Enabled = false;
            this.boxCharsAllowed.Location = new System.Drawing.Point(10, 158);
            this.boxCharsAllowed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxCharsAllowed.Name = "boxCharsAllowed";
            this.boxCharsAllowed.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxCharsAllowed.Size = new System.Drawing.Size(570, 172);
            this.boxCharsAllowed.TabIndex = 5;
            this.boxCharsAllowed.TabStop = false;
            this.boxCharsAllowed.Text = "Characters Allowed";
            // 
            // rbUpper
            // 
            this.rbUpper.AutoSize = true;
            this.rbUpper.Location = new System.Drawing.Point(414, 28);
            this.rbUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUpper.Name = "rbUpper";
            this.rbUpper.Size = new System.Drawing.Size(115, 24);
            this.rbUpper.TabIndex = 6;
            this.rbUpper.Text = "UpperCase";
            this.rbUpper.UseVisualStyleBackColor = true;
            // 
            // rbLower
            // 
            this.rbLower.AutoSize = true;
            this.rbLower.Location = new System.Drawing.Point(273, 28);
            this.rbLower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLower.Name = "rbLower";
            this.rbLower.Size = new System.Drawing.Size(114, 24);
            this.rbLower.TabIndex = 5;
            this.rbLower.Text = "LowerCase";
            this.rbLower.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Checked = true;
            this.rbBoth.Location = new System.Drawing.Point(171, 28);
            this.rbBoth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(68, 24);
            this.rbBoth.TabIndex = 4;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(22, 135);
            this.chkSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(87, 24);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkSpace
            // 
            this.chkSpace.AutoSize = true;
            this.chkSpace.Location = new System.Drawing.Point(22, 100);
            this.chkSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(81, 24);
            this.chkSpace.TabIndex = 2;
            this.chkSpace.Text = "Space";
            this.chkSpace.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Location = new System.Drawing.Point(22, 65);
            this.chkNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(91, 24);
            this.chkNumber.TabIndex = 1;
            this.chkNumber.Text = "Number";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkLetter
            // 
            this.chkLetter.AutoSize = true;
            this.chkLetter.Location = new System.Drawing.Point(22, 29);
            this.chkLetter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLetter.Name = "chkLetter";
            this.chkLetter.Size = new System.Drawing.Size(77, 24);
            this.chkLetter.TabIndex = 0;
            this.chkLetter.Text = "Letter";
            this.chkLetter.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(182, 78);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 7;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(76, 6);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(238, 26);
            this.txtPattern.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 145);
            this.label1.TabIndex = 9;
            this.label1.Text = "L - for upper case letter\r\nl - for lower case letter\r\nn - for number\r\ns - for spe" +
    "cial character\r\n_ - for space character\r\n* - for any character\r\n\\ - for characte" +
    "r as-is";
            // 
            // UserControlTextPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.boxCharsAllowed);
            this.Controls.Add(this.lbPat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTextPattern";
            this.Size = new System.Drawing.Size(585, 385);
            this.boxCharsAllowed.ResumeLayout(false);
            this.boxCharsAllowed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPat;
        private System.Windows.Forms.GroupBox boxCharsAllowed;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkLetter;
        private System.Windows.Forms.RadioButton rbUpper;
        private System.Windows.Forms.RadioButton rbLower;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label1;
    }
}
