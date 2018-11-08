
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTotal = new System.Windows.Forms.TabControl();
            this.tabFields = new System.Windows.Forms.TabPage();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblFields = new System.Windows.Forms.Label();
            this.listBoxFields = new System.Windows.Forms.ListBox();
            this.boxDetials = new System.Windows.Forms.GroupBox();
            this.lblHiddenId = new System.Windows.Forms.Label();
            this.boxOptions = new System.Windows.Forms.GroupBox();
            this.panelFieldOptions = new System.Windows.Forms.Panel();
            this.userControlExample = new RandomDataGenerator.Gui.UserControls.UserControlExample();
            this.btnSaveField = new System.Windows.Forms.Button();
            this.boxFieldType = new System.Windows.Forms.GroupBox();
            this.lblSubType = new System.Windows.Forms.Label();
            this.cmbSubFields = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.boxOutputOptions = new System.Windows.Forms.GroupBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.numTotalRecords = new System.Windows.Forms.NumericUpDown();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.boxOutputType = new System.Windows.Forms.GroupBox();
            this.rbOutputSQL = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.tabTotal.SuspendLayout();
            this.tabFields.SuspendLayout();
            this.boxDetials.SuspendLayout();
            this.boxOptions.SuspendLayout();
            this.panelFieldOptions.SuspendLayout();
            this.boxFieldType.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.boxOutputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRecords)).BeginInit();
            this.boxOutputType.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(704, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "&Project";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::RandomDataGenerator.Gui.Properties.Resources.table_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ClickEventMenuSave);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::RandomDataGenerator.Gui.Properties.Resources.folder_database;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.ClickEventMenuLoad);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ClickEventMenuExit);
            // 
            // tabTotal
            // 
            this.tabTotal.Controls.Add(this.tabFields);
            this.tabTotal.Controls.Add(this.tabOutput);
            this.tabTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTotal.Location = new System.Drawing.Point(0, 24);
            this.tabTotal.Name = "tabTotal";
            this.tabTotal.SelectedIndex = 0;
            this.tabTotal.Size = new System.Drawing.Size(704, 597);
            this.tabTotal.TabIndex = 1;
            this.tabTotal.Text = "Output";
            // 
            // tabFields
            // 
            this.tabFields.Controls.Add(this.btnDown);
            this.tabFields.Controls.Add(this.btnUp);
            this.tabFields.Controls.Add(this.btnDeleteField);
            this.tabFields.Controls.Add(this.btnAddField);
            this.tabFields.Controls.Add(this.lblFields);
            this.tabFields.Controls.Add(this.listBoxFields);
            this.tabFields.Controls.Add(this.boxDetials);
            this.tabFields.Location = new System.Drawing.Point(4, 22);
            this.tabFields.Name = "tabFields";
            this.tabFields.Padding = new System.Windows.Forms.Padding(3);
            this.tabFields.Size = new System.Drawing.Size(696, 571);
            this.tabFields.TabIndex = 0;
            this.tabFields.Text = "Fields";
            this.tabFields.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "IsMoveDownFieldEnabled", true));
            this.btnDown.Enabled = false;
            this.btnDown.Image = global::RandomDataGenerator.Gui.Properties.Resources.arrow_down;
            this.btnDown.Location = new System.Drawing.Point(142, 528);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 24);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "IsMoveUpFieldEnabled", true));
            this.btnUp.Enabled = false;
            this.btnUp.Image = global::RandomDataGenerator.Gui.Properties.Resources.arrow_up;
            this.btnUp.Location = new System.Drawing.Point(106, 528);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 24);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "ListHasItems", true));
            this.btnDeleteField.Enabled = false;
            this.btnDeleteField.Image = global::RandomDataGenerator.Gui.Properties.Resources.delete;
            this.btnDeleteField.Location = new System.Drawing.Point(58, 528);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(30, 24);
            this.btnDeleteField.TabIndex = 6;
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Image = global::RandomDataGenerator.Gui.Properties.Resources.add;
            this.btnAddField.Location = new System.Drawing.Point(22, 528);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(30, 24);
            this.btnAddField.TabIndex = 5;
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(19, 7);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(34, 13);
            this.lblFields.TabIndex = 2;
            this.lblFields.Text = "Fields";
            // 
            // listBoxFields
            // 
            this.listBoxFields.DisplayMember = "Name";
            this.listBoxFields.Location = new System.Drawing.Point(22, 23);
            this.listBoxFields.Name = "listBoxFields";
            this.listBoxFields.Size = new System.Drawing.Size(150, 498);
            this.listBoxFields.TabIndex = 1;
            this.listBoxFields.SelectedIndexChanged += new System.EventHandler(this.listBoxFields_SelectedIndexChanged);
            // 
            // boxDetials
            // 
            this.boxDetials.Controls.Add(this.lblHiddenId);
            this.boxDetials.Controls.Add(this.boxOptions);
            this.boxDetials.Controls.Add(this.btnSaveField);
            this.boxDetials.Controls.Add(this.boxFieldType);
            this.boxDetials.Controls.Add(this.txtFieldName);
            this.boxDetials.Controls.Add(this.lblFieldName);
            this.boxDetials.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "IsDataFieldSelected", true));
            this.boxDetials.Location = new System.Drawing.Point(210, 23);
            this.boxDetials.Name = "boxDetials";
            this.boxDetials.Size = new System.Drawing.Size(460, 498);
            this.boxDetials.TabIndex = 0;
            this.boxDetials.TabStop = false;
            this.boxDetials.Text = "Details";
            // 
            // lblHiddenId
            // 
            this.lblHiddenId.AutoSize = true;
            this.lblHiddenId.Location = new System.Drawing.Point(368, 22);
            this.lblHiddenId.Name = "lblHiddenId";
            this.lblHiddenId.Size = new System.Drawing.Size(35, 13);
            this.lblHiddenId.TabIndex = 5;
            this.lblHiddenId.Text = "####";
            this.lblHiddenId.Visible = false;
            // 
            // boxOptions
            // 
            this.boxOptions.Controls.Add(this.panelFieldOptions);
            this.boxOptions.Location = new System.Drawing.Point(10, 153);
            this.boxOptions.Name = "boxOptions";
            this.boxOptions.Size = new System.Drawing.Size(420, 333);
            this.boxOptions.TabIndex = 4;
            this.boxOptions.TabStop = false;
            this.boxOptions.Text = "Options";
            // 
            // panelFieldOptions
            // 
            this.panelFieldOptions.Controls.Add(this.userControlExample);
            this.panelFieldOptions.Location = new System.Drawing.Point(10, 19);
            this.panelFieldOptions.Name = "panelFieldOptions";
            this.panelFieldOptions.Size = new System.Drawing.Size(400, 300);
            this.panelFieldOptions.TabIndex = 0;
            // 
            // userControlExample
            // 
            this.userControlExample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlExample.Location = new System.Drawing.Point(0, 270);
            this.userControlExample.Name = "userControlExample";
            this.userControlExample.Size = new System.Drawing.Size(400, 30);
            this.userControlExample.TabIndex = 1;
            // 
            // btnSaveField
            // 
            this.btnSaveField.Image = global::RandomDataGenerator.Gui.Properties.Resources.disk;
            this.btnSaveField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveField.Location = new System.Drawing.Point(279, 14);
            this.btnSaveField.Name = "btnSaveField";
            this.btnSaveField.Size = new System.Drawing.Size(82, 24);
            this.btnSaveField.TabIndex = 3;
            this.btnSaveField.Text = "Save Field";
            this.btnSaveField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveField.UseVisualStyleBackColor = true;
            this.btnSaveField.Click += new System.EventHandler(this.btnSaveField_Click);
            // 
            // boxFieldType
            // 
            this.boxFieldType.Controls.Add(this.lblSubType);
            this.boxFieldType.Controls.Add(this.cmbSubFields);
            this.boxFieldType.Controls.Add(this.lblType);
            this.boxFieldType.Controls.Add(this.cmbFields);
            this.boxFieldType.Location = new System.Drawing.Point(10, 59);
            this.boxFieldType.Name = "boxFieldType";
            this.boxFieldType.Size = new System.Drawing.Size(420, 78);
            this.boxFieldType.TabIndex = 2;
            this.boxFieldType.TabStop = false;
            this.boxFieldType.Text = "Field Type";
            // 
            // lblSubType
            // 
            this.lblSubType.AutoSize = true;
            this.lblSubType.Location = new System.Drawing.Point(200, 20);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(50, 13);
            this.lblSubType.TabIndex = 3;
            this.lblSubType.Text = "SubType";
            // 
            // cmbSubFields
            // 
            this.cmbSubFields.DisplayMember = "Name";
            this.cmbSubFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubFields.Location = new System.Drawing.Point(203, 36);
            this.cmbSubFields.Name = "cmbSubFields";
            this.cmbSubFields.Size = new System.Drawing.Size(121, 21);
            this.cmbSubFields.TabIndex = 2;
            this.cmbSubFields.ValueMember = "SubFieldType";
            this.cmbSubFields.SelectedValueChanged += new System.EventHandler(this.cmbSubFields_SelectedValueChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // cmbFields
            // 
            this.cmbFields.DisplayMember = "Name";
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.Location = new System.Drawing.Point(10, 36);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 21);
            this.cmbFields.TabIndex = 0;
            this.cmbFields.ValueMember = "FieldType";
            this.cmbFields.SelectedValueChanged += new System.EventHandler(this.cmbFields_SelectedValueChanged);
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(73, 16);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(200, 20);
            this.txtFieldName.TabIndex = 1;
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(7, 20);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(60, 13);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name";
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.btnGenerate);
            this.tabOutput.Controls.Add(this.boxOutputOptions);
            this.tabOutput.Controls.Add(this.boxOutputType);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutput.Size = new System.Drawing.Size(704, 583);
            this.tabOutput.TabIndex = 1;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "ListHasItems", true));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(8, 377);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 50);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate !";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.ClickGenerate);
            // 
            // boxOutputOptions
            // 
            this.boxOutputOptions.Controls.Add(this.panelOutput);
            this.boxOutputOptions.Controls.Add(this.btnBrowseFile);
            this.boxOutputOptions.Controls.Add(this.txtOutputFile);
            this.boxOutputOptions.Controls.Add(this.lblOutputFile);
            this.boxOutputOptions.Controls.Add(this.numTotalRecords);
            this.boxOutputOptions.Controls.Add(this.lblNumRecords);
            this.boxOutputOptions.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "ListHasItems", true));
            this.boxOutputOptions.Location = new System.Drawing.Point(7, 62);
            this.boxOutputOptions.Name = "boxOutputOptions";
            this.boxOutputOptions.Size = new System.Drawing.Size(680, 300);
            this.boxOutputOptions.TabIndex = 1;
            this.boxOutputOptions.TabStop = false;
            this.boxOutputOptions.Text = "Output Options";
            // 
            // panelOutput
            // 
            this.panelOutput.Location = new System.Drawing.Point(2, 79);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(660, 210);
            this.panelOutput.TabIndex = 5;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseFile.Image")));
            this.btnBrowseFile.Location = new System.Drawing.Point(563, 49);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(24, 22);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.ClickBrowseFile);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(120, 50);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(440, 20);
            this.txtOutputFile.TabIndex = 3;
            this.txtOutputFile.Text = "c:\\Temp\\output.sql";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(8, 53);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(58, 13);
            this.lblOutputFile.TabIndex = 2;
            this.lblOutputFile.Text = "Output File";
            // 
            // numTotalRecords
            // 
            this.numTotalRecords.Location = new System.Drawing.Point(120, 18);
            this.numTotalRecords.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalRecords.Name = "numTotalRecords";
            this.numTotalRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numTotalRecords.Size = new System.Drawing.Size(60, 20);
            this.numTotalRecords.TabIndex = 1;
            this.numTotalRecords.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Location = new System.Drawing.Point(8, 20);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(99, 13);
            this.lblNumRecords.TabIndex = 0;
            this.lblNumRecords.Text = "Number of Records";
            // 
            // boxOutputType
            // 
            this.boxOutputType.Controls.Add(this.rbOutputSQL);
            this.boxOutputType.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this, "ListHasItems", true));
            this.boxOutputType.Location = new System.Drawing.Point(8, 6);
            this.boxOutputType.Name = "boxOutputType";
            this.boxOutputType.Size = new System.Drawing.Size(680, 49);
            this.boxOutputType.TabIndex = 0;
            this.boxOutputType.TabStop = false;
            this.boxOutputType.Text = "Output Type";
            // 
            // rbOutputSQL
            // 
            this.rbOutputSQL.AutoSize = true;
            this.rbOutputSQL.Checked = true;
            this.rbOutputSQL.Location = new System.Drawing.Point(8, 20);
            this.rbOutputSQL.Name = "rbOutputSQL";
            this.rbOutputSQL.Size = new System.Drawing.Size(46, 17);
            this.rbOutputSQL.TabIndex = 0;
            this.rbOutputSQL.TabStop = true;
            this.rbOutputSQL.Text = "SQL";
            this.rbOutputSQL.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 599);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(704, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 621);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabTotal);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 660);
            this.Name = "MainForm";
            this.Text = "RandomDataGenerator x.x.x.x";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabTotal.ResumeLayout(false);
            this.tabFields.ResumeLayout(false);
            this.tabFields.PerformLayout();
            this.boxDetials.ResumeLayout(false);
            this.boxDetials.PerformLayout();
            this.boxOptions.ResumeLayout(false);
            this.panelFieldOptions.ResumeLayout(false);
            this.boxFieldType.ResumeLayout(false);
            this.boxFieldType.PerformLayout();
            this.tabOutput.ResumeLayout(false);
            this.boxOutputOptions.ResumeLayout(false);
            this.boxOutputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRecords)).EndInit();
            this.boxOutputType.ResumeLayout(false);
            this.boxOutputType.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTotal;
        private System.Windows.Forms.TabPage tabFields;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.ListBox listBoxFields;
        private System.Windows.Forms.GroupBox boxDetials;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Button btnSaveField;
        private System.Windows.Forms.GroupBox boxFieldType;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.ComboBox cmbSubFields;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.GroupBox boxOptions;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panelFieldOptions;
        private UserControls.UserControlExample userControlExample;
        private System.Windows.Forms.GroupBox boxOutputOptions;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.NumericUpDown numTotalRecords;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.GroupBox boxOutputType;
        private System.Windows.Forms.RadioButton rbOutputSQL;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblHiddenId;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

