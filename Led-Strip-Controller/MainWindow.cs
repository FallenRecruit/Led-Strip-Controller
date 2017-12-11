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

namespace Led_Strip_Controller
{
    public partial class MainWindow : Form
    {
        Analyzer analyzer;

        public MainWindow()
        {
            InitializeComponent();

            analyzer = new Analyzer(progressBar1, progressBar2, null , comboBox1, chart1);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            timer1.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                toolStripComboBoxCOMPort.Items.AddRange(new object[] { port });
            }
        }




        



        private void Set()
        {
            label1.ForeColor = Color.FromArgb(trackBar1.Value,trackBar2.Value ,trackBar3.Value  );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Set();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Set();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Set();
        }
    }
}
