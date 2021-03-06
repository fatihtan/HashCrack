namespace UI.Desktop
{
    partial class FormMain
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
            this.txtCharsBigAZ = new System.Windows.Forms.TextBox();
            this.txtCharsSmallAZ = new System.Windows.Forms.TextBox();
            this.cboxCharsBigAZ = new System.Windows.Forms.CheckBox();
            this.cboxCharsSmallAZ = new System.Windows.Forms.CheckBox();
            this.cboxCharsNumbers = new System.Windows.Forms.CheckBox();
            this.txtCharsNumbers = new System.Windows.Forms.TextBox();
            this.cboxIncludeCharsAdditional = new System.Windows.Forms.CheckBox();
            this.txtCharsAdditional = new System.Windows.Forms.TextBox();
            this.btnStartBruteForce = new System.Windows.Forms.Button();
            this.cboxEncryptionAlgorithm = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblEncryptionAlgorithm = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cboxIncludeSpace = new System.Windows.Forms.CheckBox();
            this.txtCharsSpace = new System.Windows.Forms.TextBox();
            this.lblMinPasswordLength = new System.Windows.Forms.Label();
            this.nudMinPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPasswordLength = new System.Windows.Forms.Label();
            this.cboxExactChar = new System.Windows.Forms.CheckBox();
            this.txtExactChar = new System.Windows.Forms.TextBox();
            this.btnSetExactChar = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharsBigAZ
            // 
            this.txtCharsBigAZ.Enabled = false;
            this.txtCharsBigAZ.Location = new System.Drawing.Point(160, 219);
            this.txtCharsBigAZ.Name = "txtCharsBigAZ";
            this.txtCharsBigAZ.ReadOnly = true;
            this.txtCharsBigAZ.Size = new System.Drawing.Size(618, 20);
            this.txtCharsBigAZ.TabIndex = 0;
            this.txtCharsBigAZ.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // txtCharsSmallAZ
            // 
            this.txtCharsSmallAZ.Enabled = false;
            this.txtCharsSmallAZ.Location = new System.Drawing.Point(160, 245);
            this.txtCharsSmallAZ.Name = "txtCharsSmallAZ";
            this.txtCharsSmallAZ.ReadOnly = true;
            this.txtCharsSmallAZ.Size = new System.Drawing.Size(618, 20);
            this.txtCharsSmallAZ.TabIndex = 1;
            this.txtCharsSmallAZ.Text = "abcdefghijklmnopqrstuvwxyz";
            // 
            // cboxCharsBigAZ
            // 
            this.cboxCharsBigAZ.AutoSize = true;
            this.cboxCharsBigAZ.Location = new System.Drawing.Point(41, 221);
            this.cboxCharsBigAZ.Name = "cboxCharsBigAZ";
            this.cboxCharsBigAZ.Size = new System.Drawing.Size(43, 17);
            this.cboxCharsBigAZ.TabIndex = 2;
            this.cboxCharsBigAZ.Tag = "txtCharsBigAZ";
            this.cboxCharsBigAZ.Text = "A-Z";
            this.cboxCharsBigAZ.UseVisualStyleBackColor = true;
            this.cboxCharsBigAZ.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // cboxCharsSmallAZ
            // 
            this.cboxCharsSmallAZ.AutoSize = true;
            this.cboxCharsSmallAZ.Location = new System.Drawing.Point(41, 247);
            this.cboxCharsSmallAZ.Name = "cboxCharsSmallAZ";
            this.cboxCharsSmallAZ.Size = new System.Drawing.Size(40, 17);
            this.cboxCharsSmallAZ.TabIndex = 3;
            this.cboxCharsSmallAZ.Tag = "txtCharsSmallAZ";
            this.cboxCharsSmallAZ.Text = "a-z";
            this.cboxCharsSmallAZ.UseVisualStyleBackColor = true;
            this.cboxCharsSmallAZ.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // cboxCharsNumbers
            // 
            this.cboxCharsNumbers.AutoSize = true;
            this.cboxCharsNumbers.Location = new System.Drawing.Point(41, 273);
            this.cboxCharsNumbers.Name = "cboxCharsNumbers";
            this.cboxCharsNumbers.Size = new System.Drawing.Size(68, 17);
            this.cboxCharsNumbers.TabIndex = 5;
            this.cboxCharsNumbers.Tag = "txtCharsNumbers";
            this.cboxCharsNumbers.Text = "Numbers";
            this.cboxCharsNumbers.UseVisualStyleBackColor = true;
            this.cboxCharsNumbers.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // txtCharsNumbers
            // 
            this.txtCharsNumbers.Enabled = false;
            this.txtCharsNumbers.Location = new System.Drawing.Point(160, 271);
            this.txtCharsNumbers.Name = "txtCharsNumbers";
            this.txtCharsNumbers.ReadOnly = true;
            this.txtCharsNumbers.Size = new System.Drawing.Size(618, 20);
            this.txtCharsNumbers.TabIndex = 4;
            this.txtCharsNumbers.Text = "0123456789";
            // 
            // cboxIncludeCharsAdditional
            // 
            this.cboxIncludeCharsAdditional.AutoSize = true;
            this.cboxIncludeCharsAdditional.Location = new System.Drawing.Point(41, 325);
            this.cboxIncludeCharsAdditional.Name = "cboxIncludeCharsAdditional";
            this.cboxIncludeCharsAdditional.Size = new System.Drawing.Size(102, 17);
            this.cboxIncludeCharsAdditional.TabIndex = 7;
            this.cboxIncludeCharsAdditional.Tag = "txtCharsAdditional";
            this.cboxIncludeCharsAdditional.Text = "Additional Chars";
            this.cboxIncludeCharsAdditional.UseVisualStyleBackColor = true;
            this.cboxIncludeCharsAdditional.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // txtCharsAdditional
            // 
            this.txtCharsAdditional.Enabled = false;
            this.txtCharsAdditional.Location = new System.Drawing.Point(160, 323);
            this.txtCharsAdditional.Name = "txtCharsAdditional";
            this.txtCharsAdditional.Size = new System.Drawing.Size(618, 20);
            this.txtCharsAdditional.TabIndex = 6;
            // 
            // btnStartBruteForce
            // 
            this.btnStartBruteForce.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnStartBruteForce.FlatAppearance.BorderSize = 0;
            this.btnStartBruteForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBruteForce.Location = new System.Drawing.Point(160, 360);
            this.btnStartBruteForce.Name = "btnStartBruteForce";
            this.btnStartBruteForce.Size = new System.Drawing.Size(142, 32);
            this.btnStartBruteForce.TabIndex = 8;
            this.btnStartBruteForce.Text = "Start Brute Force";
            this.btnStartBruteForce.UseVisualStyleBackColor = false;
            this.btnStartBruteForce.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboxEncryptionAlgorithm
            // 
            this.cboxEncryptionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEncryptionAlgorithm.FormattingEnabled = true;
            this.cboxEncryptionAlgorithm.Location = new System.Drawing.Point(160, 37);
            this.cboxEncryptionAlgorithm.Name = "cboxEncryptionAlgorithm";
            this.cboxEncryptionAlgorithm.Size = new System.Drawing.Size(618, 21);
            this.cboxEncryptionAlgorithm.TabIndex = 9;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(160, 64);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(618, 20);
            this.txtOutput.TabIndex = 10;
            // 
            // lblEncryptionAlgorithm
            // 
            this.lblEncryptionAlgorithm.AutoSize = true;
            this.lblEncryptionAlgorithm.Location = new System.Drawing.Point(38, 40);
            this.lblEncryptionAlgorithm.Name = "lblEncryptionAlgorithm";
            this.lblEncryptionAlgorithm.Size = new System.Drawing.Size(103, 13);
            this.lblEncryptionAlgorithm.TabIndex = 11;
            this.lblEncryptionAlgorithm.Text = "Encryption Algorithm";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(38, 67);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "Output";
            // 
            // cboxIncludeSpace
            // 
            this.cboxIncludeSpace.AutoSize = true;
            this.cboxIncludeSpace.Location = new System.Drawing.Point(41, 299);
            this.cboxIncludeSpace.Name = "cboxIncludeSpace";
            this.cboxIncludeSpace.Size = new System.Drawing.Size(95, 17);
            this.cboxIncludeSpace.TabIndex = 13;
            this.cboxIncludeSpace.Tag = "txtCharsSpace";
            this.cboxIncludeSpace.Text = "Include Space";
            this.cboxIncludeSpace.UseVisualStyleBackColor = true;
            this.cboxIncludeSpace.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // txtCharsSpace
            // 
            this.txtCharsSpace.Enabled = false;
            this.txtCharsSpace.Location = new System.Drawing.Point(160, 297);
            this.txtCharsSpace.Name = "txtCharsSpace";
            this.txtCharsSpace.ReadOnly = true;
            this.txtCharsSpace.Size = new System.Drawing.Size(618, 20);
            this.txtCharsSpace.TabIndex = 14;
            this.txtCharsSpace.Text = "Space is NOT included";
            // 
            // lblMinPasswordLength
            // 
            this.lblMinPasswordLength.AutoSize = true;
            this.lblMinPasswordLength.Location = new System.Drawing.Point(38, 93);
            this.lblMinPasswordLength.Name = "lblMinPasswordLength";
            this.lblMinPasswordLength.Size = new System.Drawing.Size(109, 13);
            this.lblMinPasswordLength.TabIndex = 16;
            this.lblMinPasswordLength.Text = "Min Password Length";
            // 
            // nudMinPasswordLength
            // 
            this.nudMinPasswordLength.Location = new System.Drawing.Point(160, 91);
            this.nudMinPasswordLength.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMinPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinPasswordLength.Name = "nudMinPasswordLength";
            this.nudMinPasswordLength.Size = new System.Drawing.Size(618, 20);
            this.nudMinPasswordLength.TabIndex = 17;
            this.nudMinPasswordLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMaxPasswordLength
            // 
            this.nudMaxPasswordLength.Location = new System.Drawing.Point(160, 117);
            this.nudMaxPasswordLength.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMaxPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxPasswordLength.Name = "nudMaxPasswordLength";
            this.nudMaxPasswordLength.Size = new System.Drawing.Size(618, 20);
            this.nudMaxPasswordLength.TabIndex = 19;
            this.nudMaxPasswordLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblMaxPasswordLength
            // 
            this.lblMaxPasswordLength.AutoSize = true;
            this.lblMaxPasswordLength.Location = new System.Drawing.Point(38, 119);
            this.lblMaxPasswordLength.Name = "lblMaxPasswordLength";
            this.lblMaxPasswordLength.Size = new System.Drawing.Size(112, 13);
            this.lblMaxPasswordLength.TabIndex = 18;
            this.lblMaxPasswordLength.Text = "Max Password Length";
            // 
            // cboxExactChar
            // 
            this.cboxExactChar.AutoSize = true;
            this.cboxExactChar.Location = new System.Drawing.Point(41, 147);
            this.cboxExactChar.Name = "cboxExactChar";
            this.cboxExactChar.Size = new System.Drawing.Size(78, 17);
            this.cboxExactChar.TabIndex = 20;
            this.cboxExactChar.Tag = "btnSetExactChar";
            this.cboxExactChar.Text = "Exact Char";
            this.cboxExactChar.UseVisualStyleBackColor = true;
            this.cboxExactChar.CheckedChanged += new System.EventHandler(this.cboxChars_CheckedChanged);
            // 
            // txtExactChar
            // 
            this.txtExactChar.Location = new System.Drawing.Point(255, 145);
            this.txtExactChar.Name = "txtExactChar";
            this.txtExactChar.ReadOnly = true;
            this.txtExactChar.Size = new System.Drawing.Size(523, 20);
            this.txtExactChar.TabIndex = 21;
            // 
            // btnSetExactChar
            // 
            this.btnSetExactChar.Enabled = false;
            this.btnSetExactChar.Location = new System.Drawing.Point(160, 143);
            this.btnSetExactChar.Name = "btnSetExactChar";
            this.btnSetExactChar.Size = new System.Drawing.Size(89, 23);
            this.btnSetExactChar.TabIndex = 22;
            this.btnSetExactChar.Text = "Set";
            this.btnSetExactChar.UseVisualStyleBackColor = true;
            this.btnSetExactChar.Click += new System.EventHandler(this.btnSetExactChar_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(318, 360);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 32);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(476, 360);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(142, 32);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(636, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 32);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(817, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSetExactChar);
            this.Controls.Add(this.txtExactChar);
            this.Controls.Add(this.cboxExactChar);
            this.Controls.Add(this.nudMaxPasswordLength);
            this.Controls.Add(this.lblMaxPasswordLength);
            this.Controls.Add(this.nudMinPasswordLength);
            this.Controls.Add(this.lblMinPasswordLength);
            this.Controls.Add(this.txtCharsSpace);
            this.Controls.Add(this.cboxIncludeSpace);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEncryptionAlgorithm);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cboxEncryptionAlgorithm);
            this.Controls.Add(this.btnStartBruteForce);
            this.Controls.Add(this.cboxIncludeCharsAdditional);
            this.Controls.Add(this.txtCharsAdditional);
            this.Controls.Add(this.cboxCharsNumbers);
            this.Controls.Add(this.txtCharsNumbers);
            this.Controls.Add(this.cboxCharsSmallAZ);
            this.Controls.Add(this.cboxCharsBigAZ);
            this.Controls.Add(this.txtCharsSmallAZ);
            this.Controls.Add(this.txtCharsBigAZ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Crack";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharsBigAZ;
        private System.Windows.Forms.TextBox txtCharsSmallAZ;
        private System.Windows.Forms.CheckBox cboxCharsBigAZ;
        private System.Windows.Forms.CheckBox cboxCharsSmallAZ;
        private System.Windows.Forms.CheckBox cboxCharsNumbers;
        private System.Windows.Forms.TextBox txtCharsNumbers;
        private System.Windows.Forms.CheckBox cboxIncludeCharsAdditional;
        private System.Windows.Forms.TextBox txtCharsAdditional;
        private System.Windows.Forms.Button btnStartBruteForce;
        private System.Windows.Forms.ComboBox cboxEncryptionAlgorithm;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblEncryptionAlgorithm;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox cboxIncludeSpace;
        private System.Windows.Forms.TextBox txtCharsSpace;
        private System.Windows.Forms.Label lblMinPasswordLength;
        private System.Windows.Forms.NumericUpDown nudMinPasswordLength;
        private System.Windows.Forms.NumericUpDown nudMaxPasswordLength;
        private System.Windows.Forms.Label lblMaxPasswordLength;
        private System.Windows.Forms.CheckBox cboxExactChar;
        private System.Windows.Forms.TextBox txtExactChar;
        private System.Windows.Forms.Button btnSetExactChar;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

