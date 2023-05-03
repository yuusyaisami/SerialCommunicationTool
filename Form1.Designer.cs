namespace BluetoothSerialCommunicationTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPortCtrl = new System.IO.Ports.SerialPort(this.components);
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DebugT = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.Controltab = new System.Windows.Forms.TabControl();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.EmptyBoxSetting = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.GameControllSetting = new System.Windows.Forms.CheckBox();
            this.VolumeValue = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.volume = new System.Windows.Forms.Label();
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ConnectTitle = new System.Windows.Forms.Label();
            this.ConnectName = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.Label();
            this.BaudRateValue = new System.Windows.Forms.Label();
            this.EncodingTitle = new System.Windows.Forms.Label();
            this.EncodingName = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TextBoxLog = new System.Windows.Forms.ListView();
            this.SentdataTitle = new System.Windows.Forms.Label();
            this.SentdataValue = new System.Windows.Forms.Label();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.CloseBtn = new System.Windows.Forms.Label();
            this.Controltab.SuspendLayout();
            this.SettingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPortCtrl
            // 
            this.serialPortCtrl.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortCtrl_ErrorReceived);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(184, 58);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(116, 23);
            this.cmbSerialPort.TabIndex = 0;
            this.cmbSerialPort.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumBlue;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(343, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect";
            this.label2.Click += new System.EventHandler(this.Connectbtn_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // DebugT
            // 
            this.DebugT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugT.AutoSize = true;
            this.DebugT.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DebugT.Location = new System.Drawing.Point(11, 781);
            this.DebugT.Name = "DebugT";
            this.DebugT.Size = new System.Drawing.Size(148, 28);
            this.DebugT.TabIndex = 5;
            this.DebugT.Text = "DebugText";
            this.ToolTips.SetToolTip(this.DebugT, "デバッグ用のテキストです");
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Controltab
            // 
            this.Controltab.Controls.Add(this.SettingPage);
            this.Controltab.Controls.Add(this.InfoPage);
            this.Controltab.Location = new System.Drawing.Point(1088, 12);
            this.Controltab.Name = "Controltab";
            this.Controltab.SelectedIndex = 0;
            this.Controltab.Size = new System.Drawing.Size(432, 577);
            this.Controltab.TabIndex = 6;
            // 
            // SettingPage
            // 
            this.SettingPage.Controls.Add(this.EmptyBoxSetting);
            this.SettingPage.Controls.Add(this.checkBox2);
            this.SettingPage.Controls.Add(this.GameControllSetting);
            this.SettingPage.Controls.Add(this.VolumeValue);
            this.SettingPage.Controls.Add(this.VolumeBar);
            this.SettingPage.Controls.Add(this.volume);
            this.SettingPage.Location = new System.Drawing.Point(4, 25);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingPage.Size = new System.Drawing.Size(424, 548);
            this.SettingPage.TabIndex = 0;
            this.SettingPage.Text = "Setting";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // EmptyBoxSetting
            // 
            this.EmptyBoxSetting.AutoSize = true;
            this.EmptyBoxSetting.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyBoxSetting.Location = new System.Drawing.Point(25, 180);
            this.EmptyBoxSetting.Name = "EmptyBoxSetting";
            this.EmptyBoxSetting.Size = new System.Drawing.Size(269, 28);
            this.EmptyBoxSetting.TabIndex = 5;
            this.EmptyBoxSetting.Text = "データの出力後Boxを空にする";
            this.EmptyBoxSetting.UseVisualStyleBackColor = true;
            this.EmptyBoxSetting.CheckedChanged += new System.EventHandler(this.EmptyBoxSetting_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(25, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(287, 28);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "コントローラー操作をオンにする";
            this.ToolTips.SetToolTip(this.checkBox2, "現在対応していません");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // GameControllSetting
            // 
            this.GameControllSetting.AutoSize = true;
            this.GameControllSetting.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameControllSetting.Location = new System.Drawing.Point(25, 112);
            this.GameControllSetting.Name = "GameControllSetting";
            this.GameControllSetting.Size = new System.Drawing.Size(253, 28);
            this.GameControllSetting.TabIndex = 3;
            this.GameControllSetting.Text = "キーボード操作をオンにする";
            this.GameControllSetting.UseVisualStyleBackColor = true;
            this.GameControllSetting.CheckedChanged += new System.EventHandler(this.GameControllSetting_CheckedChanged);
            // 
            // VolumeValue
            // 
            this.VolumeValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VolumeValue.Location = new System.Drawing.Point(20, 50);
            this.VolumeValue.Name = "VolumeValue";
            this.VolumeValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VolumeValue.Size = new System.Drawing.Size(90, 27);
            this.VolumeValue.TabIndex = 2;
            this.VolumeValue.Text = "80";
            this.VolumeValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(116, 23);
            this.VolumeBar.Maximum = 12;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(254, 56);
            this.VolumeBar.TabIndex = 1;
            this.VolumeBar.Value = 8;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(20, 23);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(90, 27);
            this.volume.TabIndex = 0;
            this.volume.Text = "Volume";
            // 
            // InfoPage
            // 
            this.InfoPage.Location = new System.Drawing.Point(4, 25);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(424, 548);
            this.InfoPage.TabIndex = 1;
            this.InfoPage.Text = "Info";
            this.InfoPage.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(1522, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ConnectTitle
            // 
            this.ConnectTitle.AutoSize = true;
            this.ConnectTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectTitle.Location = new System.Drawing.Point(49, 176);
            this.ConnectTitle.Name = "ConnectTitle";
            this.ConnectTitle.Size = new System.Drawing.Size(81, 27);
            this.ConnectTitle.TabIndex = 3;
            this.ConnectTitle.Text = "Conect";
            // 
            // ConnectName
            // 
            this.ConnectName.AutoSize = true;
            this.ConnectName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectName.Location = new System.Drawing.Point(165, 176);
            this.ConnectName.Name = "ConnectName";
            this.ConnectName.Size = new System.Drawing.Size(0, 27);
            this.ConnectName.TabIndex = 8;
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate.Location = new System.Drawing.Point(49, 149);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(110, 27);
            this.BaudRate.TabIndex = 9;
            this.BaudRate.Text = "BaudRate";
            // 
            // BaudRateValue
            // 
            this.BaudRateValue.AutoSize = true;
            this.BaudRateValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateValue.Location = new System.Drawing.Point(165, 149);
            this.BaudRateValue.Name = "BaudRateValue";
            this.BaudRateValue.Size = new System.Drawing.Size(0, 27);
            this.BaudRateValue.TabIndex = 10;
            // 
            // EncodingTitle
            // 
            this.EncodingTitle.AutoSize = true;
            this.EncodingTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingTitle.Location = new System.Drawing.Point(320, 176);
            this.EncodingTitle.Name = "EncodingTitle";
            this.EncodingTitle.Size = new System.Drawing.Size(104, 27);
            this.EncodingTitle.TabIndex = 11;
            this.EncodingTitle.Text = "Encoding";
            // 
            // EncodingName
            // 
            this.EncodingName.AutoSize = true;
            this.EncodingName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingName.Location = new System.Drawing.Point(436, 176);
            this.EncodingName.Name = "EncodingName";
            this.EncodingName.Size = new System.Drawing.Size(0, 27);
            this.EncodingName.TabIndex = 12;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(54, 387);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(539, 22);
            this.TextBox.TabIndex = 13;
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown_1);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.HideSelection = false;
            this.TextBoxLog.Location = new System.Drawing.Point(54, 206);
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(539, 175);
            this.TextBoxLog.TabIndex = 14;
            this.TextBoxLog.TabStop = false;
            this.TextBoxLog.UseCompatibleStateImageBehavior = false;
            this.TextBoxLog.View = System.Windows.Forms.View.List;
            // 
            // SentdataTitle
            // 
            this.SentdataTitle.AutoSize = true;
            this.SentdataTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentdataTitle.Location = new System.Drawing.Point(320, 149);
            this.SentdataTitle.Name = "SentdataTitle";
            this.SentdataTitle.Size = new System.Drawing.Size(108, 27);
            this.SentdataTitle.TabIndex = 15;
            this.SentdataTitle.Text = "Sent data";
            // 
            // SentdataValue
            // 
            this.SentdataValue.AutoSize = true;
            this.SentdataValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentdataValue.Location = new System.Drawing.Point(434, 149);
            this.SentdataValue.Name = "SentdataValue";
            this.SentdataValue.Size = new System.Drawing.Size(0, 27);
            this.SentdataValue.TabIndex = 16;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.DimGray;
            this.CloseBtn.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Location = new System.Drawing.Point(456, 58);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(65, 23);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 818);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SentdataValue);
            this.Controls.Add(this.SentdataTitle);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.EncodingName);
            this.Controls.Add(this.EncodingTitle);
            this.Controls.Add(this.BaudRateValue);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.ConnectName);
            this.Controls.Add(this.ConnectTitle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Controltab);
            this.Controls.Add(this.DebugT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSerialPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controltab.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.SettingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortCtrl;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DebugT;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.TabControl Controltab;
        private System.Windows.Forms.TabPage SettingPage;
        private System.Windows.Forms.TabPage InfoPage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label VolumeValue;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label ConnectTitle;
        private System.Windows.Forms.Label ConnectName;
        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.Label BaudRateValue;
        private System.Windows.Forms.Label EncodingTitle;
        private System.Windows.Forms.Label EncodingName;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ListView TextBoxLog;
        private System.Windows.Forms.Label SentdataTitle;
        private System.Windows.Forms.Label SentdataValue;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox GameControllSetting;
        private System.Windows.Forms.CheckBox EmptyBoxSetting;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.Label CloseBtn;
    }
}

