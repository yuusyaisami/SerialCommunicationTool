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
            this.SerialPortTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DebugT = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.Controltab = new System.Windows.Forms.TabControl();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.ByteSetting = new System.Windows.Forms.CheckBox();
            this.EmptyBoxSetting = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.GameControllSetting = new System.Windows.Forms.CheckBox();
            this.VolumeValue = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.volume = new System.Windows.Forms.Label();
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HideHello = new System.Windows.Forms.Label();
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
            this.AllClear = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.PictureBox();
            this.Panel3 = new System.Windows.Forms.PictureBox();
            this.Panel4 = new System.Windows.Forms.PictureBox();
            this.Panel5 = new System.Windows.Forms.PictureBox();
            this.Panel6 = new System.Windows.Forms.PictureBox();
            this.Panel7 = new System.Windows.Forms.PictureBox();
            this.Panel8 = new System.Windows.Forms.PictureBox();
            this.AutomaticSendbtn = new System.Windows.Forms.Label();
            this.Ayasiiyona = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Controltab.SuspendLayout();
            this.SettingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.InfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel8)).BeginInit();
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
            // SerialPortTitle
            // 
            this.SerialPortTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPortTitle.AutoSize = true;
            this.SerialPortTitle.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SerialPortTitle.Location = new System.Drawing.Point(34, 58);
            this.SerialPortTitle.Name = "SerialPortTitle";
            this.SerialPortTitle.Size = new System.Drawing.Size(125, 23);
            this.SerialPortTitle.TabIndex = 1;
            this.SerialPortTitle.Text = "Serial Port";
            this.SerialPortTitle.Click += new System.EventHandler(this.SerialPortTitle_Click);
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
            this.Controltab.Dock = System.Windows.Forms.DockStyle.Right;
            this.Controltab.Location = new System.Drawing.Point(1029, 0);
            this.Controltab.Name = "Controltab";
            this.Controltab.SelectedIndex = 0;
            this.Controltab.Size = new System.Drawing.Size(533, 818);
            this.Controltab.TabIndex = 6;
            // 
            // SettingPage
            // 
            this.SettingPage.Controls.Add(this.ByteSetting);
            this.SettingPage.Controls.Add(this.EmptyBoxSetting);
            this.SettingPage.Controls.Add(this.checkBox2);
            this.SettingPage.Controls.Add(this.GameControllSetting);
            this.SettingPage.Controls.Add(this.VolumeValue);
            this.SettingPage.Controls.Add(this.VolumeBar);
            this.SettingPage.Controls.Add(this.volume);
            this.SettingPage.Location = new System.Drawing.Point(4, 25);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingPage.Size = new System.Drawing.Size(525, 789);
            this.SettingPage.TabIndex = 0;
            this.SettingPage.Text = "Setting";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // ByteSetting
            // 
            this.ByteSetting.AutoSize = true;
            this.ByteSetting.Checked = true;
            this.ByteSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ByteSetting.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByteSetting.Location = new System.Drawing.Point(25, 242);
            this.ByteSetting.Name = "ByteSetting";
            this.ByteSetting.Size = new System.Drawing.Size(219, 28);
            this.ByteSetting.TabIndex = 6;
            this.ByteSetting.Text = "データをバイト型で送る";
            this.ByteSetting.UseVisualStyleBackColor = true;
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
            this.ToolTips.SetToolTip(this.volume, "デフォルト80");
            // 
            // InfoPage
            // 
            this.InfoPage.Controls.Add(this.splitContainer1);
            this.InfoPage.Location = new System.Drawing.Point(4, 25);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(525, 789);
            this.InfoPage.TabIndex = 1;
            this.InfoPage.Text = "Info";
            this.InfoPage.UseVisualStyleBackColor = true;
            this.InfoPage.Click += new System.EventHandler(this.InfoPage_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label23);
            this.splitContainer1.Panel1.Controls.Add(this.label22);
            this.splitContainer1.Panel1.Controls.Add(this.label21);
            this.splitContainer1.Panel1.Controls.Add(this.label20);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.HideHello);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Ayasiiyona);
            this.splitContainer1.Size = new System.Drawing.Size(519, 783);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "こんにちは :D";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 27);
            this.label12.TabIndex = 30;
            this.label12.Text = "你好 :D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = "안녕하세요 :D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sveiki :D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 27);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dobrý den :D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "Witam :D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Здравейте :D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bonjour :D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hei :D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hej :D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Halo :D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salve :D";
            // 
            // HideHello
            // 
            this.HideHello.AutoSize = true;
            this.HideHello.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideHello.Location = new System.Drawing.Point(73, 9);
            this.HideHello.Name = "HideHello";
            this.HideHello.Size = new System.Drawing.Size(93, 27);
            this.HideHello.TabIndex = 19;
            this.HideHello.Text = "Hello :D";
            this.HideHello.Click += new System.EventHandler(this.HideHello_Click);
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
            this.ToolTips.SetToolTip(this.checkBox1, "tabを表示するまたは非表示にする");
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
            this.EncodingTitle.Size = new System.Drawing.Size(111, 27);
            this.EncodingTitle.TabIndex = 11;
            this.EncodingTitle.Text = "SendType";
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
            // AllClear
            // 
            this.AllClear.AutoSize = true;
            this.AllClear.BackColor = System.Drawing.Color.LightGray;
            this.AllClear.Location = new System.Drawing.Point(600, 206);
            this.AllClear.Name = "AllClear";
            this.AllClear.Size = new System.Drawing.Size(55, 15);
            this.AllClear.TabIndex = 18;
            this.AllClear.Text = "AllClear";
            this.ToolTips.SetToolTip(this.AllClear, "すべてのLogを消します");
            this.AllClear.Click += new System.EventHandler(this.AllClear_Click);
            this.AllClear.MouseEnter += new System.EventHandler(this.AllClear_MouseEnter);
            this.AllClear.MouseLeave += new System.EventHandler(this.AllClear_MouseLeave);
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
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(38, 441);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(207, 28);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "AutomaticController";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel1.Location = new System.Drawing.Point(80, 485);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(50, 50);
            this.Panel1.TabIndex = 19;
            this.Panel1.TabStop = false;
            this.Panel1.Click += new System.EventHandler(this.Panel1_Click);
            this.Panel1.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter);
            this.Panel1.MouseLeave += new System.EventHandler(this.Panel1_MouseLeave);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel2.Location = new System.Drawing.Point(136, 485);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(50, 50);
            this.Panel2.TabIndex = 20;
            this.Panel2.TabStop = false;
            this.Panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.Panel2.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.Panel2.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel3.Location = new System.Drawing.Point(192, 485);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(50, 50);
            this.Panel3.TabIndex = 21;
            this.Panel3.TabStop = false;
            this.Panel3.Click += new System.EventHandler(this.Panel3_Click);
            this.Panel3.MouseEnter += new System.EventHandler(this.Panel3_MouseEnter);
            this.Panel3.MouseLeave += new System.EventHandler(this.Panel3_MouseLeave);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel4.Location = new System.Drawing.Point(80, 541);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(50, 50);
            this.Panel4.TabIndex = 22;
            this.Panel4.TabStop = false;
            this.Panel4.Click += new System.EventHandler(this.Panel4_Click);
            this.Panel4.MouseEnter += new System.EventHandler(this.Panel4_MouseEnter);
            this.Panel4.MouseLeave += new System.EventHandler(this.Panel4_MouseLeave);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel5.Location = new System.Drawing.Point(192, 541);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(50, 50);
            this.Panel5.TabIndex = 24;
            this.Panel5.TabStop = false;
            this.Panel5.Click += new System.EventHandler(this.Panel5_Click);
            this.Panel5.MouseEnter += new System.EventHandler(this.Panel5_MouseEnter);
            this.Panel5.MouseLeave += new System.EventHandler(this.Panel5_MouseLeave);
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel6.Location = new System.Drawing.Point(80, 597);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(50, 50);
            this.Panel6.TabIndex = 25;
            this.Panel6.TabStop = false;
            this.Panel6.Click += new System.EventHandler(this.Panel6_Click);
            this.Panel6.MouseEnter += new System.EventHandler(this.Panel6_MouseEnter);
            this.Panel6.MouseLeave += new System.EventHandler(this.Panel6_MouseLeave);
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel7.Location = new System.Drawing.Point(136, 597);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(50, 50);
            this.Panel7.TabIndex = 26;
            this.Panel7.TabStop = false;
            this.Panel7.Click += new System.EventHandler(this.Panel7_Click);
            this.Panel7.MouseEnter += new System.EventHandler(this.Panel7_MouseEnter);
            this.Panel7.MouseLeave += new System.EventHandler(this.Panel7_MouseLeave);
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel8.Location = new System.Drawing.Point(192, 597);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(50, 50);
            this.Panel8.TabIndex = 27;
            this.Panel8.TabStop = false;
            this.Panel8.Click += new System.EventHandler(this.Panel8_Click);
            this.Panel8.MouseEnter += new System.EventHandler(this.Panel8_MouseEnter);
            this.Panel8.MouseLeave += new System.EventHandler(this.Panel8_MouseLeave);
            // 
            // AutomaticSendbtn
            // 
            this.AutomaticSendbtn.AutoSize = true;
            this.AutomaticSendbtn.BackColor = System.Drawing.Color.LightGray;
            this.AutomaticSendbtn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AutomaticSendbtn.Location = new System.Drawing.Point(249, 632);
            this.AutomaticSendbtn.Name = "AutomaticSendbtn";
            this.AutomaticSendbtn.Size = new System.Drawing.Size(43, 15);
            this.AutomaticSendbtn.TabIndex = 28;
            this.AutomaticSendbtn.Text = "Send";
            this.ToolTips.SetToolTip(this.AutomaticSendbtn, "すべてのLogを消します");
            this.AutomaticSendbtn.Click += new System.EventHandler(this.AutomaticSendbtn_Click);
            this.AutomaticSendbtn.MouseEnter += new System.EventHandler(this.AutomaticSendbtn_MouseEnter);
            this.AutomaticSendbtn.MouseLeave += new System.EventHandler(this.AutomaticSendbtn_MouseLeave);
            // 
            // Ayasiiyona
            // 
            this.Ayasiiyona.AutoSize = true;
            this.Ayasiiyona.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ayasiiyona.Location = new System.Drawing.Point(26, 36);
            this.Ayasiiyona.Name = "Ayasiiyona";
            this.Ayasiiyona.Size = new System.Drawing.Size(297, 27);
            this.Ayasiiyona.TabIndex = 29;
            this.Ayasiiyona.Text = "何もないなんて怪しいよな(\'Д\')";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(361, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "自動走行 : 203";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(488, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 30;
            this.label15.Text = "手動走行 : 201";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(361, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 24);
            this.label16.TabIndex = 31;
            this.label16.Text = "Reset : 100";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(73, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 27);
            this.label17.TabIndex = 32;
            this.label17.Text = "Sawubona :D";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(73, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 27);
            this.label18.TabIndex = 33;
            this.label18.Text = "ជំរាបសួរ :D";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(73, 421);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 27);
            this.label19.TabIndex = 34;
            this.label19.Text = "Привіт:D";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(73, 448);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 27);
            this.label20.TabIndex = 35;
            this.label20.Text = "Bonjou:D";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(73, 475);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 27);
            this.label21.TabIndex = 36;
            this.label21.Text = "สวัสดี:D";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(73, 502);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 27);
            this.label22.TabIndex = 37;
            this.label22.Text = "Xin chào:D";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(73, 529);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 27);
            this.label23.TabIndex = 38;
            this.label23.Text = "Hola:D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 818);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AutomaticSendbtn);
            this.Controls.Add(this.Panel8);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.AllClear);
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
            this.Controls.Add(this.SerialPortTitle);
            this.Controls.Add(this.cmbSerialPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controltab.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.SettingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.InfoPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortCtrl;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label SerialPortTitle;
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
        private System.Windows.Forms.CheckBox ByteSetting;
        private System.Windows.Forms.Label AllClear;
        private System.Windows.Forms.Label HideHello;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox Panel1;
        private System.Windows.Forms.PictureBox Panel2;
        private System.Windows.Forms.PictureBox Panel3;
        private System.Windows.Forms.PictureBox Panel4;
        private System.Windows.Forms.PictureBox Panel5;
        private System.Windows.Forms.PictureBox Panel6;
        private System.Windows.Forms.PictureBox Panel7;
        private System.Windows.Forms.PictureBox Panel8;
        private System.Windows.Forms.Label AutomaticSendbtn;
        private System.Windows.Forms.Label Ayasiiyona;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

