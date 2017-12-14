using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Led_Strip_Controller
{
    class SerialStream
    {
        private SerialPort _port;
        private DispatcherTimer _t;
        private int _a = 255, _r = 255, _g = 255, _b = 255;

        public SerialStream()
        {
            _port = new SerialPort
            {
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                Encoding = Encoding.Default
            };

            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(1000);//4.1666666666667); //240hz refresh rate
            _t.IsEnabled = false;
        }

        private void _t_Tick(object sender, EventArgs e)
        {
            _port.Open();
            _port.Write(_a +":"+ _r +":"+ _g +":"+ _b + ":");
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

        public void SetRgb(int r, int g, int b) { _r = r; _g = g; _b = b;}
        public void SetArgb(int a, int r, int g, int b) { _a = a; _r = r; _g = g; _b = b; }
    }
}
