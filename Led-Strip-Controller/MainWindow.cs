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

            trackBar5.Maximum = (ushort.MaxValue);

            analyzer = new Analyzer(progressBar1, progressBar2, null, comboBox1, null, trackBar4);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            timer1.Enabled = true;

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                toolStripComboBoxCOMPort.Items.AddRange(new object[] { port });
            }
            toolStripComboBoxCOMPort.SelectedIndex = 0;
        }

        private void Set()
        {
            label1.ForeColor = Color.FromArgb(trackBar1.Value,trackBar2.Value ,trackBar3.Value );
            
        }
        
        private void trackBars(object sender, EventArgs e) {Set();}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //analyzer.ChangeInput();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try{trackBar5.Value = analyzer.outlev();} catch { }
        }

    }
}
