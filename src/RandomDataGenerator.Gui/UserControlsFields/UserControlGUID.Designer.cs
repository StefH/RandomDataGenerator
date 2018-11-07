namespace RandomDataGenerator.Gui.UserControlsFields
{
    partial class UserControlGUID
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
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.lblUppercase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Location = new System.Drawing.Point(108, 2);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkUppercase.TabIndex = 11;
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // lblUppercase
            // 
            this.lblUppercase.AutoSize = true;
            this.lblUppercase.Location = new System.Drawing.Point(4, 2);
            this.lblUppercase.Name = "lblUppercase";
            this.lblUppercase.Size = new System.Drawing.Size(59, 13);
            this.lblUppercase.TabIndex = 10;
            this.lblUppercase.Text = "Uppercase";
            // 
            // UserControlGUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.lblUppercase);
            this.Name = "UserControlGUID";
            this.Size = new System.Drawing.Size(350, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.Label lblUppercase;
    }
}