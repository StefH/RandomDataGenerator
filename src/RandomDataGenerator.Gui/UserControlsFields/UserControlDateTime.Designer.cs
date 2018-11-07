namespace RandomDataGenerator.Gui.UserControlsFields
{
    sealed partial class UserControlDateTime
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
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.boxTo = new System.Windows.Forms.GroupBox();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.boxFrom = new System.Windows.Forms.GroupBox();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.chkIncludeTime = new System.Windows.Forms.CheckBox();
            this.lblIncludeTimePart = new System.Windows.Forms.Label();
            this.boxTo.SuspendLayout();
            this.boxFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFrom.Location = new System.Drawing.Point(20, 20);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(80, 20);
            this.datePickerFrom.TabIndex = 0;
            // 
            // boxTo
            // 
            this.boxTo.Controls.Add(this.timePickerTo);
            this.boxTo.Controls.Add(this.datePickerTo);
            this.boxTo.Location = new System.Drawing.Point(198, 3);
            this.boxTo.Name = "boxTo";
            this.boxTo.Size = new System.Drawing.Size(180, 100);
            this.boxTo.TabIndex = 1;
            this.boxTo.TabStop = false;
            this.boxTo.Text = "Date/Time To";
            // 
            // timePickerTo
            // 
            this.timePickerTo.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "IncludeTime", true));
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerTo.Location = new System.Drawing.Point(21, 60);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.ShowUpDown = true;
            this.timePickerTo.Size = new System.Drawing.Size(80, 20);
            this.timePickerTo.TabIndex = 3;
            // 
            // datePickerTo
            // 
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTo.Location = new System.Drawing.Point(21, 20);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(80, 20);
            this.datePickerTo.TabIndex = 2;
            // 
            // boxFrom
            // 
            this.boxFrom.Controls.Add(this.timePickerFrom);
            this.boxFrom.Controls.Add(this.datePickerFrom);
            this.boxFrom.Location = new System.Drawing.Point(3, 3);
            this.boxFrom.Name = "boxFrom";
            this.boxFrom.Size = new System.Drawing.Size(180, 100);
            this.boxFrom.TabIndex = 2;
            this.boxFrom.TabStop = false;
            this.boxFrom.Text = "Date/Time From";
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "IncludeTime", true));
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerFrom.Location = new System.Drawing.Point(20, 60);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.ShowUpDown = true;
            this.timePickerFrom.Size = new System.Drawing.Size(80, 20);
            this.timePickerFrom.TabIndex = 1;
            // 
            // chkIncludeTime
            // 
            this.chkIncludeTime.AutoSize = true;
            this.chkIncludeTime.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this, "IncludeTime", true));
            this.chkIncludeTime.Location = new System.Drawing.Point(108, 119);
            this.chkIncludeTime.Name = "chkIncludeTime";
            this.chkIncludeTime.Size = new System.Drawing.Size(15, 14);
            this.chkIncludeTime.TabIndex = 3;
            this.chkIncludeTime.UseVisualStyleBackColor = true;
            this.chkIncludeTime.CheckedChanged += new System.EventHandler(this.CheckedChangedIncludeTime);
            // 
            // lblIncludeTimePart
            // 
            this.lblIncludeTimePart.AutoSize = true;
            this.lblIncludeTimePart.Location = new System.Drawing.Point(4, 119);
            this.lblIncludeTimePart.Name = "lblIncludeTimePart";
            this.lblIncludeTimePart.Size = new System.Drawing.Size(90, 13);
            this.lblIncludeTimePart.TabIndex = 4;
            this.lblIncludeTimePart.Text = "Include Time Part";
            // 
            // UserControlDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIncludeTimePart);
            this.Controls.Add(this.chkIncludeTime);
            this.Controls.Add(this.boxFrom);
            this.Controls.Add(this.boxTo);
            this.Name = "UserControlDateTime";
            this.Size = new System.Drawing.Size(390, 160);
            this.boxTo.ResumeLayout(false);
            this.boxFrom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.GroupBox boxTo;
        private System.Windows.Forms.GroupBox boxFrom;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.CheckBox chkIncludeTime;
        private System.Windows.Forms.Label lblIncludeTimePart;

    }
}
