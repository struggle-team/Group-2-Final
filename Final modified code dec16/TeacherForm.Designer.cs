namespace DesktopApp1
{
    partial class TeacherForm
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
            this.frmLabel = new System.Windows.Forms.Label();
            this.quesLabel = new System.Windows.Forms.Label();
            this.numLbl = new System.Windows.Forms.NumericUpDown();
            this.checkBox = new System.Windows.Forms.CheckedListBox();
            this.subButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numLbl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLabel.Location = new System.Drawing.Point(40, 24);
            this.frmLabel.Name = "frmLabel";
            this.frmLabel.Size = new System.Drawing.Size(306, 43);
            this.frmLabel.TabIndex = 0;
            this.frmLabel.Text = "Group Formation Generator";
            // 
            // quesLabel
            // 
            this.quesLabel.AutoSize = true;
            this.quesLabel.Location = new System.Drawing.Point(45, 91);
            this.quesLabel.Name = "quesLabel";
            this.quesLabel.Size = new System.Drawing.Size(326, 13);
            this.quesLabel.TabIndex = 2;
            this.quesLabel.Text = "Would you like to specify number of groups or numbers of students?";
            // 
            // numLbl
            // 
            this.numLbl.Location = new System.Drawing.Point(236, 140);
            this.numLbl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(120, 20);
            this.numLbl.TabIndex = 6;
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBox.FormattingEnabled = true;
            this.checkBox.Items.AddRange(new object[] {
            "Number of Students:",
            "Number of Groups:"});
            this.checkBox.Location = new System.Drawing.Point(48, 140);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(120, 90);
            this.checkBox.TabIndex = 7;
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(236, 207);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 8;
            this.subButton.Text = "Submit";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(468, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 316);
            this.listBox1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // studentDataToolStripMenuItem
            // 
            this.studentDataToolStripMenuItem.Name = "studentDataToolStripMenuItem";
            this.studentDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentDataToolStripMenuItem.Text = "Student Data";
            this.studentDataToolStripMenuItem.Click += new System.EventHandler(this.studentDataToolStripMenuItem_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.numLbl);
            this.Controls.Add(this.quesLabel);
            this.Controls.Add(this.frmLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.numLbl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmLabel;
        private System.Windows.Forms.Label quesLabel;
        private System.Windows.Forms.NumericUpDown numLbl;
        private System.Windows.Forms.CheckedListBox checkBox;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDataToolStripMenuItem;
    }
}