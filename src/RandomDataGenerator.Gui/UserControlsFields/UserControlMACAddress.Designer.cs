namespace RandomDataGenerator.Gui.UserControlsFields
{
    partial class UserControlMACAddress
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
            this.chkAddColons = new System.Windows.Forms.CheckBox();
            this.lblAddColons = new System.Windows.Forms.Label();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.lblUppercase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAddColons
            // 
            this.chkAddColons.AutoSize = true;
            this.chkAddColons.Checked = true;
            this.chkAddColons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddColons.Location = new System.Drawing.Point(108, 2);
            this.chkAddColons.Name = "chkAddColons";
            this.chkAddColons.Size = new System.Drawing.Size(15, 14);
            this.chkAddColons.TabIndex = 7;
            this.chkAddColons.UseVisualStyleBackColor = true;
            // 
            // lblAddColons
            // 
            this.lblAddColons.AutoSize = true;
            this.lblAddColons.Location = new System.Drawing.Point(4, 2);
            this.lblAddColons.Name = "lblAddColons";
            this.lblAddColons.Size = new System.Drawing.Size(84, 13);
            this.lblAddColons.TabIndex = 6;
            this.lblAddColons.Text = "Add colons (:::::)";
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Location = new System.Drawing.Point(108, 30);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkUppercase.TabIndex = 9;
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // lblUppercase
            // 
            this.lblUppercase.AutoSize = true;
            this.lblUppercase.Location = new System.Drawing.Point(4, 30);
            this.lblUppercase.Name = "lblUppercase";
            this.lblUppercase.Size = new System.Drawing.Size(59, 13);
            this.lblUppercase.TabIndex = 8;
            this.lblUppercase.Text = "Uppercase";
            // 
            // UserControlMACAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.lblUppercase);
            this.Controls.Add(this.chkAddColons);
            this.Controls.Add(this.lblAddColons);
            this.Name = "UserControlMACAddress";
            this.Size = new System.Drawing.Size(350, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.CheckBox chkAddColons;
        private System.Windows.Forms.Label lblAddColons;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.Label lblUppercase;
    }
}