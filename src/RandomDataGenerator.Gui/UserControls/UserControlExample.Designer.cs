namespace RandomDataGenerator.Gui.UserControls
{
    partial class UserControlExample
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
            this.lblExample = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(4, 7);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(47, 13);
            this.lblExample.TabIndex = 0;
            this.lblExample.Text = "Example";
            // 
            // txtExample
            // 
            this.txtExample.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtExample.Location = new System.Drawing.Point(53, 4);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(310, 20);
            this.txtExample.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = global::RandomDataGenerator.Gui.Properties.Resources.arrow_refresh_small;
            this.btnRefresh.Location = new System.Drawing.Point(365, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 21);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // UserControlExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.lblExample);
            this.Name = "UserControlExample";
            this.Size = new System.Drawing.Size(390, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        public System.Windows.Forms.TextBox txtExample;
        public System.Windows.Forms.Button btnRefresh;
    }
}
