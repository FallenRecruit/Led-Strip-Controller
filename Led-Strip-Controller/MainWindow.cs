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
using System.Configuration;
using System.Diagnostics;

namespace Led_Strip_Controller
{
    public partial class MainWindow : Form
    {

        //TODO
        //setup color set

        Analyzer analyzer;
        SerialStream serial;


        bool loaded = false;

        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        int _devIndex = Convert.ToInt32(ConfigurationManager.AppSettings["device"]);
        int _fixR = Convert.ToInt32(ConfigurationManager.AppSettings["FixedR"]);
        int _fixG = Convert.ToInt32(ConfigurationManager.AppSettings["FixedG"]);
        int _fixB = Convert.ToInt32(ConfigurationManager.AppSettings["FixedB"]);

        int _scroll = 0;

        public MainWindow()
        {
            InitializeComponent();
            
            sliderAmp.Maximum = (ushort.MaxValue);

            analyzer = new Analyzer(barL, barR, comboBoxDevice, sliderMult, _devIndex)
            {Enable = true, DisplayEnable = true};

            serial = new SerialStream();

            tickTimer.Enabled = true;

            sliderR.Value = _fixR;
            sliderG.Value = _fixG;
            sliderB.Value = _fixB;
            SetFixed();
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    toolStripComboBoxCOMPort.Items.AddRange(new object[] { port });
                }
                toolStripComboBoxCOMPort.SelectedIndex = 0;
                serial.SetPort(toolStripComboBoxCOMPort.Text);
            }
            catch { }

            loaded = true;
        }

        private void SaveSettings()
        {
            config.AppSettings.Settings.Clear();
            config.AppSettings.Settings.Add("Device", comboBoxDevice.SelectedIndex.ToString());
            config.AppSettings.Settings.Add("FixedR", sliderR.Value.ToString());
            config.AppSettings.Settings.Add("FixedG", sliderG.Value.ToString());
            config.AppSettings.Settings.Add("FixedB", sliderB.Value.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void ToolStripComboBoxCOMPort_Changed(object sender, EventArgs e)
        {
            serial.SetPort(toolStripComboBoxCOMPort.Text);
        }

        double Map(double val, double inMin, double inMax, double outMin, double outMax)
        {
            return outMin + (val - inMin) * (outMax - outMin) / (inMax - inMin);
        }
        
        private void CheckClick(object sender, EventArgs e)
        {
            CheckBox[] active = new CheckBox[] { checkFixed, checkAudio, checkCustom, checkFade};

            CheckBox clicked = sender as CheckBox;
            
            foreach (CheckBox box in active)
            {
                box.Checked = false;
            }
            
            clicked.Checked = true;
            
        }


        /// <summary>
        /// Convert HSV to RGB
        /// h is from 0-360
        /// s,v values are 0.0-1.0
        /// r,g,b values are 0-255
        /// Based upon http://ilab.usc.edu/wiki/index.php/HSV_And_H2SV_Color_Space#HSV_Transformation_C_.2F_C.2B.2B_Code_2
        /// </summary>
        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            // ######################################################################
            // T. Nathan Mundhenk
            // mundhenk@usc.edu
            // C/C++ Macro HSV to RGB

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }
        
        /// <summary>
        /// Code for Fixed color pannel
        /// </summary>
        /// <param name="Fixed color"></param>

        private void SetFixed()
        {
            fixedColor.BackColor = Color.FromArgb(sliderR.Value, sliderG.Value, sliderB.Value);
            serial.SetArgb(255,sliderR.Value,sliderG.Value,sliderB.Value);
        }

        private void RgbBars(object sender, EventArgs e) { SetFixed(); }

        /// <summary>
        /// Code for Audio react pannel
        /// </summary>
        /// <param name="Audio react"></param>

        private void ComboBoxDev_SelIndChanged(object sender, EventArgs e)
        {
            SaveSettings();
            if (loaded)
            {
                DialogResult dialogResult = MessageBox.Show("Program needs to restart to change audio device, would you like to restart",
                    "Restart me?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(AppDomain.CurrentDomain.FriendlyName);
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No) {/*do nothing*/}
            }
            //analyzer.ChangeInput();  
        }

        private void EventTick(object sender, EventArgs e)
        {
            try { sliderAmp.Value = analyzer.Outlev(); sliderAmp.BackColor = Color.White; } catch { sliderAmp.BackColor = Color.Red; }
            Slider();
        }

        private void Hsv(object sender, EventArgs e) { Slider(); }

        private double Offset(double _in)
        {
            _in = _in + sliderOffset.Value;

            if (_in > 360)
            {
                _in = _in - 360;
            }

            return _in;
        }

        private void Slider()
        {
            double hue = Offset( Map( sliderAmp.Value, 0, ushort.MaxValue, 0, 360));
            double sat = (double)sliderAudioBri.Value / 100;
            HsvToRgb(hue, sat, 1.0, out int red, out int green, out int blue);

            audioColor.BackColor = Color.FromArgb(red, green, blue);
            //serial.SetArgb(255,red,green,blue);
        }

        /// <summary>
        /// Code for custom pattern pannel
        /// </summary>
        /// <param name="Custom Pattern"></param>

        private void CustomPattern_Click(object sender, EventArgs e)
        {
            PictureBox pan = sender as PictureBox;
            ColorSelect(pan);
        }

        private void ColorSelect(PictureBox pan)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                Color = pan.BackColor
            };

            if (MyDialog.ShowDialog() == DialogResult.OK)
                pan.BackColor = MyDialog.Color;
        }

        /// <summary>
        /// Code for custom scroll pannel
        /// </summary>
        /// <param name="Custom Pattern"></param>

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            _scroll++;

            if (_scroll > 360) { _scroll = 0; }

            double hue = _scroll;
            double sat = (double)fadeScrollBri.Value / 100;
            HsvToRgb(hue, sat, 1.0, out int red, out int green, out int blue);

            fadeColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private void SliderScrollSpeed_Scroll(object sender, EventArgs e)
        {
            scrollTimer.Interval = fadeScrollSpeed.Value;

        }


    }
}
