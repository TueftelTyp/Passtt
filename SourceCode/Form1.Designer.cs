namespace PassGen
{
    partial class PassForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassForm));
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecialChars = new System.Windows.Forms.CheckBox();
            this.chkSpaces = new System.Windows.Forms.CheckBox();
            this.nudPasswordCount = new System.Windows.Forms.NumericUpDown();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lstPasswords = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.urlLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Location = new System.Drawing.Point(113, 17);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(47, 17);
            this.chkUppercase.TabIndex = 2;
            this.chkUppercase.Text = "ABC";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.Location = new System.Drawing.Point(166, 17);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(44, 17);
            this.chkLowercase.TabIndex = 3;
            this.chkLowercase.Text = "abc";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(216, 18);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(44, 17);
            this.chkNumbers.TabIndex = 4;
            this.chkNumbers.Text = "123";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChars
            // 
            this.chkSpecialChars.AutoSize = true;
            this.chkSpecialChars.Checked = true;
            this.chkSpecialChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecialChars.Location = new System.Drawing.Point(266, 18);
            this.chkSpecialChars.Name = "chkSpecialChars";
            this.chkSpecialChars.Size = new System.Drawing.Size(45, 17);
            this.chkSpecialChars.TabIndex = 5;
            this.chkSpecialChars.Text = "#=+";
            this.chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // chkSpaces
            // 
            this.chkSpaces.AutoSize = true;
            this.chkSpaces.Location = new System.Drawing.Point(316, 18);
            this.chkSpaces.Name = "chkSpaces";
            this.chkSpaces.Size = new System.Drawing.Size(55, 17);
            this.chkSpaces.TabIndex = 6;
            this.chkSpaces.Text = "space";
            this.chkSpaces.UseVisualStyleBackColor = true;
            // 
            // nudPasswordCount
            // 
            this.nudPasswordCount.Location = new System.Drawing.Point(56, 15);
            this.nudPasswordCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPasswordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasswordCount.Name = "nudPasswordCount";
            this.nudPasswordCount.Size = new System.Drawing.Size(39, 20);
            this.nudPasswordCount.TabIndex = 1;
            this.nudPasswordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Location = new System.Drawing.Point(56, 45);
            this.nudPasswordLength.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(39, 20);
            this.nudPasswordLength.TabIndex = 7;
            this.nudPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(7, 47);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 17);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount:";
            // 
            // lstPasswords
            // 
            this.lstPasswords.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPasswords.FormattingEnabled = true;
            this.lstPasswords.ItemHeight = 23;
            this.lstPasswords.Location = new System.Drawing.Point(10, 85);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.Size = new System.Drawing.Size(361, 234);
            this.lstPasswords.TabIndex = 12;
            this.lstPasswords.TabStop = false;
            this.toolTip1.SetToolTip(this.lstPasswords, "Copied !");
            this.lstPasswords.Click += new System.EventHandler(this.lstPasswords_Click);
            this.lstPasswords.DoubleClick += new System.EventHandler(this.lstPasswords_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(113, 45);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(258, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.urlLabel.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(353, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 9);
            this.urlLabel.TabIndex = 13;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "GitHub";
            this.urlLabel.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 329);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstPasswords);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.nudPasswordLength);
            this.Controls.Add(this.nudPasswordCount);
            this.Controls.Add(this.chkSpaces);
            this.Controls.Add(this.chkSpecialChars);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkLowercase);
            this.Controls.Add(this.chkUppercase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passtt";
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSpecialChars;
        private System.Windows.Forms.CheckBox chkSpaces;
        private System.Windows.Forms.NumericUpDown nudPasswordCount;
        private System.Windows.Forms.NumericUpDown nudPasswordLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ListBox lstPasswords;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel urlLabel;
    }
}

