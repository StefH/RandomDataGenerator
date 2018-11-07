namespace RandomDataGenerator.Gui.UserControls
{
    public partial class UserControlOutputSQL
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
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblRecordsPerInsert = new System.Windows.Forms.Label();
            this.numRecordsPerInsert = new System.Windows.Forms.NumericUpDown();
            this.boxInsertOperation = new System.Windows.Forms.GroupBox();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.chkIncludeFieldNames = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRecordsPerInsert)).BeginInit();
            this.boxInsertOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(4, 7);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(65, 13);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(118, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(200, 20);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "My Table";
            // 
            // lblRecordsPerInsert
            // 
            this.lblRecordsPerInsert.AutoSize = true;
            this.lblRecordsPerInsert.Location = new System.Drawing.Point(4, 40);
            this.lblRecordsPerInsert.Name = "lblRecordsPerInsert";
            this.lblRecordsPerInsert.Size = new System.Drawing.Size(94, 13);
            this.lblRecordsPerInsert.TabIndex = 2;
            this.lblRecordsPerInsert.Text = "Records per Insert";
            // 
            // numRecordsPerInsert
            // 
            this.numRecordsPerInsert.Location = new System.Drawing.Point(118, 38);
            this.numRecordsPerInsert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecordsPerInsert.Name = "numRecordsPerInsert";
            this.numRecordsPerInsert.Size = new System.Drawing.Size(40, 20);
            this.numRecordsPerInsert.TabIndex = 3;
            this.numRecordsPerInsert.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // boxInsertOperation
            // 
            this.boxInsertOperation.Controls.Add(this.rbInsert);
            this.boxInsertOperation.Location = new System.Drawing.Point(11, 71);
            this.boxInsertOperation.Name = "boxInsertOperation";
            this.boxInsertOperation.Size = new System.Drawing.Size(147, 100);
            this.boxInsertOperation.TabIndex = 4;
            this.boxInsertOperation.TabStop = false;
            this.boxInsertOperation.Text = "Insert Operation";
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Checked = true;
            this.rbInsert.Location = new System.Drawing.Point(7, 20);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(65, 17);
            this.rbInsert.TabIndex = 0;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "INSERT";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // chkIncludeFieldNames
            // 
            this.chkIncludeFieldNames.AutoSize = true;
            this.chkIncludeFieldNames.Checked = true;
            this.chkIncludeFieldNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeFieldNames.Location = new System.Drawing.Point(11, 177);
            this.chkIncludeFieldNames.Name = "chkIncludeFieldNames";
            this.chkIncludeFieldNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIncludeFieldNames.Size = new System.Drawing.Size(122, 17);
            this.chkIncludeFieldNames.TabIndex = 5;
            this.chkIncludeFieldNames.Text = "Include Field Names";
            this.chkIncludeFieldNames.UseVisualStyleBackColor = true;
            // 
            // UserControlOutputSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkIncludeFieldNames);
            this.Controls.Add(this.boxInsertOperation);
            this.Controls.Add(this.numRecordsPerInsert);
            this.Controls.Add(this.lblRecordsPerInsert);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblTableName);
            this.Name = "UserControlOutputSQL";
            this.Size = new System.Drawing.Size(600, 200);
            ((System.ComponentModel.ISupportInitialize)(this.numRecordsPerInsert)).EndInit();
            this.boxInsertOperation.ResumeLayout(false);
            this.boxInsertOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblRecordsPerInsert;
        private System.Windows.Forms.GroupBox boxInsertOperation;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.CheckBox chkIncludeFieldNames;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.NumericUpDown numRecordsPerInsert;
    }
}
