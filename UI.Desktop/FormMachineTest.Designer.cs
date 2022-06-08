namespace UI.Desktop
{
    partial class FormMachineTest
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
            this.nudGuidCount = new System.Windows.Forms.NumericUpDown();
            this.lblGuidCount = new System.Windows.Forms.Label();
            this.lblEncryptionAlgorithm = new System.Windows.Forms.Label();
            this.cboxEncryptionAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudLaps = new System.Windows.Forms.NumericUpDown();
            this.lblLaps = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuidCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaps)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGuidCount
            // 
            this.nudGuidCount.Location = new System.Drawing.Point(164, 106);
            this.nudGuidCount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudGuidCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuidCount.Name = "nudGuidCount";
            this.nudGuidCount.Size = new System.Drawing.Size(256, 20);
            this.nudGuidCount.TabIndex = 21;
            this.nudGuidCount.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblGuidCount
            // 
            this.lblGuidCount.AutoSize = true;
            this.lblGuidCount.Location = new System.Drawing.Point(42, 108);
            this.lblGuidCount.Name = "lblGuidCount";
            this.lblGuidCount.Size = new System.Drawing.Size(60, 13);
            this.lblGuidCount.TabIndex = 20;
            this.lblGuidCount.Text = "Guid Count";
            // 
            // lblEncryptionAlgorithm
            // 
            this.lblEncryptionAlgorithm.AutoSize = true;
            this.lblEncryptionAlgorithm.Location = new System.Drawing.Point(42, 82);
            this.lblEncryptionAlgorithm.Name = "lblEncryptionAlgorithm";
            this.lblEncryptionAlgorithm.Size = new System.Drawing.Size(103, 13);
            this.lblEncryptionAlgorithm.TabIndex = 19;
            this.lblEncryptionAlgorithm.Text = "Encryption Algorithm";
            // 
            // cboxEncryptionAlgorithm
            // 
            this.cboxEncryptionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEncryptionAlgorithm.FormattingEnabled = true;
            this.cboxEncryptionAlgorithm.Location = new System.Drawing.Point(164, 79);
            this.cboxEncryptionAlgorithm.Name = "cboxEncryptionAlgorithm";
            this.cboxEncryptionAlgorithm.Size = new System.Drawing.Size(256, 21);
            this.cboxEncryptionAlgorithm.TabIndex = 18;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(164, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 25);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Save";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudLaps
            // 
            this.nudLaps.Location = new System.Drawing.Point(164, 132);
            this.nudLaps.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLaps.Name = "nudLaps";
            this.nudLaps.Size = new System.Drawing.Size(256, 20);
            this.nudLaps.TabIndex = 24;
            this.nudLaps.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblLaps
            // 
            this.lblLaps.AutoSize = true;
            this.lblLaps.Location = new System.Drawing.Point(42, 134);
            this.lblLaps.Name = "lblLaps";
            this.lblLaps.Size = new System.Drawing.Size(30, 13);
            this.lblLaps.TabIndex = 23;
            this.lblLaps.Text = "Laps";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 390);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(468, 19);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "(Guid Count x Laps) = Average";
            // 
            // FormMachineTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(492, 418);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.nudLaps);
            this.Controls.Add(this.lblLaps);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudGuidCount);
            this.Controls.Add(this.lblGuidCount);
            this.Controls.Add(this.lblEncryptionAlgorithm);
            this.Controls.Add(this.cboxEncryptionAlgorithm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMachineTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Test";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuidCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGuidCount;
        private System.Windows.Forms.Label lblGuidCount;
        private System.Windows.Forms.Label lblEncryptionAlgorithm;
        private System.Windows.Forms.ComboBox cboxEncryptionAlgorithm;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudLaps;
        private System.Windows.Forms.Label lblLaps;
        private System.Windows.Forms.Label lblDescription;

    }
}