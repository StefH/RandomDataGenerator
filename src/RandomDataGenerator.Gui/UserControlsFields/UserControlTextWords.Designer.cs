namespace RandomDataGenerator.Gui.UserControlsFields
{
    partial class UserControlTextWords
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
            this.ctrlMin = new System.Windows.Forms.NumericUpDown();
            this.ctrlMax = new System.Windows.Forms.NumericUpDown();
            this.lblWords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(4, 8);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(86, 8);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "to";
            // 
            // ctrlMin
            // 
            this.ctrlMin.Location = new System.Drawing.Point(40, 4);
            this.ctrlMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ctrlMin.Name = "ctrlMin";
            this.ctrlMin.Size = new System.Drawing.Size(40, 20);
            this.ctrlMin.TabIndex = 1;
            this.ctrlMin.ValueChanged += new System.EventHandler(this.EventValueChangedMin);
            // 
            // ctrlMax
            // 
            this.ctrlMax.Location = new System.Drawing.Point(108, 4);
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.Size = new System.Drawing.Size(40, 20);
            this.ctrlMax.TabIndex = 3;
            this.ctrlMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ctrlMax.ValueChanged += new System.EventHandler(this.EventValueChangedMax);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(154, 8);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(38, 13);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "words.";
            // 
            // UserControlTextWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.ctrlMax);
            this.Controls.Add(this.ctrlMin);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "UserControlTextWords";
            this.Size = new System.Drawing.Size(350, 60);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown ctrlMin;
        private System.Windows.Forms.NumericUpDown ctrlMax;
        private System.Windows.Forms.Label lblWords;
    }
}
