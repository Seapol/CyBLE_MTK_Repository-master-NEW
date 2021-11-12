namespace CyBLE_MTK_Application
{
    partial class MTKTestProgramAllDialog
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndRadioButton = new System.Windows.Forms.RadioButton();
            this.BegningRadioButton = new System.Windows.Forms.RadioButton();
            this.HexFilePathTextBox = new System.Windows.Forms.TextBox();
            this.HexGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenHEXFileButton = new System.Windows.Forms.Button();
            this.ModuleCheckGroupBox = new System.Windows.Forms.GroupBox();
            this.BCCheckBox = new System.Windows.Forms.CheckBox();
            this.BCTextBox = new System.Windows.Forms.TextBox();
            this.DelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MACACheckBox = new System.Windows.Forms.CheckBox();
            this.PVCheckBox = new System.Windows.Forms.CheckBox();
            this.HWIDCheckBox = new System.Windows.Forms.CheckBox();
            this.BSVCheckBox = new System.Windows.Forms.CheckBox();
            this.AVCheckBox = new System.Windows.Forms.CheckBox();
            this.MACATtextBox = new System.Windows.Forms.TextBox();
            this.HWIDTextBox = new System.Windows.Forms.TextBox();
            this.PVTextBox = new System.Windows.Forms.TextBox();
            this.BLESVTextBox = new System.Windows.Forms.TextBox();
            this.AVTextBox = new System.Windows.Forms.TextBox();
            this.ModuleFWValidCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnableChecksumBegin = new System.Windows.Forms.CheckBox();
            this.EnableChecksumEnd = new System.Windows.Forms.CheckBox();
            this.textBoxChecksumBegin = new System.Windows.Forms.TextBox();
            this.textBoxChecksumEnd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.HexGroupBox.SuspendLayout();
            this.ModuleCheckGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(229, 582);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 28);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "&Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(121, 582);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndRadioButton);
            this.groupBox1.Controls.Add(this.BegningRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(417, 55);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program all devices at the";
            // 
            // EndRadioButton
            // 
            this.EndRadioButton.AutoSize = true;
            this.EndRadioButton.Location = new System.Drawing.Point(260, 23);
            this.EndRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndRadioButton.Name = "EndRadioButton";
            this.EndRadioButton.Size = new System.Drawing.Size(143, 21);
            this.EndRadioButton.TabIndex = 1;
            this.EndRadioButton.TabStop = true;
            this.EndRadioButton.Text = "end of each batch";
            this.EndRadioButton.UseVisualStyleBackColor = true;
            this.EndRadioButton.CheckedChanged += new System.EventHandler(this.EndRadioButton_CheckedChanged);
            // 
            // BegningRadioButton
            // 
            this.BegningRadioButton.AutoSize = true;
            this.BegningRadioButton.Checked = true;
            this.BegningRadioButton.Location = new System.Drawing.Point(8, 23);
            this.BegningRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BegningRadioButton.Name = "BegningRadioButton";
            this.BegningRadioButton.Size = new System.Drawing.Size(170, 21);
            this.BegningRadioButton.TabIndex = 0;
            this.BegningRadioButton.TabStop = true;
            this.BegningRadioButton.Text = "begning of each batch";
            this.BegningRadioButton.UseVisualStyleBackColor = true;
            this.BegningRadioButton.CheckedChanged += new System.EventHandler(this.BegningRadioButton_CheckedChanged);
            // 
            // HexFilePathTextBox
            // 
            this.HexFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexFilePathTextBox.Location = new System.Drawing.Point(8, 20);
            this.HexFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.HexFilePathTextBox.Name = "HexFilePathTextBox";
            this.HexFilePathTextBox.ReadOnly = true;
            this.HexFilePathTextBox.Size = new System.Drawing.Size(368, 15);
            this.HexFilePathTextBox.TabIndex = 0;
            this.HexFilePathTextBox.TabStop = false;
            // 
            // HexGroupBox
            // 
            this.HexGroupBox.Controls.Add(this.OpenHEXFileButton);
            this.HexGroupBox.Controls.Add(this.HexFilePathTextBox);
            this.HexGroupBox.Location = new System.Drawing.Point(16, 79);
            this.HexGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HexGroupBox.Name = "HexGroupBox";
            this.HexGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HexGroupBox.Size = new System.Drawing.Size(419, 49);
            this.HexGroupBox.TabIndex = 37;
            this.HexGroupBox.TabStop = false;
            this.HexGroupBox.Text = "HEX File Path";
            // 
            // OpenHEXFileButton
            // 
            this.OpenHEXFileButton.Location = new System.Drawing.Point(380, 14);
            this.OpenHEXFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenHEXFileButton.Name = "OpenHEXFileButton";
            this.OpenHEXFileButton.Size = new System.Drawing.Size(35, 28);
            this.OpenHEXFileButton.TabIndex = 2;
            this.OpenHEXFileButton.Text = "...";
            this.OpenHEXFileButton.UseVisualStyleBackColor = true;
            this.OpenHEXFileButton.Click += new System.EventHandler(this.OpenHEXFileButton_Click);
            // 
            // ModuleCheckGroupBox
            // 
            this.ModuleCheckGroupBox.Controls.Add(this.BCCheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.BCTextBox);
            this.ModuleCheckGroupBox.Controls.Add(this.DelayNumericUpDown);
            this.ModuleCheckGroupBox.Controls.Add(this.label3);
            this.ModuleCheckGroupBox.Controls.Add(this.label2);
            this.ModuleCheckGroupBox.Controls.Add(this.EventTypeComboBox);
            this.ModuleCheckGroupBox.Controls.Add(this.label1);
            this.ModuleCheckGroupBox.Controls.Add(this.MACACheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.PVCheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.HWIDCheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.BSVCheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.AVCheckBox);
            this.ModuleCheckGroupBox.Controls.Add(this.MACATtextBox);
            this.ModuleCheckGroupBox.Controls.Add(this.HWIDTextBox);
            this.ModuleCheckGroupBox.Controls.Add(this.PVTextBox);
            this.ModuleCheckGroupBox.Controls.Add(this.BLESVTextBox);
            this.ModuleCheckGroupBox.Controls.Add(this.AVTextBox);
            this.ModuleCheckGroupBox.Enabled = false;
            this.ModuleCheckGroupBox.Location = new System.Drawing.Point(16, 276);
            this.ModuleCheckGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModuleCheckGroupBox.Name = "ModuleCheckGroupBox";
            this.ModuleCheckGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModuleCheckGroupBox.Size = new System.Drawing.Size(419, 299);
            this.ModuleCheckGroupBox.TabIndex = 38;
            this.ModuleCheckGroupBox.TabStop = false;
            this.ModuleCheckGroupBox.Text = "Module Firmware Check Settings";
            // 
            // BCCheckBox
            // 
            this.BCCheckBox.AutoSize = true;
            this.BCCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCCheckBox.Location = new System.Drawing.Point(76, 224);
            this.BCCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BCCheckBox.Name = "BCCheckBox";
            this.BCCheckBox.Size = new System.Drawing.Size(130, 21);
            this.BCCheckBox.TabIndex = 13;
            this.BCCheckBox.Text = "Boot Cause (C):";
            this.BCCheckBox.UseVisualStyleBackColor = true;
            this.BCCheckBox.CheckedChanged += new System.EventHandler(this.BCCheckBox_CheckedChanged);
            // 
            // BCTextBox
            // 
            this.BCTextBox.Enabled = false;
            this.BCTextBox.Location = new System.Drawing.Point(217, 222);
            this.BCTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BCTextBox.Name = "BCTextBox";
            this.BCTextBox.Size = new System.Drawing.Size(172, 22);
            this.BCTextBox.TabIndex = 14;
            // 
            // DelayNumericUpDown
            // 
            this.DelayNumericUpDown.Location = new System.Drawing.Point(176, 28);
            this.DelayNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelayNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DelayNumericUpDown.Name = "DelayNumericUpDown";
            this.DelayNumericUpDown.Size = new System.Drawing.Size(85, 22);
            this.DelayNumericUpDown.TabIndex = 3;
            this.DelayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelayNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "ms before checks.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Capture UART lines for";
            // 
            // EventTypeComboBox
            // 
            this.EventTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventTypeComboBox.FormattingEnabled = true;
            this.EventTypeComboBox.Items.AddRange(new object[] {
            "BOOT",
            "TFAC"});
            this.EventTypeComboBox.Location = new System.Drawing.Point(217, 60);
            this.EventTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EventTypeComboBox.Name = "EventTypeComboBox";
            this.EventTypeComboBox.Size = new System.Drawing.Size(172, 24);
            this.EventTypeComboBox.TabIndex = 4;
            this.EventTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.EventTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Type:";
            // 
            // MACACheckBox
            // 
            this.MACACheckBox.AutoSize = true;
            this.MACACheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MACACheckBox.Location = new System.Drawing.Point(64, 256);
            this.MACACheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MACACheckBox.Name = "MACACheckBox";
            this.MACACheckBox.Size = new System.Drawing.Size(142, 21);
            this.MACACheckBox.TabIndex = 15;
            this.MACACheckBox.Text = "MAC Address (A):";
            this.MACACheckBox.UseVisualStyleBackColor = true;
            this.MACACheckBox.CheckedChanged += new System.EventHandler(this.MACACheckBox_CheckedChanged);
            // 
            // PVCheckBox
            // 
            this.PVCheckBox.AutoSize = true;
            this.PVCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PVCheckBox.Location = new System.Drawing.Point(47, 160);
            this.PVCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PVCheckBox.Name = "PVCheckBox";
            this.PVCheckBox.Size = new System.Drawing.Size(161, 21);
            this.PVCheckBox.TabIndex = 9;
            this.PVCheckBox.Text = "Protocol Version (P):";
            this.PVCheckBox.UseVisualStyleBackColor = true;
            this.PVCheckBox.CheckedChanged += new System.EventHandler(this.PVCheckBox_CheckedChanged);
            // 
            // HWIDCheckBox
            // 
            this.HWIDCheckBox.AutoSize = true;
            this.HWIDCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HWIDCheckBox.Location = new System.Drawing.Point(68, 192);
            this.HWIDCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HWIDCheckBox.Name = "HWIDCheckBox";
            this.HWIDCheckBox.Size = new System.Drawing.Size(136, 21);
            this.HWIDCheckBox.TabIndex = 11;
            this.HWIDCheckBox.Text = "Hardware ID (H):";
            this.HWIDCheckBox.UseVisualStyleBackColor = true;
            this.HWIDCheckBox.CheckedChanged += new System.EventHandler(this.HWIDCheckBox_CheckedChanged);
            // 
            // BSVCheckBox
            // 
            this.BSVCheckBox.AutoSize = true;
            this.BSVCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSVCheckBox.Location = new System.Drawing.Point(31, 128);
            this.BSVCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSVCheckBox.Name = "BSVCheckBox";
            this.BSVCheckBox.Size = new System.Drawing.Size(174, 21);
            this.BSVCheckBox.TabIndex = 7;
            this.BSVCheckBox.Text = "BLE Stack Version (S):";
            this.BSVCheckBox.UseVisualStyleBackColor = true;
            this.BSVCheckBox.CheckedChanged += new System.EventHandler(this.BSVCheckBox_CheckedChanged);
            // 
            // AVCheckBox
            // 
            this.AVCheckBox.AutoSize = true;
            this.AVCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AVCheckBox.Location = new System.Drawing.Point(29, 96);
            this.AVCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AVCheckBox.Name = "AVCheckBox";
            this.AVCheckBox.Size = new System.Drawing.Size(178, 21);
            this.AVCheckBox.TabIndex = 5;
            this.AVCheckBox.Text = "Application Version (E):";
            this.AVCheckBox.UseVisualStyleBackColor = true;
            this.AVCheckBox.CheckedChanged += new System.EventHandler(this.AVCheckBox_CheckedChanged);
            // 
            // MACATtextBox
            // 
            this.MACATtextBox.Enabled = false;
            this.MACATtextBox.Location = new System.Drawing.Point(217, 254);
            this.MACATtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MACATtextBox.Name = "MACATtextBox";
            this.MACATtextBox.Size = new System.Drawing.Size(172, 22);
            this.MACATtextBox.TabIndex = 16;
            // 
            // HWIDTextBox
            // 
            this.HWIDTextBox.Enabled = false;
            this.HWIDTextBox.Location = new System.Drawing.Point(217, 190);
            this.HWIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HWIDTextBox.Name = "HWIDTextBox";
            this.HWIDTextBox.Size = new System.Drawing.Size(172, 22);
            this.HWIDTextBox.TabIndex = 12;
            // 
            // PVTextBox
            // 
            this.PVTextBox.Enabled = false;
            this.PVTextBox.Location = new System.Drawing.Point(217, 158);
            this.PVTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PVTextBox.Name = "PVTextBox";
            this.PVTextBox.Size = new System.Drawing.Size(172, 22);
            this.PVTextBox.TabIndex = 10;
            // 
            // BLESVTextBox
            // 
            this.BLESVTextBox.Enabled = false;
            this.BLESVTextBox.Location = new System.Drawing.Point(217, 126);
            this.BLESVTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLESVTextBox.Name = "BLESVTextBox";
            this.BLESVTextBox.Size = new System.Drawing.Size(172, 22);
            this.BLESVTextBox.TabIndex = 8;
            // 
            // AVTextBox
            // 
            this.AVTextBox.Enabled = false;
            this.AVTextBox.Location = new System.Drawing.Point(217, 94);
            this.AVTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AVTextBox.Name = "AVTextBox";
            this.AVTextBox.Size = new System.Drawing.Size(172, 22);
            this.AVTextBox.TabIndex = 6;
            // 
            // ModuleFWValidCheckBox
            // 
            this.ModuleFWValidCheckBox.AutoSize = true;
            this.ModuleFWValidCheckBox.Location = new System.Drawing.Point(17, 248);
            this.ModuleFWValidCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModuleFWValidCheckBox.Name = "ModuleFWValidCheckBox";
            this.ModuleFWValidCheckBox.Size = new System.Drawing.Size(233, 21);
            this.ModuleFWValidCheckBox.TabIndex = 3;
            this.ModuleFWValidCheckBox.Text = "Enable module firmware checks.";
            this.ModuleFWValidCheckBox.UseVisualStyleBackColor = true;
            this.ModuleFWValidCheckBox.CheckedChanged += new System.EventHandler(this.ModuleCheckCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxChecksumEnd);
            this.groupBox2.Controls.Add(this.textBoxChecksumBegin);
            this.groupBox2.Controls.Add(this.EnableChecksumEnd);
            this.groupBox2.Controls.Add(this.EnableChecksumBegin);
            this.groupBox2.Location = new System.Drawing.Point(17, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 93);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firmware Checksum Match";
            // 
            // EnableChecksumBegin
            // 
            this.EnableChecksumBegin.AutoSize = true;
            this.EnableChecksumBegin.Location = new System.Drawing.Point(7, 22);
            this.EnableChecksumBegin.Margin = new System.Windows.Forms.Padding(4);
            this.EnableChecksumBegin.Name = "EnableChecksumBegin";
            this.EnableChecksumBegin.Size = new System.Drawing.Size(289, 21);
            this.EnableChecksumBegin.TabIndex = 40;
            this.EnableChecksumBegin.Text = "Enable firmware checksum match (begin)";
            this.EnableChecksumBegin.UseVisualStyleBackColor = true;
            this.EnableChecksumBegin.CheckedChanged += new System.EventHandler(this.EnableChecksumBegin_CheckedChanged);
            // 
            // EnableChecksumEnd
            // 
            this.EnableChecksumEnd.AutoSize = true;
            this.EnableChecksumEnd.Location = new System.Drawing.Point(7, 51);
            this.EnableChecksumEnd.Margin = new System.Windows.Forms.Padding(4);
            this.EnableChecksumEnd.Name = "EnableChecksumEnd";
            this.EnableChecksumEnd.Size = new System.Drawing.Size(278, 21);
            this.EnableChecksumEnd.TabIndex = 41;
            this.EnableChecksumEnd.Text = "Enable firmware checksum match (end)";
            this.EnableChecksumEnd.UseVisualStyleBackColor = true;
            this.EnableChecksumEnd.CheckedChanged += new System.EventHandler(this.EnableChecksumEnd_CheckedChanged);
            // 
            // textBoxChecksumBegin
            // 
            this.textBoxChecksumBegin.Enabled = false;
            this.textBoxChecksumBegin.Location = new System.Drawing.Point(303, 21);
            this.textBoxChecksumBegin.Name = "textBoxChecksumBegin";
            this.textBoxChecksumBegin.Size = new System.Drawing.Size(100, 22);
            this.textBoxChecksumBegin.TabIndex = 42;
            this.textBoxChecksumBegin.Text = "0000";
            this.textBoxChecksumBegin.TextChanged += new System.EventHandler(this.textBoxChecksumBegin_TextChanged);
            // 
            // textBoxChecksumEnd
            // 
            this.textBoxChecksumEnd.Enabled = false;
            this.textBoxChecksumEnd.Location = new System.Drawing.Point(303, 51);
            this.textBoxChecksumEnd.Name = "textBoxChecksumEnd";
            this.textBoxChecksumEnd.Size = new System.Drawing.Size(100, 22);
            this.textBoxChecksumEnd.TabIndex = 43;
            this.textBoxChecksumEnd.Text = "0000";
            this.textBoxChecksumEnd.TextChanged += new System.EventHandler(this.textBoxChecksumEnd_TextChanged);
            // 
            // MTKTestProgramAllDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ModuleFWValidCheckBox);
            this.Controls.Add(this.ModuleCheckGroupBox);
            this.Controls.Add(this.HexGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MTKTestProgramAllDialog";
            this.Text = "Program All Devices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HexGroupBox.ResumeLayout(false);
            this.HexGroupBox.PerformLayout();
            this.ModuleCheckGroupBox.ResumeLayout(false);
            this.ModuleCheckGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BegningRadioButton;
        private System.Windows.Forms.RadioButton EndRadioButton;
        private System.Windows.Forms.TextBox HexFilePathTextBox;
        private System.Windows.Forms.GroupBox HexGroupBox;
        private System.Windows.Forms.Button OpenHEXFileButton;
        private System.Windows.Forms.GroupBox ModuleCheckGroupBox;
        private System.Windows.Forms.CheckBox ModuleFWValidCheckBox;
        private System.Windows.Forms.TextBox HWIDTextBox;
        private System.Windows.Forms.TextBox PVTextBox;
        private System.Windows.Forms.TextBox BLESVTextBox;
        private System.Windows.Forms.TextBox AVTextBox;
        private System.Windows.Forms.TextBox MACATtextBox;
        private System.Windows.Forms.CheckBox MACACheckBox;
        private System.Windows.Forms.CheckBox PVCheckBox;
        private System.Windows.Forms.CheckBox HWIDCheckBox;
        private System.Windows.Forms.CheckBox BSVCheckBox;
        private System.Windows.Forms.CheckBox AVCheckBox;
        private System.Windows.Forms.ComboBox EventTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DelayNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox BCCheckBox;
        private System.Windows.Forms.TextBox BCTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxChecksumEnd;
        private System.Windows.Forms.TextBox textBoxChecksumBegin;
        private System.Windows.Forms.CheckBox EnableChecksumEnd;
        private System.Windows.Forms.CheckBox EnableChecksumBegin;
    }
}