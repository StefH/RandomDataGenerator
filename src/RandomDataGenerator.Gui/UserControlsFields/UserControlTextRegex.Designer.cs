namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlTextRegex
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtPattern.Text = "[a-z]{4}";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Just use any valid Regex to generate a string.";
            // 
            // UserControlTextRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbPat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTextRegex";
            this.Size = new System.Drawing.Size(585, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPat;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label1;
    }
}
