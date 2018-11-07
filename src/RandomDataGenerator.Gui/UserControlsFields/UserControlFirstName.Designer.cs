namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlFirstName
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
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblBoth = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Location = new System.Drawing.Point(4, 4);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(30, 13);
            this.lblMale.TabIndex = 0;
            this.lblMale.Text = "Male";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Location = new System.Drawing.Point(4, 34);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(41, 13);
            this.lblFemale.TabIndex = 1;
            this.lblFemale.Text = "Female";
            // 
            // lblBoth
            // 
            this.lblBoth.AutoSize = true;
            this.lblBoth.Location = new System.Drawing.Point(4, 64);
            this.lblBoth.Name = "lblBoth";
            this.lblBoth.Size = new System.Drawing.Size(29, 13);
            this.lblBoth.TabIndex = 2;
            this.lblBoth.Text = "Both";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(58, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(14, 13);
            this.rbMale.TabIndex = 3;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(58, 34);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(14, 13);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Checked = true;
            this.rbBoth.Location = new System.Drawing.Point(58, 64);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(14, 13);
            this.rbBoth.TabIndex = 5;
            this.rbBoth.TabStop = true;
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // UserControlFirstName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbBoth);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblBoth);
            this.Controls.Add(this.lblFemale);
            this.Controls.Add(this.lblMale);
            this.Name = "UserControlFirstName";
            this.Size = new System.Drawing.Size(350, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblBoth;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbBoth;
    }
}
