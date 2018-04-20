using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using GodSharp;

namespace Led_Strip_Controller
{
    class SerialStream
    {
        private GodSerialPort _port;
        private DispatcherTimer _t;
        private byte _a = 255, _r = 255, _g = 255, _b = 255;

        public SerialStream()
        {
            _port = new GodSerialPort("COM5", 38400);

            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(4.1666666666667); //240hz refresh rate
            _t.IsEnabled = false;
        }

        private void _t_Tick(object sender, EventArgs e)
        {
            _port.Open();
            _port.WriteAsciiString(Convert.ToString(_r) + "," + Convert.ToString(_g) + "," + Convert.ToString(_b) + '\n');
            _port.DiscardOutBuffer();
            _port.Close();

        }

        public void SetPort(string Port)
        {
            _port.PortName = Port;
            try
            {
                _port.Open();
                if (_port.IsOpen) _t.IsEnabled = true;
                _port.Close();
            }
            catch
            {
                MessageBox.Show("Could not open" + _port.PortName,
                    "Error", MessageBoxButtons.OK);
                _t.IsEnabled = false;
            }
        }

        public string debug()
        {
            return null;
        }

        double Map(double val, double inMin, double inMax, double outMin, double outMax)
        {
            return outMin + (val - inMin) * (outMax - outMin) / (inMax - inMin);
        }

        //public void SetRgb(byte r, byte g, byte b) { _r = r; _g = g; _b = b; }
        public void SetArgb(byte a, byte r, byte g, byte b) { _a = a; _r = r; _g = g; _b = b; }
    }
}
