namespace DesktopApp1
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.wrkEthicLabel = new System.Windows.Forms.Label();
            this.studPrefLabel = new System.Windows.Forms.Label();
            this.collabLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.collabBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.workEthic = new System.Windows.Forms.NumericUpDown();
            this.reliabLabel = new System.Windows.Forms.Label();
            this.reliabNum = new System.Windows.Forms.NumericUpDown();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DesktopApp1.Database1DataSet();
            this.studentTableAdapter = new DesktopApp1.Database1DataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new DesktopApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.majorBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ViewDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewDbItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPref = new System.Windows.Forms.TextBox();
            this.availPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.workEthic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reliabNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Major:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(53, 160);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(155, 20);
            this.lastName.TabIndex = 21;
            this.lastName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(53, 113);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(155, 20);
            this.firstName.TabIndex = 20;
            this.firstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(53, 74);
            this.studentID.Multiline = true;
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(155, 20);
            this.studentID.TabIndex = 19;
            this.studentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name:";
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(47, 25);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(233, 26);
            this.helloWorldLabel.TabIndex = 15;
            this.helloWorldLabel.Text = "Group Formation Form";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(782, 710);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 28);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(50, 55);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(101, 13);
            this.debugInstructionsLabel.TabIndex = 13;
            this.debugInstructionsLabel.Text = "Student ID Number:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(185, 261);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 12;
            // 
            // wrkEthicLabel
            // 
            this.wrkEthicLabel.AutoSize = true;
            this.wrkEthicLabel.Location = new System.Drawing.Point(372, 55);
            this.wrkEthicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrkEthicLabel.Name = "wrkEthicLabel";
            this.wrkEthicLabel.Size = new System.Drawing.Size(63, 13);
            this.wrkEthicLabel.TabIndex = 24;
            this.wrkEthicLabel.Text = "Work Ethic:";
            // 
            // studPrefLabel
            // 
            this.studPrefLabel.AutoSize = true;
            this.studPrefLabel.Location = new System.Drawing.Point(372, 98);
            this.studPrefLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studPrefLabel.Name = "studPrefLabel";
            this.studPrefLabel.Size = new System.Drawing.Size(133, 13);
            this.studPrefLabel.TabIndex = 25;
            this.studPrefLabel.Text = "List 1 student to work with:";
            // 
            // collabLabel
            // 
            this.collabLabel.AutoSize = true;
            this.collabLabel.Location = new System.Drawing.Point(372, 143);
            this.collabLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.collabLabel.Name = "collabLabel";
            this.collabLabel.Size = new System.Drawing.Size(88, 13);
            this.collabLabel.TabIndex = 26;
            this.collabLabel.Text = "Completion Style:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 27;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 442);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Availability:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 458);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 247);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // collabBox
            // 
            this.collabBox.FormattingEnabled = true;
            this.collabBox.Items.AddRange(new object[] {
            "In Person",
            "Virtual",
            "ASAP",
            "Collaboratively",
            "Structured Meeting",
            "Laissez-faire",
            "High fidelity",
            "Last Minute"});
            this.collabBox.Location = new System.Drawing.Point(375, 159);
            this.collabBox.Name = "collabBox";
            this.collabBox.Size = new System.Drawing.Size(121, 21);
            this.collabBox.TabIndex = 32;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(372, 192);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(32, 13);
            this.roleLabel.TabIndex = 33;
            this.roleLabel.Text = "Role:";
            // 
            // roleBox
            // 
            this.roleBox.Location = new System.Drawing.Point(375, 208);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(100, 20);
            this.roleBox.TabIndex = 34;
            // 
            // workEthic
            // 
            this.workEthic.Location = new System.Drawing.Point(375, 75);
            this.workEthic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.workEthic.Name = "workEthic";
            this.workEthic.Size = new System.Drawing.Size(120, 20);
            this.workEthic.TabIndex = 35;
            // 
            // reliabLabel
            // 
            this.reliabLabel.AutoSize = true;
            this.reliabLabel.Location = new System.Drawing.Point(666, 55);
            this.reliabLabel.Name = "reliabLabel";
            this.reliabLabel.Size = new System.Drawing.Size(54, 13);
            this.reliabLabel.TabIndex = 36;
            this.reliabLabel.Text = "Reliability:";
            // 
            // reliabNum
            // 
            this.reliabNum.Location = new System.Drawing.Point(669, 74);
            this.reliabNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.reliabNum.Name = "reliabNum";
            this.reliabNum.Size = new System.Drawing.Size(120, 20);
            this.reliabNum.TabIndex = 37;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = DesktopApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // majorBox
            // 
            this.majorBox.FormattingEnabled = true;
            this.majorBox.Items.AddRange(new object[] {
            "Computer Science General",
            "Information Systems (IS)",
            "Information Technology (IT)"});
            this.majorBox.Location = new System.Drawing.Point(53, 204);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(155, 21);
            this.majorBox.TabIndex = 22;
            this.majorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "viewStrip";
            // 
            // ViewDropDown
            // 
            this.ViewDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDbItem});
            this.ViewDropDown.Name = "ViewDropDown";
            this.ViewDropDown.Size = new System.Drawing.Size(45, 22);
            this.ViewDropDown.Text = "View";
            // 
            // viewDbItem
            // 
            this.viewDbItem.Name = "viewDbItem";
            this.viewDbItem.Size = new System.Drawing.Size(139, 22);
            this.viewDbItem.Text = "StudentData";
            this.viewDbItem.Click += new System.EventHandler(this.viewDbItem_Click);
            // 
            // studentPref
            // 
            this.studentPref.Location = new System.Drawing.Point(375, 120);
            this.studentPref.Name = "studentPref";
            this.studentPref.Size = new System.Drawing.Size(100, 20);
            this.studentPref.TabIndex = 39;
            // 
            // availPicker
            // 
            this.availPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.availPicker.Location = new System.Drawing.Point(172, 423);
            this.availPicker.MinDate = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            this.availPicker.Name = "availPicker";
            this.availPicker.Size = new System.Drawing.Size(200, 20);
            this.availPicker.TabIndex = 40;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1001, 749);
            this.Controls.Add(this.availPicker);
            this.Controls.Add(this.studentPref);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reliabNum);
            this.Controls.Add(this.reliabLabel);
            this.Controls.Add(this.workEthic);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.collabBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.collabLabel);
            this.Controls.Add(this.studPrefLabel);
            this.Controls.Add(this.wrkEthicLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.majorBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "StudentFormation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workEthic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reliabNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label wrkEthicLabel;
        private System.Windows.Forms.Label studPrefLabel;
        private System.Windows.Forms.Label collabLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox collabBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox roleBox;
        private System.Windows.Forms.NumericUpDown workEthic;
        private System.Windows.Forms.Label reliabLabel;
        private System.Windows.Forms.NumericUpDown reliabNum;
        private System.Windows.Forms.ComboBox majorBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ViewDropDown;
        private System.Windows.Forms.ToolStripMenuItem viewDbItem;
        private System.Windows.Forms.TextBox studentPref;
        private System.Windows.Forms.DateTimePicker availPicker;
    }
}

