using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BluetoothSerialCommunicationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] PortList = SerialPort.GetPortNames();

            // 使用できるシリアルポート名をコンボボックスの選択肢に追加
            cmbSerialPort.Items.Clear();
            foreach (string PortName in PortList)
            {
                cmbSerialPort.Items.Add(PortName);
            }
            if (cmbSerialPort.Items.Count > 0)
            {
                cmbSerialPort.SelectedIndex = 0;
            }
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkSlateBlue;
            PlaySound("SoundFile/Vibes2C.wav");
            if (serialPortCtrl.IsOpen == true)
            {
                serialPortCtrl.Close();
                return;
            }
            else
            {
                try
                {
                    // シリアルポートに接続する
                    serialPortCtrl.PortName = cmbSerialPort.SelectedItem.ToString(); // Comboボックスで選択したシリアルポート番号をポート名に設定
                    serialPortCtrl.BaudRate = 9600; // ボーレートを設定
                    serialPortCtrl.DataBits = 8; // データビットを設定
                    serialPortCtrl.Parity = Parity.None; // パリティビットを設定
                    serialPortCtrl.StopBits = StopBits.One; // ストップビットを設定
                    serialPortCtrl.Handshake = Handshake.None; // フロー制御を設定
                    serialPortCtrl.Encoding = Encoding.ASCII; // 文字コードを設定
                    serialPortCtrl.WriteTimeout = 50000;
                    serialPortCtrl.ReadTimeout = 100000;
                    serialPortCtrl.Open();

                }
                catch(Exception ex)
                {
                    PlaySound("SoundFile/Erroron.wav");
                    MessageBox.Show("エラーが発生しました: " + ex.Message);
                }
            }
        }
        string olddata;
        public void Send(string data)
        {
            if (serialPortCtrl.IsOpen == false) return;  //ポートが閉じている場合は戻す

            try
            {
                DebugT.Text = data;

                if (data != olddata)
                {
                    olddata = data;
                    SentdataValue.Text = data;
                    if (ByteSetting.Checked == true)
                    {
                        int dataInt;
                        if (int.TryParse(data, out dataInt)){
                            int.TryParse(data, out dataInt);
                            Convert.ToInt32(dataInt);
                            byte[] dataByte = BitConverter.GetBytes(dataInt);
                            serialPortCtrl.Write(dataByte, 0, data.Length);  //データ書き込み
                            TextBoxItem = new ListViewItem(" > " + dataInt);
                            TextBoxLog.Items.Add(TextBoxItem);
                        }
                    }
                    else
                    {
                        serialPortCtrl.WriteLine(data);  //データ書き込み
                        TextBoxItem = new ListViewItem(" > " + data);
                        TextBoxLog.Items.Add(TextBoxItem);
                    }
                }
            }
            catch (Exception ex)
            {
                PlaySound("SoundFile/Erroron.wav");
                Debug.WriteLine("エラーが発生しました: " + ex.Message);
            }
        }
        /// <summary>
        /// sendbtnfunction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if(serialPortCtrl.IsOpen == true)
            {
                ConnectName.Text = serialPortCtrl.PortName;
                BaudRateValue.Text = serialPortCtrl.BaudRate.ToString();
                if(ByteSetting.Checked == false)
                EncodingTitle.Text = serialPortCtrl.Encoding.ToString();
                else
                    EncodingTitle.Text = "byte";


            }
            else
            {
                ConnectName.Text = "";
                BaudRateValue.Text = "";
                EncodingTitle.Text = "";
            }
            if (GameControllSetting.Checked)
            {
                if (Keyboard.IsKeyDown(Key.W) && Keyboard.IsKeyDown(Key.A))
                {
                    DebugT.Text = "左折";
                    Send("5");
                }
                else if (Keyboard.IsKeyDown(Key.W) && Keyboard.IsKeyDown(Key.D))
                {
                    DebugT.Text = "右折";
                    Send("6");
                }
                else if (Keyboard.IsKeyDown(Key.S) && Keyboard.IsKeyDown(Key.A))
                {
                    DebugT.Text = "左折";
                    Send("7");
                }
                else if (Keyboard.IsKeyDown(Key.S) && Keyboard.IsKeyDown(Key.D))
                {
                    DebugT.Text = "右折";
                    Send("8");
                }
                else if (Keyboard.IsKeyDown(Key.W))
                {
                    DebugT.Text = "前進!!!!!";
                    Send("1");
                }
                else if (Keyboard.IsKeyDown(Key.S))
                {
                    DebugT.Text = "後進!!!!!";
                    Send("2");
                }
                else if (Keyboard.IsKeyDown(Key.A))
                {
                    DebugT.Text = "左旋回!!!!!";
                    Send("3");
                }
                else if (Keyboard.IsKeyDown(Key.D))
                {
                    DebugT.Text = "右旋回!!!!!";
                    Send("4");
                }
                else
                {
                    DebugT.Text = "とまれ!!!!!";
                    Send("0");
                }
            }
        }

        private void serialPortCtrl_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            serialPortCtrl.Close();
        }
        private System.Media.SoundPlayer player = null;
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
        int audioVolume = 80;
        private async void PlaySound(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                audioFile.Volume = audioVolume / 100f;
                outputDevice.Init(audioFile);
                outputDevice.Play();
                await Task.Delay(audioFile.TotalTime);
            }
        }
        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Controltab.Visible = true;
            }
            else if(checkBox1.Checked == false)
            {
                Controltab.Visible = false;
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            audioVolume = VolumeBar.Value * 10;
            VolumeValue.Text = audioVolume.ToString();
            PlaySound("SoundFile/Erroron.wav");
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Navy;
            PlaySound("SoundFile/Vibes1#F.wav");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.MediumBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ListViewItem TextBoxItem = new ListViewItem();

        private void TextBox_KeyDown_1(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox.Text))
            {
                DebugT.Text = "空です";
            }
            else if (e.KeyData == Keys.Enter)
            {
                Send(TextBox.Text);
                if (EmptyBoxSetting.Checked)
                {
                    TextBox.Text = "";
                }
            }
        }

        private void GameControllSetting_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void EmptyBoxSetting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            serialPortCtrl.Close();
        }

        private void AllClear_MouseEnter(object sender, EventArgs e)
        {
            AllClear.BackColor = Color.LightGray;
            PlaySound("SoundFile/Vibes1A.wav");
        }

        private void AllClear_MouseLeave(object sender, EventArgs e)
        {
            AllClear.BackColor = SystemColors.Control;
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            TextBoxLog.Items.Clear();
        }

        private void SerialPortTitle_Click(object sender, EventArgs e)
        {
            PlaySound("SoundFile/ououolu.wav");
        }

        private void InfoPage_Click(object sender, EventArgs e)
        {

        }

        private void HideHello_Click(object sender, EventArgs e)
        {

        }

        private void AutomaticSendbtn_MouseEnter(object sender, EventArgs e)
        {
            AutomaticSendbtn.BackColor = Color.LightGray;
            PlaySound("SoundFile/Vibes1B.wav");
        }

        private void AutomaticSendbtn_MouseLeave(object sender, EventArgs e)
        {
            AutomaticSendbtn.BackColor = SystemColors.Control;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/C#Bass.wav");
            if (Panel1.BackColor == Color.Gainsboro)
            {
                Panel1.BackColor = Color.Silver;
            }
            if (Panel1.BackColor == Color.OrangeRed)
            {
                Panel1.BackColor = Color.Firebrick;
            }
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            if (Panel1.BackColor == Color.Silver)
            {
                Panel1.BackColor = Color.Gainsboro;
            }
            if (Panel1.BackColor == Color.Firebrick)
            {
                Panel1.BackColor = Color.OrangeRed;
            }
        }

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/D#Bass.wav");
            if (Panel2.BackColor == Color.Gainsboro)
            {
                Panel2.BackColor = Color.Silver;
            }
            if (Panel2.BackColor == Color.OrangeRed)
            {
                Panel2.BackColor = Color.Firebrick;
            }
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            if (Panel2.BackColor == Color.Silver)
            {
                Panel2.BackColor = Color.Gainsboro;
            }
            if (Panel2.BackColor == Color.Firebrick)
            {
                Panel2.BackColor = Color.OrangeRed;
            }
        }

        private void Panel3_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/F#Bass.wav");
            if (Panel3.BackColor == Color.Gainsboro)
            {
                Panel3.BackColor = Color.Silver;
            }
            if (Panel3.BackColor == Color.OrangeRed)
            {
                Panel3.BackColor = Color.Firebrick;
            }
        }

        private void Panel3_MouseLeave(object sender, EventArgs e)
        {
            if (Panel3.BackColor == Color.Silver)
            {
                Panel3.BackColor = Color.Gainsboro;
            }
            if (Panel3.BackColor == Color.Firebrick)
            {
                Panel3.BackColor = Color.OrangeRed;
            }
        }

        private void Panel4_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/G#Bass.wav");
            if (Panel4.BackColor == Color.Gainsboro)
            {
                Panel4.BackColor = Color.Silver;
            }
            if (Panel4.BackColor == Color.OrangeRed)
            {
                Panel4.BackColor = Color.Firebrick;
            }
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            if (Panel4.BackColor == Color.Silver)
            {
                Panel4.BackColor = Color.Gainsboro;
            }
            if (Panel4.BackColor == Color.Firebrick)
            {
                Panel4.BackColor = Color.OrangeRed;
            }
        }

        private void Panel5_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/A#Bass.wav");
            if (Panel5.BackColor == Color.Gainsboro)
            {
                Panel5.BackColor = Color.Silver;
            }
            if (Panel5.BackColor == Color.OrangeRed)
            {
                Panel5.BackColor = Color.Firebrick;
            }
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            if (Panel5.BackColor == Color.Silver)
            {
                Panel5.BackColor = Color.Gainsboro;
            }
            if (Panel5.BackColor == Color.Firebrick)
            {
                Panel5.BackColor = Color.OrangeRed;
            }
        }

        private void Panel6_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/B#Bass.wav");
            if (Panel6.BackColor == Color.Gainsboro)
            {
                Panel6.BackColor = Color.Silver;
            }
            if (Panel6.BackColor == Color.OrangeRed)
            {
                Panel6.BackColor = Color.Firebrick;
            }
        }

        private void Panel6_MouseLeave(object sender, EventArgs e)
        {
            if (Panel6.BackColor == Color.Silver)
            {
                Panel6.BackColor = Color.Gainsboro;
            }
            if (Panel6.BackColor == Color.Firebrick)
            {
                Panel6.BackColor = Color.OrangeRed;
            }
        }

        private void Panel7_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/2C#Bass.wav");
            if (Panel7.BackColor == Color.Gainsboro)
            {
                Panel7.BackColor = Color.Silver;
            }
            if (Panel7.BackColor == Color.OrangeRed)
            {
                Panel7.BackColor = Color.Firebrick;
            }
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            if (Panel7.BackColor == Color.Silver)
            {
                Panel7.BackColor = Color.Gainsboro;
            }
            if (Panel7.BackColor == Color.Firebrick)
            {
                Panel7.BackColor = Color.OrangeRed;
            }
        }

        private void Panel8_MouseEnter(object sender, EventArgs e)
        {
            PlaySound("SoundFile/2D#Bass.wav");
            if (Panel8.BackColor == Color.Gainsboro)
            {
                Panel8.BackColor = Color.Silver;
            }
            if (Panel8.BackColor == Color.OrangeRed)
            {
                Panel8.BackColor = Color.Firebrick;
            }
        }

        private void Panel8_MouseLeave(object sender, EventArgs e)
        {
            if (Panel8.BackColor == Color.Silver)
            {
                Panel8.BackColor = Color.Gainsboro;
            }
            if (Panel8.BackColor == Color.Firebrick)
            {
                Panel8.BackColor = Color.OrangeRed;
            }
        }
        int SendAutoC;
        private void Panel1_Click(object sender, EventArgs e)
        {
            if (Panel1.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel1.BackColor = Color.Firebrick;
                SendAutoC = 1;
            }
            else if(Panel1.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel1.BackColor = Color.Silver;
            }
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            if (Panel2.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel2.BackColor = Color.Firebrick;
                SendAutoC = 2;
            }
            else if (Panel2.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel2.BackColor = Color.Silver;
            }
            
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            if (Panel3.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel3.BackColor = Color.Firebrick;
                SendAutoC = 3;
            }
            else if (Panel3.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel3.BackColor = Color.Silver;
            }
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            if (Panel4.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel4.BackColor = Color.Firebrick;
                SendAutoC = 4;
            }
            else if (Panel4.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel4.BackColor = Color.Silver;
            }
        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            if (Panel5.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel5.BackColor = Color.Firebrick;
                SendAutoC = 5;
            }
            else if (Panel5.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel5.BackColor = Color.Silver;
            }
            
        }

        private void Panel6_Click(object sender, EventArgs e)
        {
            if (Panel6.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel6.BackColor = Color.Firebrick;
                SendAutoC = 6;
            }
            else if (Panel6.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel6.BackColor = Color.Silver;
            }
        }

        private void Panel7_Click(object sender, EventArgs e)
        {
            if (Panel7.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel7.BackColor = Color.Firebrick;
                SendAutoC = 7;
            }
            else if (Panel7.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel7.BackColor = Color.Silver;
            }
        }

        private void Panel8_Click(object sender, EventArgs e)
        {
            if (Panel8.BackColor == Color.Silver && SendAutoC == 0)
            {
                Panel8.BackColor = Color.Firebrick;
                SendAutoC = 8;
            }
            else if (Panel8.BackColor == Color.Firebrick)
            {
                SendAutoC = 0;
                Panel8.BackColor = Color.Silver;
            }
        }

        private void AutomaticSendbtn_Click(object sender, EventArgs e)
        {
            Send(SendAutoC.ToString());
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Send("203");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Send("100");
        }
    }
}
