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
            this.barL = new System.Windows.Forms.ProgressBar();
            this.barR = new System.Windows.Forms.ProgressBar();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.sliderMult = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.audioMultipLabel = new System.Windows.Forms.Label();
            this.sliderAmp = new System.Windows.Forms.TrackBar();
            this.sliderAudioBri = new System.Windows.Forms.TrackBar();
            this.audioBrightLabel = new System.Windows.Forms.Label();
            this.fixedLabel = new System.Windows.Forms.Label();
            this.audioLabel = new System.Windows.Forms.Label();
            this.checkFixed = new System.Windows.Forms.CheckBox();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.audioPanel = new System.Windows.Forms.Panel();
            this.audioOffsetLabel = new System.Windows.Forms.Label();
            this.audioColor = new System.Windows.Forms.Panel();
            this.sliderOffset = new System.Windows.Forms.TrackBar();
            this.fixedPanel = new System.Windows.Forms.Panel();
            this.fixedColor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.patternLabel0 = new System.Windows.Forms.Label();
            this.customPattern6 = new System.Windows.Forms.PictureBox();
            this.customPattern5 = new System.Windows.Forms.PictureBox();
            this.customPattern4 = new System.Windows.Forms.PictureBox();
            this.customPattern3 = new System.Windows.Forms.PictureBox();
            this.customPattern2 = new System.Windows.Forms.PictureBox();
            this.customPattern1 = new System.Windows.Forms.PictureBox();
            this.customPattern0 = new System.Windows.Forms.PictureBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.customColor = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.patternLabel1 = new System.Windows.Forms.Label();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.fadeScrollBri = new System.Windows.Forms.TrackBar();
            this.fadeBrightLabel = new System.Windows.Forms.Label();
            this.fadeSpeedLabel = new System.Windows.Forms.Label();
            this.fadeColor = new System.Windows.Forms.Panel();
            this.checkFade = new System.Windows.Forms.CheckBox();
            this.fadeLabel = new System.Windows.Forms.Label();
            this.fadeScrollSpeed = new System.Windows.Forms.TrackBar();
            this.scrollTimer = new System.Windows.Forms.Timer(this.components);
            this.serialTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAudioBri)).BeginInit();
            this.audioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOffset)).BeginInit();
            this.fixedPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern0)).BeginInit();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fadeScrollBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fadeScrollSpeed)).BeginInit();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(907, 24);
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
            this.toolStripComboBoxCOMPort.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBoxCOMPort_Changed);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // sliderR
            // 
            this.sliderR.Location = new System.Drawing.Point(110, 35);
            this.sliderR.Maximum = 255;
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(104, 45);
            this.sliderR.TabIndex = 1;
            this.sliderR.TickFrequency = 0;
            this.sliderR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderR.Value = 255;
            this.sliderR.Scroll += new System.EventHandler(this.RgbBars);
            // 
            // sliderG
            // 
            this.sliderG.Location = new System.Drawing.Point(110, 64);
            this.sliderG.Maximum = 255;
            this.sliderG.Name = "sliderG";
            this.sliderG.Size = new System.Drawing.Size(104, 45);
            this.sliderG.TabIndex = 2;
            this.sliderG.TickFrequency = 0;
            this.sliderG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderG.Value = 255;
            this.sliderG.Scroll += new System.EventHandler(this.RgbBars);
            // 
            // sliderB
            // 
            this.sliderB.Location = new System.Drawing.Point(109, 93);
            this.sliderB.Maximum = 255;
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(104, 45);
            this.sliderB.TabIndex = 3;
            this.sliderB.TickFrequency = 0;
            this.sliderB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderB.Value = 255;
            this.sliderB.Scroll += new System.EventHandler(this.RgbBars);
            // 
            // barL
            // 
            this.barL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barL.Location = new System.Drawing.Point(68, 62);
            this.barL.MarqueeAnimationSpeed = 25565;
            this.barL.Name = "barL";
            this.barL.Size = new System.Drawing.Size(360, 23);
            this.barL.TabIndex = 6;
            // 
            // barR
            // 
            this.barR.Location = new System.Drawing.Point(68, 91);
            this.barR.MarqueeAnimationSpeed = 0;
            this.barR.Name = "barR";
            this.barR.Size = new System.Drawing.Size(360, 23);
            this.barR.TabIndex = 7;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(434, 62);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(300, 21);
            this.comboBoxDevice.TabIndex = 8;
            this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDev_SelIndChanged);
            // 
            // tickTimer
            // 
            this.tickTimer.Tick += new System.EventHandler(this.EventTick);
            // 
            // sliderMult
            // 
            this.sliderMult.LargeChange = 1;
            this.sliderMult.Location = new System.Drawing.Point(202, 26);
            this.sliderMult.Name = "sliderMult";
            this.sliderMult.Size = new System.Drawing.Size(226, 45);
            this.sliderMult.TabIndex = 9;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(65, 35);
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
            this.labelGreen.Location = new System.Drawing.Point(65, 64);
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
            this.labelBlue.Location = new System.Drawing.Point(65, 93);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(39, 16);
            this.labelBlue.TabIndex = 12;
            this.labelBlue.Text = "Blue";
            // 
            // audioMultipLabel
            // 
            this.audioMultipLabel.AutoSize = true;
            this.audioMultipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioMultipLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.audioMultipLabel.Location = new System.Drawing.Point(68, 33);
            this.audioMultipLabel.Name = "audioMultipLabel";
            this.audioMultipLabel.Size = new System.Drawing.Size(131, 16);
            this.audioMultipLabel.TabIndex = 13;
            this.audioMultipLabel.Text = "Volume Multiplyer";
            // 
            // sliderAmp
            // 
            this.sliderAmp.BackColor = System.Drawing.Color.White;
            this.sliderAmp.Enabled = false;
            this.sliderAmp.Location = new System.Drawing.Point(58, 120);
            this.sliderAmp.Name = "sliderAmp";
            this.sliderAmp.Size = new System.Drawing.Size(380, 45);
            this.sliderAmp.TabIndex = 14;
            // 
            // sliderAudioBri
            // 
            this.sliderAudioBri.Location = new System.Drawing.Point(521, 91);
            this.sliderAudioBri.Maximum = 100;
            this.sliderAudioBri.Name = "sliderAudioBri";
            this.sliderAudioBri.Size = new System.Drawing.Size(213, 45);
            this.sliderAudioBri.TabIndex = 16;
            this.sliderAudioBri.TickFrequency = 0;
            this.sliderAudioBri.Value = 100;
            this.sliderAudioBri.Scroll += new System.EventHandler(this.Hsv);
            // 
            // audioBrightLabel
            // 
            this.audioBrightLabel.AutoSize = true;
            this.audioBrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.audioBrightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.audioBrightLabel.Location = new System.Drawing.Point(434, 101);
            this.audioBrightLabel.Name = "audioBrightLabel";
            this.audioBrightLabel.Size = new System.Drawing.Size(81, 16);
            this.audioBrightLabel.TabIndex = 19;
            this.audioBrightLabel.Text = "Brightness";
            // 
            // fixedLabel
            // 
            this.fixedLabel.AutoSize = true;
            this.fixedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedLabel.Location = new System.Drawing.Point(16, 16);
            this.fixedLabel.Name = "fixedLabel";
            this.fixedLabel.Size = new System.Drawing.Size(46, 16);
            this.fixedLabel.TabIndex = 20;
            this.fixedLabel.Text = "Fixed";
            // 
            // audioLabel
            // 
            this.audioLabel.AutoSize = true;
            this.audioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioLabel.Location = new System.Drawing.Point(16, 13);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(48, 16);
            this.audioLabel.TabIndex = 21;
            this.audioLabel.Text = "Audio";
            // 
            // checkFixed
            // 
            this.checkFixed.AutoCheck = false;
            this.checkFixed.AutoSize = true;
            this.checkFixed.Checked = true;
            this.checkFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFixed.Location = new System.Drawing.Point(30, 70);
            this.checkFixed.Name = "checkFixed";
            this.checkFixed.Size = new System.Drawing.Size(15, 14);
            this.checkFixed.TabIndex = 22;
            this.checkFixed.UseVisualStyleBackColor = true;
            this.checkFixed.Click += new System.EventHandler(this.CheckClick);
            // 
            // checkAudio
            // 
            this.checkAudio.AutoCheck = false;
            this.checkAudio.AutoSize = true;
            this.checkAudio.Location = new System.Drawing.Point(30, 70);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(15, 14);
            this.checkAudio.TabIndex = 23;
            this.checkAudio.UseVisualStyleBackColor = true;
            this.checkAudio.Click += new System.EventHandler(this.CheckClick);
            // 
            // audioPanel
            // 
            this.audioPanel.BackColor = System.Drawing.Color.White;
            this.audioPanel.Controls.Add(this.audioOffsetLabel);
            this.audioPanel.Controls.Add(this.audioColor);
            this.audioPanel.Controls.Add(this.barL);
            this.audioPanel.Controls.Add(this.checkAudio);
            this.audioPanel.Controls.Add(this.barR);
            this.audioPanel.Controls.Add(this.comboBoxDevice);
            this.audioPanel.Controls.Add(this.audioLabel);
            this.audioPanel.Controls.Add(this.audioMultipLabel);
            this.audioPanel.Controls.Add(this.sliderAmp);
            this.audioPanel.Controls.Add(this.audioBrightLabel);
            this.audioPanel.Controls.Add(this.sliderAudioBri);
            this.audioPanel.Controls.Add(this.sliderMult);
            this.audioPanel.Controls.Add(this.sliderOffset);
            this.audioPanel.Location = new System.Drawing.Point(12, 197);
            this.audioPanel.Name = "audioPanel";
            this.audioPanel.Size = new System.Drawing.Size(880, 155);
            this.audioPanel.TabIndex = 25;
            // 
            // audioOffsetLabel
            // 
            this.audioOffsetLabel.AutoSize = true;
            this.audioOffsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioOffsetLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.audioOffsetLabel.Location = new System.Drawing.Point(434, 33);
            this.audioOffsetLabel.Name = "audioOffsetLabel";
            this.audioOffsetLabel.Size = new System.Drawing.Size(34, 16);
            this.audioOffsetLabel.TabIndex = 25;
            this.audioOffsetLabel.Text = "Idle";
            // 
            // audioColor
            // 
            this.audioColor.BackColor = System.Drawing.Color.Red;
            this.audioColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioColor.Location = new System.Drawing.Point(740, 16);
            this.audioColor.Name = "audioColor";
            this.audioColor.Size = new System.Drawing.Size(125, 125);
            this.audioColor.TabIndex = 24;
            // 
            // sliderOffset
            // 
            this.sliderOffset.LargeChange = 10;
            this.sliderOffset.Location = new System.Drawing.Point(474, 26);
            this.sliderOffset.Maximum = 360;
            this.sliderOffset.Name = "sliderOffset";
            this.sliderOffset.Size = new System.Drawing.Size(260, 45);
            this.sliderOffset.TabIndex = 26;
            this.sliderOffset.TickFrequency = 20;
            // 
            // fixedPanel
            // 
            this.fixedPanel.BackColor = System.Drawing.Color.White;
            this.fixedPanel.Controls.Add(this.fixedColor);
            this.fixedPanel.Controls.Add(this.checkFixed);
            this.fixedPanel.Controls.Add(this.fixedLabel);
            this.fixedPanel.Controls.Add(this.sliderB);
            this.fixedPanel.Controls.Add(this.labelBlue);
            this.fixedPanel.Controls.Add(this.labelRed);
            this.fixedPanel.Controls.Add(this.labelGreen);
            this.fixedPanel.Controls.Add(this.sliderG);
            this.fixedPanel.Controls.Add(this.sliderR);
            this.fixedPanel.Location = new System.Drawing.Point(12, 36);
            this.fixedPanel.Name = "fixedPanel";
            this.fixedPanel.Size = new System.Drawing.Size(365, 155);
            this.fixedPanel.TabIndex = 26;
            // 
            // fixedColor
            // 
            this.fixedColor.BackColor = System.Drawing.Color.White;
            this.fixedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fixedColor.Location = new System.Drawing.Point(220, 16);
            this.fixedColor.Name = "fixedColor";
            this.fixedColor.Size = new System.Drawing.Size(125, 125);
            this.fixedColor.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.patternLabel0);
            this.panel3.Controls.Add(this.customPattern6);
            this.panel3.Controls.Add(this.customPattern5);
            this.panel3.Controls.Add(this.customPattern4);
            this.panel3.Controls.Add(this.customPattern3);
            this.panel3.Controls.Add(this.customPattern2);
            this.panel3.Controls.Add(this.customPattern1);
            this.panel3.Controls.Add(this.customPattern0);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.customColor);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkCustom);
            this.panel3.Controls.Add(this.patternLabel1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(13, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 155);
            this.panel3.TabIndex = 27;
            // 
            // patternLabel0
            // 
            this.patternLabel0.AutoSize = true;
            this.patternLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel0.Location = new System.Drawing.Point(15, 16);
            this.patternLabel0.Name = "patternLabel0";
            this.patternLabel0.Size = new System.Drawing.Size(59, 16);
            this.patternLabel0.TabIndex = 38;
            this.patternLabel0.Text = "Custom";
            // 
            // customPattern6
            // 
            this.customPattern6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customPattern6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern6.Location = new System.Drawing.Point(506, 52);
            this.customPattern6.Name = "customPattern6";
            this.customPattern6.Size = new System.Drawing.Size(60, 60);
            this.customPattern6.TabIndex = 37;
            this.customPattern6.TabStop = false;
            this.customPattern6.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern5
            // 
            this.customPattern5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customPattern5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern5.Location = new System.Drawing.Point(436, 52);
            this.customPattern5.Name = "customPattern5";
            this.customPattern5.Size = new System.Drawing.Size(60, 60);
            this.customPattern5.TabIndex = 36;
            this.customPattern5.TabStop = false;
            this.customPattern5.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern4
            // 
            this.customPattern4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customPattern4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern4.Location = new System.Drawing.Point(366, 52);
            this.customPattern4.Name = "customPattern4";
            this.customPattern4.Size = new System.Drawing.Size(60, 60);
            this.customPattern4.TabIndex = 35;
            this.customPattern4.TabStop = false;
            this.customPattern4.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern3
            // 
            this.customPattern3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPattern3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern3.Location = new System.Drawing.Point(296, 52);
            this.customPattern3.Name = "customPattern3";
            this.customPattern3.Size = new System.Drawing.Size(60, 60);
            this.customPattern3.TabIndex = 34;
            this.customPattern3.TabStop = false;
            this.customPattern3.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern2
            // 
            this.customPattern2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPattern2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern2.Location = new System.Drawing.Point(226, 52);
            this.customPattern2.Name = "customPattern2";
            this.customPattern2.Size = new System.Drawing.Size(60, 60);
            this.customPattern2.TabIndex = 33;
            this.customPattern2.TabStop = false;
            this.customPattern2.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern1
            // 
            this.customPattern1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customPattern1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern1.Location = new System.Drawing.Point(156, 52);
            this.customPattern1.Name = "customPattern1";
            this.customPattern1.Size = new System.Drawing.Size(60, 60);
            this.customPattern1.TabIndex = 32;
            this.customPattern1.TabStop = false;
            this.customPattern1.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // customPattern0
            // 
            this.customPattern0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customPattern0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPattern0.Location = new System.Drawing.Point(86, 52);
            this.customPattern0.Name = "customPattern0";
            this.customPattern0.Size = new System.Drawing.Size(60, 60);
            this.customPattern0.TabIndex = 31;
            this.customPattern0.TabStop = false;
            this.customPattern0.Click += new System.EventHandler(this.CustomPattern_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(530, 32);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 30;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // customColor
            // 
            this.customColor.BackColor = System.Drawing.Color.Lime;
            this.customColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customColor.Location = new System.Drawing.Point(739, 16);
            this.customColor.Name = "customColor";
            this.customColor.Size = new System.Drawing.Size(125, 125);
            this.customColor.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(579, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Transition";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(460, 32);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 28;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(390, 32);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(320, 32);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(250, 32);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(180, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(110, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkCustom
            // 
            this.checkCustom.AutoCheck = false;
            this.checkCustom.AutoSize = true;
            this.checkCustom.Location = new System.Drawing.Point(30, 70);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(15, 14);
            this.checkCustom.TabIndex = 22;
            this.checkCustom.UseVisualStyleBackColor = true;
            this.checkCustom.Click += new System.EventHandler(this.CheckClick);
            // 
            // patternLabel1
            // 
            this.patternLabel1.AutoSize = true;
            this.patternLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel1.Location = new System.Drawing.Point(15, 32);
            this.patternLabel1.Name = "patternLabel1";
            this.patternLabel1.Size = new System.Drawing.Size(57, 16);
            this.patternLabel1.TabIndex = 20;
            this.patternLabel1.Text = "Pattern";
            // 
            // scrollPanel
            // 
            this.scrollPanel.BackColor = System.Drawing.Color.White;
            this.scrollPanel.Controls.Add(this.fadeScrollBri);
            this.scrollPanel.Controls.Add(this.fadeBrightLabel);
            this.scrollPanel.Controls.Add(this.fadeSpeedLabel);
            this.scrollPanel.Controls.Add(this.fadeColor);
            this.scrollPanel.Controls.Add(this.checkFade);
            this.scrollPanel.Controls.Add(this.fadeLabel);
            this.scrollPanel.Controls.Add(this.fadeScrollSpeed);
            this.scrollPanel.Location = new System.Drawing.Point(383, 36);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(509, 155);
            this.scrollPanel.TabIndex = 27;
            // 
            // fadeScrollBri
            // 
            this.fadeScrollBri.Location = new System.Drawing.Point(150, 70);
            this.fadeScrollBri.Maximum = 100;
            this.fadeScrollBri.Name = "fadeScrollBri";
            this.fadeScrollBri.Size = new System.Drawing.Size(213, 45);
            this.fadeScrollBri.TabIndex = 27;
            this.fadeScrollBri.TickFrequency = 0;
            this.fadeScrollBri.Value = 100;
            // 
            // fadeBrightLabel
            // 
            this.fadeBrightLabel.AutoSize = true;
            this.fadeBrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.fadeBrightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fadeBrightLabel.Location = new System.Drawing.Point(63, 70);
            this.fadeBrightLabel.Name = "fadeBrightLabel";
            this.fadeBrightLabel.Size = new System.Drawing.Size(81, 16);
            this.fadeBrightLabel.TabIndex = 28;
            this.fadeBrightLabel.Text = "Brightness";
            // 
            // fadeSpeedLabel
            // 
            this.fadeSpeedLabel.AutoSize = true;
            this.fadeSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fadeSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fadeSpeedLabel.Location = new System.Drawing.Point(63, 35);
            this.fadeSpeedLabel.Name = "fadeSpeedLabel";
            this.fadeSpeedLabel.Size = new System.Drawing.Size(54, 16);
            this.fadeSpeedLabel.TabIndex = 27;
            this.fadeSpeedLabel.Text = "Speed";
            // 
            // fadeColor
            // 
            this.fadeColor.BackColor = System.Drawing.Color.White;
            this.fadeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fadeColor.Location = new System.Drawing.Point(369, 16);
            this.fadeColor.Name = "fadeColor";
            this.fadeColor.Size = new System.Drawing.Size(125, 125);
            this.fadeColor.TabIndex = 23;
            // 
            // checkFade
            // 
            this.checkFade.AutoCheck = false;
            this.checkFade.AutoSize = true;
            this.checkFade.Location = new System.Drawing.Point(30, 70);
            this.checkFade.Name = "checkFade";
            this.checkFade.Size = new System.Drawing.Size(15, 14);
            this.checkFade.TabIndex = 22;
            this.checkFade.UseVisualStyleBackColor = true;
            this.checkFade.Click += new System.EventHandler(this.CheckClick);
            // 
            // fadeLabel
            // 
            this.fadeLabel.AutoSize = true;
            this.fadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fadeLabel.Location = new System.Drawing.Point(16, 16);
            this.fadeLabel.Name = "fadeLabel";
            this.fadeLabel.Size = new System.Drawing.Size(44, 16);
            this.fadeLabel.TabIndex = 20;
            this.fadeLabel.Text = "Fade";
            // 
            // fadeScrollSpeed
            // 
            this.fadeScrollSpeed.Location = new System.Drawing.Point(117, 35);
            this.fadeScrollSpeed.Maximum = 100;
            this.fadeScrollSpeed.Minimum = 5;
            this.fadeScrollSpeed.Name = "fadeScrollSpeed";
            this.fadeScrollSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fadeScrollSpeed.Size = new System.Drawing.Size(246, 45);
            this.fadeScrollSpeed.TabIndex = 3;
            this.fadeScrollSpeed.TickFrequency = 10;
            this.fadeScrollSpeed.Value = 100;
            this.fadeScrollSpeed.Scroll += new System.EventHandler(this.SliderScrollSpeed_Scroll);
            // 
            // scrollTimer
            // 
            this.scrollTimer.Enabled = true;
            this.scrollTimer.Tick += new System.EventHandler(this.ScrollTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(907, 530);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fixedPanel);
            this.Controls.Add(this.audioPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 569);
            this.MinimumSize = new System.Drawing.Size(923, 569);
            this.Name = "MainWindow";
            this.Text = "LED Controller";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAudioBri)).EndInit();
            this.audioPanel.ResumeLayout(false);
            this.audioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOffset)).EndInit();
            this.fixedPanel.ResumeLayout(false);
            this.fixedPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPattern0)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fadeScrollBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fadeScrollSpeed)).EndInit();
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
        private System.Windows.Forms.ProgressBar barL;
        private System.Windows.Forms.ProgressBar barR;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.TrackBar sliderMult;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label audioMultipLabel;
        private System.Windows.Forms.TrackBar sliderAmp;
        private System.Windows.Forms.TrackBar sliderAudioBri;
        private System.Windows.Forms.Label audioBrightLabel;
        private System.Windows.Forms.Label fixedLabel;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.CheckBox checkFixed;
        private System.Windows.Forms.CheckBox checkAudio;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.Panel audioPanel;
        private System.Windows.Forms.Panel fixedPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label patternLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel fixedColor;
        private System.Windows.Forms.Panel audioColor;
        private System.Windows.Forms.Panel customColor;
        private System.Windows.Forms.Label patternLabel0;
        private System.Windows.Forms.PictureBox customPattern6;
        private System.Windows.Forms.PictureBox customPattern5;
        private System.Windows.Forms.PictureBox customPattern4;
        private System.Windows.Forms.PictureBox customPattern3;
        private System.Windows.Forms.PictureBox customPattern2;
        private System.Windows.Forms.PictureBox customPattern1;
        private System.Windows.Forms.PictureBox customPattern0;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label audioOffsetLabel;
        private System.Windows.Forms.TrackBar sliderOffset;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Label fadeSpeedLabel;
        private System.Windows.Forms.Panel fadeColor;
        private System.Windows.Forms.CheckBox checkFade;
        private System.Windows.Forms.Label fadeLabel;
        private System.Windows.Forms.TrackBar fadeScrollSpeed;
        private System.Windows.Forms.TrackBar fadeScrollBri;
        private System.Windows.Forms.Label fadeBrightLabel;
        private System.Windows.Forms.Timer scrollTimer;
        private System.Windows.Forms.Timer serialTimer;
    }
}

