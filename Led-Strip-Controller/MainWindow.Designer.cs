namespace Led_Strip_Controller
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxCOMPort = new System.Windows.Forms.ToolStripComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sliderR = new System.Windows.Forms.TrackBar();
            this.sliderG = new System.Windows.Forms.TrackBar();
            this.sliderB = new System.Windows.Forms.TrackBar();
            this.fixedColor = new System.Windows.Forms.Label();
            this.barL = new System.Windows.Forms.ProgressBar();
            this.barR = new System.Windows.Forms.ProgressBar();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sliderMult = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sliderAmp = new System.Windows.Forms.TrackBar();
            this.sliderBri = new System.Windows.Forms.TrackBar();
            this.audioColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkFixed = new System.Windows.Forms.CheckBox();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBri)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(690, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxCOMPort});
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.comPortToolStripMenuItem.Text = "COM Port";
            // 
            // toolStripComboBoxCOMPort
            // 
            this.toolStripComboBoxCOMPort.MaxDropDownItems = 32;
            this.toolStripComboBoxCOMPort.Name = "toolStripComboBoxCOMPort";
            this.toolStripComboBoxCOMPort.Size = new System.Drawing.Size(121, 23);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // sliderR
            // 
            this.sliderR.Location = new System.Drawing.Point(53, 27);
            this.sliderR.Maximum = 255;
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(104, 45);
            this.sliderR.TabIndex = 1;
            this.sliderR.TickFrequency = 0;
            this.sliderR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderR.Value = 255;
            this.sliderR.Scroll += new System.EventHandler(this.trackBars);
            // 
            // sliderG
            // 
            this.sliderG.Location = new System.Drawing.Point(53, 78);
            this.sliderG.Maximum = 255;
            this.sliderG.Name = "sliderG";
            this.sliderG.Size = new System.Drawing.Size(104, 45);
            this.sliderG.TabIndex = 2;
            this.sliderG.TickFrequency = 0;
            this.sliderG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderG.Scroll += new System.EventHandler(this.trackBars);
            // 
            // sliderB
            // 
            this.sliderB.Location = new System.Drawing.Point(53, 129);
            this.sliderB.Maximum = 255;
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(104, 45);
            this.sliderB.TabIndex = 3;
            this.sliderB.TickFrequency = 0;
            this.sliderB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderB.Scroll += new System.EventHandler(this.trackBars);
            // 
            // fixedColor
            // 
            this.fixedColor.AutoSize = true;
            this.fixedColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Bold);
            this.fixedColor.ForeColor = System.Drawing.Color.Red;
            this.fixedColor.Location = new System.Drawing.Point(116, -14);
            this.fixedColor.Name = "fixedColor";
            this.fixedColor.Size = new System.Drawing.Size(203, 189);
            this.fixedColor.TabIndex = 4;
            this.fixedColor.Text = "■";
            // 
            // barL
            // 
            this.barL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barL.Location = new System.Drawing.Point(12, 216);
            this.barL.MarqueeAnimationSpeed = 25565;
            this.barL.Name = "barL";
            this.barL.Size = new System.Drawing.Size(360, 23);
            this.barL.TabIndex = 6;
            // 
            // barR
            // 
            this.barR.Location = new System.Drawing.Point(12, 245);
            this.barR.MarqueeAnimationSpeed = 0;
            this.barR.Name = "barR";
            this.barR.Size = new System.Drawing.Size(360, 23);
            this.barR.TabIndex = 7;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(378, 216);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(300, 21);
            this.comboBoxDevice.TabIndex = 8;
            this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDev_SelIndChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sliderMult
            // 
            this.sliderMult.Location = new System.Drawing.Point(146, 180);
            this.sliderMult.Name = "sliderMult";
            this.sliderMult.Size = new System.Drawing.Size(226, 45);
            this.sliderMult.TabIndex = 9;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(9, 27);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(37, 16);
            this.labelRed.TabIndex = 10;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.ForeColor = System.Drawing.Color.Lime;
            this.labelGreen.Location = new System.Drawing.Point(9, 76);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(50, 16);
            this.labelGreen.TabIndex = 11;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(9, 127);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(39, 16);
            this.labelBlue.TabIndex = 12;
            this.labelBlue.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Volume Multiplyer";
            // 
            // sliderAmp
            // 
            this.sliderAmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderAmp.Enabled = false;
            this.sliderAmp.Location = new System.Drawing.Point(0, 274);
            this.sliderAmp.Name = "sliderAmp";
            this.sliderAmp.Size = new System.Drawing.Size(380, 45);
            this.sliderAmp.TabIndex = 14;
            // 
            // sliderBri
            // 
            this.sliderBri.Location = new System.Drawing.Point(440, 245);
            this.sliderBri.Maximum = 100;
            this.sliderBri.Name = "sliderBri";
            this.sliderBri.Size = new System.Drawing.Size(238, 45);
            this.sliderBri.TabIndex = 16;
            this.sliderBri.TickFrequency = 0;
            this.sliderBri.Value = 100;
            this.sliderBri.Scroll += new System.EventHandler(this.hsv);
            // 
            // audioColor
            // 
            this.audioColor.AutoSize = true;
            this.audioColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Bold);
            this.audioColor.Location = new System.Drawing.Point(349, -14);
            this.audioColor.Name = "audioColor";
            this.audioColor.Size = new System.Drawing.Size(203, 189);
            this.audioColor.TabIndex = 18;
            this.audioColor.Text = "■";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Brightness";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fixed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Audio";
            // 
            // checkFixed
            // 
            this.checkFixed.AutoCheck = false;
            this.checkFixed.AutoSize = true;
            this.checkFixed.Checked = true;
            this.checkFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFixed.Location = new System.Drawing.Point(295, 78);
            this.checkFixed.Name = "checkFixed";
            this.checkFixed.Size = new System.Drawing.Size(15, 14);
            this.checkFixed.TabIndex = 22;
            this.checkFixed.UseVisualStyleBackColor = true;
            this.checkFixed.Click += new System.EventHandler(this.checkClick);
            // 
            // checkAudio
            // 
            this.checkAudio.AutoCheck = false;
            this.checkAudio.AutoSize = true;
            this.checkAudio.Location = new System.Drawing.Point(333, 78);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(15, 14);
            this.checkAudio.TabIndex = 23;
            this.checkAudio.UseVisualStyleBackColor = true;
            this.checkAudio.Click += new System.EventHandler(this.checkClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Control";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(690, 339);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkAudio);
            this.Controls.Add(this.checkFixed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sliderBri);
            this.Controls.Add(this.sliderAmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.barR);
            this.Controls.Add(this.barL);
            this.Controls.Add(this.sliderB);
            this.Controls.Add(this.sliderG);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.fixedColor);
            this.Controls.Add(this.sliderMult);
            this.Controls.Add(this.audioColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "LED Controller";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCOMPort;
        private System.Windows.Forms.TrackBar sliderR;
        private System.Windows.Forms.TrackBar sliderG;
        private System.Windows.Forms.TrackBar sliderB;
        private System.Windows.Forms.Label fixedColor;
        private System.Windows.Forms.ProgressBar barL;
        private System.Windows.Forms.ProgressBar barR;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar sliderMult;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar sliderAmp;
        private System.Windows.Forms.TrackBar sliderBri;
        private System.Windows.Forms.Label audioColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkFixed;
        private System.Windows.Forms.CheckBox checkAudio;
        private System.Windows.Forms.Label label10;
    }
}

