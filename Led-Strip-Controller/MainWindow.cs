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

namespace Led_Strip_Controller
{
    public partial class MainWindow : Form
    {
        Analyzer analyzer;


        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        int _devIndex = Convert.ToInt32(ConfigurationManager.AppSettings["device"]);
        int _fixR = Convert.ToInt32(ConfigurationManager.AppSettings["FixedR"]);
        int _fixG = Convert.ToInt32(ConfigurationManager.AppSettings["FixedG"]);
        int _fixB = Convert.ToInt32(ConfigurationManager.AppSettings["FixedB"]);

        public MainWindow()
        {
            InitializeComponent();

            sliderAmp.Maximum = (ushort.MaxValue);

            analyzer = new Analyzer(barL, barR, null, comboBoxDevice, null, sliderMult, _devIndex);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            timer1.Enabled = true;

            sliderR.Value = _fixR;
            sliderG.Value = _fixG;
            sliderB.Value = _fixB;
            setFixed();

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                toolStripComboBoxCOMPort.Items.AddRange(new object[] { port });
            }
            toolStripComboBoxCOMPort.SelectedIndex = 0;
        }

        private void setFixed()
        {
            fixedColor.ForeColor = Color.FromArgb(sliderR.Value, sliderG.Value, sliderB.Value);
        }

        private void trackBars(object sender, EventArgs e) { setFixed(); }

        private void comboBoxDev_SelIndChanged(object sender, EventArgs e)
        {
            saveSettings();

            //analyzer.ChangeInput();  
        }

        private void saveSettings()
        {
            config.AppSettings.Settings.Clear();
            config.AppSettings.Settings.Add("Device", comboBoxDevice.SelectedIndex.ToString());
            config.AppSettings.Settings.Add("FixedR", sliderR.Value.ToString());
            config.AppSettings.Settings.Add("FixedG", sliderG.Value.ToString());
            config.AppSettings.Settings.Add("FixedB", sliderB.Value.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { sliderAmp.Value = analyzer.outlev(); sliderAmp.BackColor = Color.FromArgb(64,64,64); } catch (Exception g) { sliderAmp.BackColor = Color.Red; }
            slider();
        }

        /// <summary>
        /// Convert HSV to RGB
        /// h is from 0-360
        /// s,v values are 0-1
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

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }

        private void hsv(object sender, EventArgs e) { slider(); }

        private void slider()
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            double hue = map(sliderAmp.Value,0, ushort.MaxValue,0,360);
            double sat = (double)sliderBri.Value / 100;
            HsvToRgb(hue, sat, 1.0, out red,  out green, out blue);

            audioColor.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void checkClick(object sender, EventArgs e)
        {
            checkFixed.Checked = !checkFixed.Checked;
            checkAudio.Checked = !checkAudio.Checked;

        }
    }
}
