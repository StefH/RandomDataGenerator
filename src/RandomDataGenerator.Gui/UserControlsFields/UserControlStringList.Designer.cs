namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlStringList
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
            this.chkConvertToString = new System.Windows.Forms.CheckBox();
            this.lblConvertToString = new System.Windows.Forms.Label();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.lblItemsInSet = new System.Windows.Forms.Label();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkConvertToString
            // 
            this.chkConvertToString.AutoSize = true;
            this.chkConvertToString.Location = new System.Drawing.Point(108, 10);
            this.chkConvertToString.Name = "chkConvertToString";
            this.chkConvertToString.Size = new System.Drawing.Size(15, 14);
            this.chkConvertToString.TabIndex = 5;
            this.chkConvertToString.UseVisualStyleBackColor = true;
            // 
            // lblConvertToString
            // 
            this.lblConvertToString.AutoSize = true;
            this.lblConvertToString.Location = new System.Drawing.Point(3, 10);
            this.lblConvertToString.Name = "lblConvertToString";
            this.lblConvertToString.Size = new System.Drawing.Size(84, 13);
            this.lblConvertToString.TabIndex = 4;
            this.lblConvertToString.Text = "Convert to string";
            // 
            // listBoxValues
            // 
            this.listBoxValues.DataSource = this.listBoxValues.CustomTabOffsets;
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.Location = new System.Drawing.Point(6, 58);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(204, 160);
            this.listBoxValues.TabIndex = 6;
            // 
            // lblItemsInSet
            // 
            this.lblItemsInSet.AutoSize = true;
            this.lblItemsInSet.Location = new System.Drawing.Point(6, 39);
            this.lblItemsInSet.Name = "lblItemsInSet";
            this.lblItemsInSet.Size = new System.Drawing.Size(69, 13);
            this.lblItemsInSet.TabIndex = 7;
            this.lblItemsInSet.Text = "Values in Set";
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "ListHasItems", true));
            this.btnDeleteField.Enabled = false;
            this.btnDeleteField.Image = global::RandomDataGenerator.Gui.Properties.Resources.delete;
            this.btnDeleteField.Location = new System.Drawing.Point(216, 88);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(30, 24);
            this.btnDeleteField.TabIndex = 9;
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.ButtonDeleteFieldClick);
            // 
            // btnAddField
            // 
            this.btnAddField.Image = global::RandomDataGenerator.Gui.Properties.Resources.add;
            this.btnAddField.Location = new System.Drawing.Point(216, 58);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(30, 24);
            this.btnAddField.TabIndex = 8;
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.ButtonAddFieldClick);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(253, 61);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(120, 20);
            this.txtValue.TabIndex = 10;
            // 
            // UserControlFixedSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnDeleteField);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.lblItemsInSet);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.chkConvertToString);
            this.Controls.Add(this.lblConvertToString);
            this.Name = "UserControlFixedSet";
            this.Size = new System.Drawing.Size(390, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkConvertToString;
        private System.Windows.Forms.Label lblConvertToString;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Label lblItemsInSet;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.TextBox txtValue;
    }
}
