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
                    serialPortCtrl.WriteLine(data);  //データ書き込み
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("エラーが発生しました: " + ex.Message);
            }
        }
        /// <summary>
        /// sendbtnfunction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HIGHbtn_Click(object sender, EventArgs e)
        {
            Send("1");
        }

        private void LOWbtn_Click(object sender, EventArgs e)
        {
            Send("0");
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if(serialPortCtrl.IsOpen == true)
            {
                ConnectName.Text = serialPortCtrl.PortName;
                BaudRateValue.Text = serialPortCtrl.BaudRate.ToString();
                EncodingTitle.Text = serialPortCtrl.Encoding.ToString();

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
                TextBoxItem = new ListViewItem(" > " + TextBox.Text);
                TextBoxLog.Items.Add(TextBoxItem);
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
    }
}
