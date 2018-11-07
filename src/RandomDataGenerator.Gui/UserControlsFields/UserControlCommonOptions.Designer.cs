namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlCommonOptions
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
            this.chkAllowNull = new System.Windows.Forms.CheckBox();
            this.lblAllowNullValues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAllowNull
            // 
            this.chkAllowNull.AutoSize = true;
            this.chkAllowNull.Location = new System.Drawing.Point(108, 2);
            this.chkAllowNull.Name = "chkAllowNull";
            this.chkAllowNull.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAllowNull.Size = new System.Drawing.Size(15, 14);
            this.chkAllowNull.TabIndex = 3;
            this.chkAllowNull.UseVisualStyleBackColor = true;
            // 
            // lblAllowNullValues
            // 
            this.lblAllowNullValues.AutoSize = true;
            this.lblAllowNullValues.Location = new System.Drawing.Point(4, 2);
            this.lblAllowNullValues.Name = "lblAllowNullValues";
            this.lblAllowNullValues.Size = new System.Drawing.Size(88, 13);
            this.lblAllowNullValues.TabIndex = 4;
            this.lblAllowNullValues.Text = "Allow Null Values";
            // 
            // UserControlCommonOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAllowNullValues);
            this.Controls.Add(this.chkAllowNull);
            this.Name = "UserControlCommonOptions";
            this.Size = new System.Drawing.Size(390, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAllowNull;
        private System.Windows.Forms.Label lblAllowNullValues;
    }
}
