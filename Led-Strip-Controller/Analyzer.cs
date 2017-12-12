using System;
using System.Collections.Generic;
using System.IO.Ports;
//using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using Un4seen.Bass;
using Un4seen.BassWasapi;
using System.Windows.Forms.DataVisualization.Charting;

namespace Led_Strip_Controller
{

    internal class Analyzer
    {
        private bool _enable;               //enabled status
        private DispatcherTimer _t;         //timer that refreshes the display
        public float[] _fft;               //buffer for fft data
        private ProgressBar _l, _r;         //progressbars for left and right channel intensity
        private WASAPIPROC _process;        //callback function to obtain data
        private int _lastlevel;             //last output level
        private int _hanctr;                //last output level counter
        private ComboBox _devicelist;       //device list
        private bool _initialized;          //initialized flag
        private int devindex;               //used device index
        private int _deviceindex;
        private TrackBar _m;


        //ctor
        public Analyzer(ProgressBar left, ProgressBar right, ComboBox devicelist, TrackBar multiplyer, int deviceindex)
        {
            _m = multiplyer;
            _m.Minimum = 1;
            _m.Maximum = 10;
            _fft = new float[8192];
            _lastlevel = 0;
            _hanctr = 0;
            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(25); //40hz refresh rate//25
            _t.IsEnabled = false;
            _l = left;
            _r = right;
            _l.Minimum = 0;
            _r.Minimum = 0;
            _r.Maximum = (ushort.MaxValue);
            _l.Maximum = (ushort.MaxValue);
            _process = new WASAPIPROC(Process);
            _devicelist = devicelist;
            _initialized = false;
            _deviceindex = deviceindex;

            Init();
        }

        // Serial port for arduino output


        // flag for display enable
        public bool DisplayEnable { get; set; }

        //flag for enabling and disabling program functionality
        public bool Enable
        {
            get { return _enable; }
            set
            {
                _enable = value;
                if (value)
                {
                    if (!_initialized)
                    {
                        var array = (_devicelist.Items[_deviceindex] as string).Split(' ');
                        _devicelist.SelectedIndex = _deviceindex;
                        devindex = Convert.ToInt32(array[0]);
                        bool result = BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
                        if (!result)
                        {
                            
                            var error = Bass.BASS_ErrorGetCode();
                            MessageBox.Show(error.ToString());
                        }
                        else
                        {
                            _initialized = true;
                            //_devicelist.Enabled = false;
                        }
                    }
                    BassWasapi.BASS_WASAPI_Start();
                }
                else BassWasapi.BASS_WASAPI_Stop(true);
                System.Threading.Thread.Sleep(500);
                _t.IsEnabled = value;
            }
        }

        //Changeing input
        public void ChangeInput()
        {

            var array = (_devicelist.Items[_devicelist.SelectedIndex] as string).Split(' ');
            BassWasapi.BASS_WASAPI_Stop(true);
            devindex = Convert.ToInt32(array[_devicelist.SelectedIndex]);
            bool result = BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
            if (!result)
            {

                var error = Bass.BASS_ErrorGetCode();
                MessageBox.Show(error.ToString());
            }
            else
            {
                _initialized = true;
                //_devicelist.Enabled = false;
            }

            BassWasapi.BASS_WASAPI_Start();

        }

        // initialization
        private void Init()
        {
            bool result = false;
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    _devicelist.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            _devicelist.SelectedIndex = 0;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            if (!result) throw new Exception("Init Error");
        }

        //timer 
        private void _t_Tick(object sender, EventArgs e)
        {
            int ret = BassWasapi.BASS_WASAPI_GetData(_fft, (int)BASSData.BASS_DATA_FFT8192);  //get ch.annel fft data
            if (ret < -1) return;
            

            int level = BassWasapi.BASS_WASAPI_GetLevel();
            int multi = _m.Value;
            try
            {
                _l.Value = (Utils.LowWord32(level)) * multi;
                _r.Value = (Utils.HighWord32(level)) * multi;
            }
            catch
            {

            }
            
            if (level == _lastlevel && level != 0) _hanctr++;
            _lastlevel = level;

            //Required, because some programs hang the output. If the output hangs for a 75ms
            //this piece of code re initializes the output so it doesn't make a gliched sound for long.
            if (_hanctr > 3)
            {
                _hanctr = 0;
                _l.Value = (0);
                _r.Value = (0);
                Free();
                Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                _initialized = false;
                Enable = true;
            }

        }

        public int outlev()
        {
            int lev = 0;
            int r = 0;
            int l = 0;
            int level = BassWasapi.BASS_WASAPI_GetLevel();
            int multi = _m.Value;
            try
            {
                l = (Utils.LowWord32(level)) * multi;
                r = (Utils.HighWord32(level)) * multi;
            }
            catch
            {

            }

            lev = (l + r) / 2;

            return lev;
        }

        // WASAPI callback, required for continuous recording
        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        //cleanup
        public void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }
    }
}
