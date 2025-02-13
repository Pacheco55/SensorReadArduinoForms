using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SensorReadArduinoIDE
{
    public partial class Form1 : Form
    {
        private int vpb_sy, vpb_ly;
        private int SpeedL, TempL, BattL;
        private string Speed, Batt, Temp, SpeedResult, BatteryResult, TempResult;
        private string StrSerialIn, StrSerialInRam;
        private int ChartLimit = 30;
        private SerialPort SerialPort1;

        public Form1()
        {
            InitializeComponent();
            SerialPort1 = new SerialPort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ConnectionPanel.Focus();
            CircularProgressBarSpeed.Value = 0;
            ComboBoxBaudRate.SelectedIndex = 0;

            // Creating default graph
            for (int i = 0; i <= 30; i++)
            {
                ChartTemperature.Series["Temperature"].Points.AddY(0);
                if (ChartTemperature.Series[0].Points.Count == ChartLimit)
                {
                    ChartTemperature.Series[0].Points.RemoveAt(0);
                }
            }

            // Labeling values of the graph
            ChartTemperature.ChartAreas[0].AxisY.Maximum = 40;
            ChartTemperature.ChartAreas[0].AxisY.Minimum = 0;
            ChartTemperature.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
        }

        private void ButtonScanPort_Click(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Connection in progress, please Disconnect to scan the new port.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ComboBoxPort.Items.Clear();
            string[] myPort = SerialPort.GetPortNames();
            ComboBoxPort.Items.AddRange(myPort);
            try
            {
                ComboBoxPort.SelectedIndex = 0;
                ButtonConnect.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Com port not detected", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBoxPort.Text = "";
                ComboBoxPort.Items.Clear();
                return;
            }
            ComboBoxPort.DroppedDown = true;
        }

        private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
        }

        private void ComboBoxPort_DropDown(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
        }

        private void ComboBoxPort_Click(object sender, EventArgs e)
        {
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Connection in progress, please Disconnect to change COM.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ComboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
        }

        private void ComboBoxBaudRate_DropDown(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
        }

        private void ComboBoxBaudRate_Click(object sender, EventArgs e)
        {
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Connection in progress, please Disconnect to change Baud Rate.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
            try
            {
                SerialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.SelectedItem);
                SerialPort1.PortName = ComboBoxPort.SelectedItem.ToString();
                SerialPort1.Open();
                TimerSerial.Start();

                LabelStatus.Text = "Status : Connected";
                ButtonConnect.SendToBack();
                ButtonDisconnect.BringToFront();
                PictureBoxConnectionStatus.BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the Hardware, COM, Baud Rate and try again.", "Connection failed !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            ConnectionPanel.Focus();
            TimerSerial.Stop();
            SerialPort1.Close();
            ButtonDisconnect.SendToBack();
            ButtonConnect.BringToFront();
            LabelStatus.Text = "Status : Disconnect";
            PictureBoxConnectionStatus.Visible = true;
            PictureBoxConnectionStatus.BackColor = Color.Red;
        }

        private int MapBatt(float X, float In_min, float In_max, float Out_min, float Out_max)
        {
            float A = X - In_min;
            float B = Out_max - Out_min;
            A = A * B;
            B = In_max - In_min;
            A = A / B;
            return (int)(A + Out_min);
        }

        private void TimerSerial_Tick(object sender, EventArgs e)
        {
            try
            {
                StrSerialIn = SerialPort1.ReadExisting(); // Read incoming serial data

                TextBox TB = new TextBox();
                TB.Multiline = true;
                TB.Text = StrSerialIn; // Enter serial data into the textbox

                if (TB.Lines.Length > 0)
                {
                    if (TB.Lines[0] == "Failed to read from Your Bot !")
                    {
                        TimerSerial.Stop();
                        SerialPort1.Close();
                        LabelStatus.Text = "Status : Disconnect";
                        ButtonDisconnect.SendToBack();
                        ButtonConnect.BringToFront();
                        PictureBoxConnectionStatus.Visible = true;
                        PictureBoxConnectionStatus.BackColor = Color.Red;
                        MessageBox.Show("Failed to read from Bot !!!, Please check the Hardware and Please connect again.", "Connection failed !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Extracting Values from incoming data
                    StrSerialInRam = TB.Lines[0].Substring(0, 1);
                    if (StrSerialInRam == "S")
                    {
                        Speed = TB.Lines[0];
                        SpeedL = Speed.Length;
                    }

                    StrSerialInRam = TB.Lines[1].Substring(0, 1);
                    if (StrSerialInRam == "B")
                    {
                        Batt = TB.Lines[1];
                        BattL = Batt.Length;
                    }

                    StrSerialInRam = TB.Lines[2].Substring(0, 1);
                    if (StrSerialInRam == "T")
                    {
                        Temp = TB.Lines[2];
                        TempL = Temp.Length;
                    }

                    SpeedResult = Speed.Substring(1, SpeedL - 1);
                    BatteryResult = Batt.Substring(1, BattL - 1);
                    TempResult = Temp.Substring(1, TempL - 1);

                    CircularProgressBarSpeed.Value = Convert.ToInt32(SpeedResult);
                    CircularProgressBarSpeed.Text = CircularProgressBarSpeed.Value + " km/h";

                    // Enter the values into the chart
                    ChartTemperature.Series["Temperature"].Points.AddY(Convert.ToDouble(TempResult));
                    if (ChartTemperature.Series[0].Points.Count == ChartLimit)
                    {
                        ChartTemperature.Series[0].Points.RemoveAt(0);
                    }

                    // Value into labelBox
                    TempBox.Text = TempResult + " *C";

                    // Battery Panel
                    BatteryVolt.Text = BatteryResult + " V";

                    // The process for making a progress bar using a picturebox (Vertical Progress Bar -vpb)
                    vpb_sy = MapBatt(Convert.ToSingle(BatteryResult), 0, 24, 0, 120);
                    if (vpb_sy > 120)
                    {
                        vpb_sy = 120;
                    }
                    if (vpb_sy < 0)
                    {
                        vpb_sy = 0;
                    }
                    PictureBoxBatteryFront.Height = PictureBoxBatteryBack.Height * vpb_sy / 120;
                    vpb_ly = (PictureBoxBatteryBack.Height - vpb_sy) + PictureBoxBatteryBack.Location.Y;
                    PictureBoxBatteryFront.Location = new Point(PictureBoxBatteryFront.Location.X, vpb_ly);

                    // If the connection is successful and running, PictureBoxConnectionStatus will blink
                    PictureBoxConnectionStatus.Visible = !PictureBoxConnectionStatus.Visible;
                }
            }
            catch (Exception ex)
            {
                TimerSerial.Stop();
                SerialPort1.Close();
                LabelStatus.Text = "Status : Disconnect";
                ButtonDisconnect.SendToBack();
                ButtonConnect.BringToFront();
                PictureBoxConnectionStatus.BackColor = Color.Red;
                MessageBox.Show("Please check the Hardware and Please connect again. " + ex.Message, "Connection failed !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCSKn7BgKe43S03ktTMThzLw");
        }
    }
}
