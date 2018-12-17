namespace DesktopApp1
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.quesLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(517, 34);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(201, 57);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // quesLabel
            // 
            this.quesLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesLabel.Location = new System.Drawing.Point(521, 132);
            this.quesLabel.Name = "quesLabel";
            this.quesLabel.Size = new System.Drawing.Size(180, 33);
            this.quesLabel.TabIndex = 1;
            this.quesLabel.Text = "Are you a:";
            this.quesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBox.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.FormattingEnabled = true;
            this.checkBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.checkBox.Location = new System.Drawing.Point(538, 183);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(180, 129);
            this.checkBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(579, 289);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(725, 369);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.quesLabel);
            this.Controls.Add(this.welcomeLabel);
            this.DoubleBuffered = true;
            this.Name = "StartPage";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label quesLabel;
        private System.Windows.Forms.CheckedListBox checkBox;
        private System.Windows.Forms.Button submitButton;
    }
}