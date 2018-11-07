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
            this.lbPat.Location = new System.Drawing.Point(4, 7);
            this.lbPat.Name = "lbPat";
            this.lbPat.Size = new System.Drawing.Size(41, 13);
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
            this.boxCharsAllowed.Location = new System.Drawing.Point(7, 103);
            this.boxCharsAllowed.Name = "boxCharsAllowed";
            this.boxCharsAllowed.Size = new System.Drawing.Size(380, 120);
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(121, 51);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 7;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(51, 4);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(160, 20);
            this.txtPattern.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 94);
            this.label1.TabIndex = 9;
            this.label1.Text = "L - for upper case letter\r\nl - for lower case letter\r\nn - for number\r\ns - for spe" +
    "cial character\r\n_ - for space character\r\n* - for any character\r\n\\ - for characte" +
    "r as-is";
            // 
            // UserControlTextPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.boxCharsAllowed);
            this.Controls.Add(this.lbPat);
            this.Name = "UserControlTextPattern";
            this.Size = new System.Drawing.Size(390, 250);
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
