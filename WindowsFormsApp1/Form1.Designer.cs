using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.payload = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxReceiver = new System.Windows.Forms.GroupBox();
            this.lblRxStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbComPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBoxTransmitter = new System.Windows.Forms.GroupBox();
            this.btnHyiConnect = new System.Windows.Forms.Button();
            this.cmbHyiPorts = new System.Windows.Forms.ComboBox();
            this.btnAutoSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblHyiStatus = new System.Windows.Forms.Label();
            this.GyroXCaption = new System.Windows.Forms.Label();
            this.GyroYCaption = new System.Windows.Forms.Label();
            this.GyroZCaption = new System.Windows.Forms.Label();
            this.lblAccelXCaption = new System.Windows.Forms.Label();
            this.lblAccelYCaption = new System.Windows.Forms.Label();
            this.lblAccelZCaption = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.GroupBox();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblYawCaption = new System.Windows.Forms.Label();
            this.sendTeamId = new System.Windows.Forms.Button();
            this.takımIdtestBox = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblAltCaption = new System.Windows.Forms.Label();
            this.GyroZ = new System.Windows.Forms.Label();
            this.GyroY = new System.Windows.Forms.Label();
            this.GyroX = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblBaroAlt = new System.Windows.Forms.Label();
            this.lblAccelZ = new System.Windows.Forms.Label();
            this.lblAccelY = new System.Windows.Forms.Label();
            this.lblAccelX = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGPSAlt = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblPacketCounter = new System.Windows.Forms.Label();
            this.lblSpeedCaption = new System.Windows.Forms.Label();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblRollCaption = new System.Windows.Forms.Label();
            this.lblPitchCaption = new System.Windows.Forms.Label();
            this.lblLonCaption = new System.Windows.Forms.Label();
            this.lblLatCaption = new System.Windows.Forms.Label();
            this.lblGPSAltCaption = new System.Windows.Forms.Label();
            this.lblBaroAltCaption = new System.Windows.Forms.Label();
            this.lblPacketCounterCaption = new System.Windows.Forms.Label();
            this.rtbDataTerminal = new System.Windows.Forms.RichTextBox();
            this.groundStation = new System.Windows.Forms.Button();
            this.label_parachute1Active = new System.Windows.Forms.Label();
            this.firstParachutePicture = new System.Windows.Forms.PictureBox();
            this.firstParachuteLabel = new System.Windows.Forms.Label();
            this.secondParachutePicture = new System.Windows.Forms.PictureBox();
            this.secondParachuteLabel = new System.Windows.Forms.Label();
            this.label_parachute1Pasif = new System.Windows.Forms.Label();
            this.ApogeeDef = new System.Windows.Forms.Button();
            this.AnaParasutDef = new System.Windows.Forms.Button();
            this.label_parachute2Active = new System.Windows.Forms.Label();
            this.label_parachute2Pasif = new System.Windows.Forms.Label();
            this.qoute = new System.Windows.Forms.TextBox();
            this.testStation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBoxReceiver.SuspendLayout();
            this.groupBoxTransmitter.SuspendLayout();
            this.DataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.WindowText;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(77, 42);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(208, 182);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // payload
            // 
            this.payload.ForeColor = System.Drawing.Color.OrangeRed;
            this.payload.Location = new System.Drawing.Point(66, 494);
            this.payload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(208, 51);
            this.payload.TabIndex = 5;
            this.payload.Text = "Payload";
            this.payload.UseVisualStyleBackColor = true;
            this.payload.Click += new System.EventHandler(this.button3_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(912, 12);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(513, 239);
            this.gMap.TabIndex = 19;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // groupBoxReceiver
            // 
            this.groupBoxReceiver.AccessibleDescription = "groupBoxReceiver";
            this.groupBoxReceiver.AccessibleName = "groupBoxReceiver";
            this.groupBoxReceiver.BackColor = System.Drawing.Color.Black;
            this.groupBoxReceiver.Controls.Add(this.lblRxStatus);
            this.groupBoxReceiver.Controls.Add(this.textBox1);
            this.groupBoxReceiver.Controls.Add(this.cmbComPorts);
            this.groupBoxReceiver.Controls.Add(this.btnConnect);
            this.groupBoxReceiver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReceiver.ForeColor = System.Drawing.Color.White;
            this.groupBoxReceiver.Location = new System.Drawing.Point(359, 311);
            this.groupBoxReceiver.Name = "groupBoxReceiver";
            this.groupBoxReceiver.Size = new System.Drawing.Size(243, 234);
            this.groupBoxReceiver.TabIndex = 20;
            this.groupBoxReceiver.TabStop = false;
            this.groupBoxReceiver.Text = "Receiver";
            this.groupBoxReceiver.Enter += new System.EventHandler(this.groupBoxReceiver_Enter);
            // 
            // lblRxStatus
            // 
            this.lblRxStatus.AutoSize = true;
            this.lblRxStatus.ForeColor = System.Drawing.Color.Red;
            this.lblRxStatus.Location = new System.Drawing.Point(70, 183);
            this.lblRxStatus.Name = "lblRxStatus";
            this.lblRxStatus.Size = new System.Drawing.Size(106, 19);
            this.lblRxStatus.TabIndex = 9;
            this.lblRxStatus.Text = "Bağlantı Yok";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Aktif Olan Tüm Portlar : ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // cmbComPorts
            // 
            this.cmbComPorts.FormattingEnabled = true;
            this.cmbComPorts.Location = new System.Drawing.Point(58, 87);
            this.cmbComPorts.Name = "cmbComPorts";
            this.cmbComPorts.Size = new System.Drawing.Size(132, 27);
            this.cmbComPorts.TabIndex = 7;
            this.cmbComPorts.SelectedIndexChanged += new System.EventHandler(this.cmbComPorts_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(73, 128);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 41);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBoxTransmitter
            // 
            this.groupBoxTransmitter.AccessibleDescription = "groupBoxTransmitter";
            this.groupBoxTransmitter.AccessibleName = "groupBoxTransmitter";
            this.groupBoxTransmitter.Controls.Add(this.btnHyiConnect);
            this.groupBoxTransmitter.Controls.Add(this.cmbHyiPorts);
            this.groupBoxTransmitter.Controls.Add(this.btnAutoSend);
            this.groupBoxTransmitter.Controls.Add(this.btnSend);
            this.groupBoxTransmitter.Controls.Add(this.lblHyiStatus);
            this.groupBoxTransmitter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransmitter.ForeColor = System.Drawing.Color.White;
            this.groupBoxTransmitter.Location = new System.Drawing.Point(624, 311);
            this.groupBoxTransmitter.Name = "groupBoxTransmitter";
            this.groupBoxTransmitter.Size = new System.Drawing.Size(262, 234);
            this.groupBoxTransmitter.TabIndex = 21;
            this.groupBoxTransmitter.TabStop = false;
            this.groupBoxTransmitter.Text = "Transmitter";
            // 
            // btnHyiConnect
            // 
            this.btnHyiConnect.ForeColor = System.Drawing.Color.Black;
            this.btnHyiConnect.Location = new System.Drawing.Point(156, 46);
            this.btnHyiConnect.Name = "btnHyiConnect";
            this.btnHyiConnect.Size = new System.Drawing.Size(96, 35);
            this.btnHyiConnect.TabIndex = 5;
            this.btnHyiConnect.Text = "Bağlan";
            this.btnHyiConnect.UseVisualStyleBackColor = true;
            // 
            // cmbHyiPorts
            // 
            this.cmbHyiPorts.FormattingEnabled = true;
            this.cmbHyiPorts.Location = new System.Drawing.Point(17, 50);
            this.cmbHyiPorts.Name = "cmbHyiPorts";
            this.cmbHyiPorts.Size = new System.Drawing.Size(121, 27);
            this.cmbHyiPorts.TabIndex = 4;
            this.cmbHyiPorts.SelectedIndexChanged += new System.EventHandler(this.cmbHyiPorts_SelectedIndexChanged);
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.ForeColor = System.Drawing.Color.Black;
            this.btnAutoSend.Location = new System.Drawing.Point(115, 129);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Size = new System.Drawing.Size(136, 54);
            this.btnAutoSend.TabIndex = 3;
            this.btnAutoSend.Text = "Otomatik Veri Gönder";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            this.btnAutoSend.Click += new System.EventHandler(this.btnAutoSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(13, 129);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 52);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Veri Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblHyiStatus
            // 
            this.lblHyiStatus.AutoSize = true;
            this.lblHyiStatus.ForeColor = System.Drawing.Color.Red;
            this.lblHyiStatus.Location = new System.Drawing.Point(83, 91);
            this.lblHyiStatus.Name = "lblHyiStatus";
            this.lblHyiStatus.Size = new System.Drawing.Size(106, 19);
            this.lblHyiStatus.TabIndex = 1;
            this.lblHyiStatus.Text = "Bağlantı Yok";
            // 
            // GyroXCaption
            // 
            this.GyroXCaption.AutoSize = true;
            this.GyroXCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GyroXCaption.ForeColor = System.Drawing.Color.Transparent;
            this.GyroXCaption.Location = new System.Drawing.Point(373, 31);
            this.GyroXCaption.Name = "GyroXCaption";
            this.GyroXCaption.Size = new System.Drawing.Size(75, 19);
            this.GyroXCaption.TabIndex = 22;
            this.GyroXCaption.Text = "Gyro X :";
            this.GyroXCaption.Click += new System.EventHandler(this.GyroX_Click_1);
            // 
            // GyroYCaption
            // 
            this.GyroYCaption.AutoSize = true;
            this.GyroYCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GyroYCaption.ForeColor = System.Drawing.Color.Transparent;
            this.GyroYCaption.Location = new System.Drawing.Point(375, 69);
            this.GyroYCaption.Name = "GyroYCaption";
            this.GyroYCaption.Size = new System.Drawing.Size(74, 19);
            this.GyroYCaption.TabIndex = 23;
            this.GyroYCaption.Text = "Gyro Y :";
            this.GyroYCaption.Click += new System.EventHandler(this.GyroY_Click);
            // 
            // GyroZCaption
            // 
            this.GyroZCaption.AutoSize = true;
            this.GyroZCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GyroZCaption.ForeColor = System.Drawing.Color.Transparent;
            this.GyroZCaption.Location = new System.Drawing.Point(375, 104);
            this.GyroZCaption.Name = "GyroZCaption";
            this.GyroZCaption.Size = new System.Drawing.Size(73, 19);
            this.GyroZCaption.TabIndex = 24;
            this.GyroZCaption.Text = "Gyro Z :";
            this.GyroZCaption.Click += new System.EventHandler(this.GyroZ_Click);
            // 
            // lblAccelXCaption
            // 
            this.lblAccelXCaption.AutoSize = true;
            this.lblAccelXCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccelXCaption.ForeColor = System.Drawing.Color.Transparent;
            this.lblAccelXCaption.Location = new System.Drawing.Point(214, 31);
            this.lblAccelXCaption.Name = "lblAccelXCaption";
            this.lblAccelXCaption.Size = new System.Drawing.Size(65, 19);
            this.lblAccelXCaption.TabIndex = 25;
            this.lblAccelXCaption.Text = "Acc X :";
            this.lblAccelXCaption.Click += new System.EventHandler(this.lblAccelX_Click);
            // 
            // lblAccelYCaption
            // 
            this.lblAccelYCaption.AutoSize = true;
            this.lblAccelYCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccelYCaption.ForeColor = System.Drawing.Color.Transparent;
            this.lblAccelYCaption.Location = new System.Drawing.Point(213, 69);
            this.lblAccelYCaption.Name = "lblAccelYCaption";
            this.lblAccelYCaption.Size = new System.Drawing.Size(64, 19);
            this.lblAccelYCaption.TabIndex = 26;
            this.lblAccelYCaption.Text = "Acc Y :";
            this.lblAccelYCaption.Click += new System.EventHandler(this.lblAccelY_Click);
            // 
            // lblAccelZCaption
            // 
            this.lblAccelZCaption.AutoSize = true;
            this.lblAccelZCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccelZCaption.ForeColor = System.Drawing.Color.Transparent;
            this.lblAccelZCaption.Location = new System.Drawing.Point(215, 104);
            this.lblAccelZCaption.Name = "lblAccelZCaption";
            this.lblAccelZCaption.Size = new System.Drawing.Size(63, 19);
            this.lblAccelZCaption.TabIndex = 27;
            this.lblAccelZCaption.Text = "Acc Z :";
            this.lblAccelZCaption.Click += new System.EventHandler(this.lblAccelZ_Click);
            // 
            // DataBox
            // 
            this.DataBox.Controls.Add(this.lblYaw);
            this.DataBox.Controls.Add(this.lblYawCaption);
            this.DataBox.Controls.Add(this.sendTeamId);
            this.DataBox.Controls.Add(this.takımIdtestBox);
            this.DataBox.Controls.Add(this.lblTeamID);
            this.DataBox.Controls.Add(this.lblAlt);
            this.DataBox.Controls.Add(this.lblAltCaption);
            this.DataBox.Controls.Add(this.GyroZ);
            this.DataBox.Controls.Add(this.GyroY);
            this.DataBox.Controls.Add(this.GyroX);
            this.DataBox.Controls.Add(this.lblLon);
            this.DataBox.Controls.Add(this.lblLat);
            this.DataBox.Controls.Add(this.lblSpeed);
            this.DataBox.Controls.Add(this.lblBaroAlt);
            this.DataBox.Controls.Add(this.lblAccelZ);
            this.DataBox.Controls.Add(this.lblAccelY);
            this.DataBox.Controls.Add(this.lblAccelX);
            this.DataBox.Controls.Add(this.lblStatus);
            this.DataBox.Controls.Add(this.lblGPSAlt);
            this.DataBox.Controls.Add(this.lblPitch);
            this.DataBox.Controls.Add(this.lblRoll);
            this.DataBox.Controls.Add(this.lblPacketCounter);
            this.DataBox.Controls.Add(this.lblSpeedCaption);
            this.DataBox.Controls.Add(this.lblStatusCaption);
            this.DataBox.Controls.Add(this.lblRollCaption);
            this.DataBox.Controls.Add(this.lblPitchCaption);
            this.DataBox.Controls.Add(this.lblLonCaption);
            this.DataBox.Controls.Add(this.lblAccelZCaption);
            this.DataBox.Controls.Add(this.lblLatCaption);
            this.DataBox.Controls.Add(this.lblAccelYCaption);
            this.DataBox.Controls.Add(this.GyroZCaption);
            this.DataBox.Controls.Add(this.lblGPSAltCaption);
            this.DataBox.Controls.Add(this.GyroYCaption);
            this.DataBox.Controls.Add(this.lblAccelXCaption);
            this.DataBox.Controls.Add(this.GyroXCaption);
            this.DataBox.Controls.Add(this.lblBaroAltCaption);
            this.DataBox.Controls.Add(this.lblPacketCounterCaption);
            this.DataBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataBox.Location = new System.Drawing.Point(912, 257);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(513, 337);
            this.DataBox.TabIndex = 34;
            this.DataBox.TabStop = false;
            this.DataBox.Text = "DataBox";
            this.DataBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Location = new System.Drawing.Point(157, 31);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(18, 19);
            this.lblYaw.TabIndex = 54;
            this.lblYaw.Text = "0";
            // 
            // lblYawCaption
            // 
            this.lblYawCaption.AutoSize = true;
            this.lblYawCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblYawCaption.Location = new System.Drawing.Point(16, 31);
            this.lblYawCaption.Name = "lblYawCaption";
            this.lblYawCaption.Size = new System.Drawing.Size(51, 19);
            this.lblYawCaption.TabIndex = 53;
            this.lblYawCaption.Text = "Yaw :";
            // 
            // sendTeamId
            // 
            this.sendTeamId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendTeamId.Location = new System.Drawing.Point(21, 291);
            this.sendTeamId.Name = "sendTeamId";
            this.sendTeamId.Size = new System.Drawing.Size(116, 31);
            this.sendTeamId.TabIndex = 52;
            this.sendTeamId.Text = "sendTeamId";
            this.sendTeamId.UseVisualStyleBackColor = true;
            this.sendTeamId.Click += new System.EventHandler(this.sendTeamId_Click);
            // 
            // takımIdtestBox
            // 
            this.takımIdtestBox.Location = new System.Drawing.Point(123, 252);
            this.takımIdtestBox.Name = "takımIdtestBox";
            this.takımIdtestBox.Size = new System.Drawing.Size(168, 26);
            this.takımIdtestBox.TabIndex = 51;
            this.takımIdtestBox.TextChanged += new System.EventHandler(this.takımIdtestBox_TextChanged_1);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTeamID.Location = new System.Drawing.Point(17, 253);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(77, 19);
            this.lblTeamID.TabIndex = 50;
            this.lblTeamID.Text = "Team ID:";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(158, 214);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(18, 19);
            this.lblAlt.TabIndex = 48;
            this.lblAlt.Text = "0";
            // 
            // lblAltCaption
            // 
            this.lblAltCaption.AutoSize = true;
            this.lblAltCaption.Location = new System.Drawing.Point(17, 214);
            this.lblAltCaption.Name = "lblAltCaption";
            this.lblAltCaption.Size = new System.Drawing.Size(80, 19);
            this.lblAltCaption.TabIndex = 47;
            this.lblAltCaption.Text = "Altitude :";
            // 
            // GyroZ
            // 
            this.GyroZ.AutoSize = true;
            this.GyroZ.Location = new System.Drawing.Point(467, 106);
            this.GyroZ.Name = "GyroZ";
            this.GyroZ.Size = new System.Drawing.Size(18, 19);
            this.GyroZ.TabIndex = 46;
            this.GyroZ.Text = "0";
            // 
            // GyroY
            // 
            this.GyroY.AutoSize = true;
            this.GyroY.Location = new System.Drawing.Point(467, 69);
            this.GyroY.Name = "GyroY";
            this.GyroY.Size = new System.Drawing.Size(18, 19);
            this.GyroY.TabIndex = 45;
            this.GyroY.Text = "0";
            // 
            // GyroX
            // 
            this.GyroX.AutoSize = true;
            this.GyroX.Location = new System.Drawing.Point(467, 31);
            this.GyroX.Name = "GyroX";
            this.GyroX.Size = new System.Drawing.Size(18, 19);
            this.GyroX.TabIndex = 44;
            this.GyroX.Text = "0";
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Location = new System.Drawing.Point(158, 173);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(18, 19);
            this.lblLon.TabIndex = 42;
            this.lblLon.Text = "0";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(158, 141);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(18, 19);
            this.lblLat.TabIndex = 41;
            this.lblLat.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(313, 181);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(18, 19);
            this.lblSpeed.TabIndex = 40;
            this.lblSpeed.Text = "0";
            // 
            // lblBaroAlt
            // 
            this.lblBaroAlt.AutoSize = true;
            this.lblBaroAlt.Location = new System.Drawing.Point(313, 145);
            this.lblBaroAlt.Name = "lblBaroAlt";
            this.lblBaroAlt.Size = new System.Drawing.Size(18, 19);
            this.lblBaroAlt.TabIndex = 39;
            this.lblBaroAlt.Text = "0";
            // 
            // lblAccelZ
            // 
            this.lblAccelZ.AutoSize = true;
            this.lblAccelZ.Location = new System.Drawing.Point(311, 104);
            this.lblAccelZ.Name = "lblAccelZ";
            this.lblAccelZ.Size = new System.Drawing.Size(18, 19);
            this.lblAccelZ.TabIndex = 38;
            this.lblAccelZ.Text = "0";
            // 
            // lblAccelY
            // 
            this.lblAccelY.AutoSize = true;
            this.lblAccelY.Location = new System.Drawing.Point(312, 69);
            this.lblAccelY.Name = "lblAccelY";
            this.lblAccelY.Size = new System.Drawing.Size(18, 19);
            this.lblAccelY.TabIndex = 37;
            this.lblAccelY.Text = "0";
            // 
            // lblAccelX
            // 
            this.lblAccelX.AutoSize = true;
            this.lblAccelX.Location = new System.Drawing.Point(313, 31);
            this.lblAccelX.Name = "lblAccelX";
            this.lblAccelX.Size = new System.Drawing.Size(18, 19);
            this.lblAccelX.TabIndex = 36;
            this.lblAccelX.Text = "0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(467, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 19);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "0";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblGPSAlt
            // 
            this.lblGPSAlt.AutoSize = true;
            this.lblGPSAlt.Location = new System.Drawing.Point(467, 141);
            this.lblGPSAlt.Name = "lblGPSAlt";
            this.lblGPSAlt.Size = new System.Drawing.Size(18, 19);
            this.lblGPSAlt.TabIndex = 34;
            this.lblGPSAlt.Text = "0";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(157, 106);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(18, 19);
            this.lblPitch.TabIndex = 33;
            this.lblPitch.Text = "0";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(157, 69);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(18, 19);
            this.lblRoll.TabIndex = 32;
            this.lblRoll.Text = "0";
            // 
            // lblPacketCounter
            // 
            this.lblPacketCounter.AutoSize = true;
            this.lblPacketCounter.Location = new System.Drawing.Point(373, 214);
            this.lblPacketCounter.Name = "lblPacketCounter";
            this.lblPacketCounter.Size = new System.Drawing.Size(18, 19);
            this.lblPacketCounter.TabIndex = 31;
            this.lblPacketCounter.Text = "0";
            // 
            // lblSpeedCaption
            // 
            this.lblSpeedCaption.AutoSize = true;
            this.lblSpeedCaption.Location = new System.Drawing.Point(213, 181);
            this.lblSpeedCaption.Name = "lblSpeedCaption";
            this.lblSpeedCaption.Size = new System.Drawing.Size(69, 19);
            this.lblSpeedCaption.TabIndex = 30;
            this.lblSpeedCaption.Text = "Speed :";
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Location = new System.Drawing.Point(375, 179);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(71, 19);
            this.lblStatusCaption.TabIndex = 29;
            this.lblStatusCaption.Text = "Status :";
            // 
            // lblRollCaption
            // 
            this.lblRollCaption.AutoSize = true;
            this.lblRollCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRollCaption.Location = new System.Drawing.Point(17, 69);
            this.lblRollCaption.Name = "lblRollCaption";
            this.lblRollCaption.Size = new System.Drawing.Size(50, 19);
            this.lblRollCaption.TabIndex = 8;
            this.lblRollCaption.Text = "Roll :";
            this.lblRollCaption.Click += new System.EventHandler(this.lblRoll_Click);
            // 
            // lblPitchCaption
            // 
            this.lblPitchCaption.AutoSize = true;
            this.lblPitchCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPitchCaption.Location = new System.Drawing.Point(16, 104);
            this.lblPitchCaption.Name = "lblPitchCaption";
            this.lblPitchCaption.Size = new System.Drawing.Size(60, 19);
            this.lblPitchCaption.TabIndex = 7;
            this.lblPitchCaption.Text = "Pitch :";
            this.lblPitchCaption.Click += new System.EventHandler(this.lblPitch_Click);
            // 
            // lblLonCaption
            // 
            this.lblLonCaption.AutoSize = true;
            this.lblLonCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLonCaption.Location = new System.Drawing.Point(17, 173);
            this.lblLonCaption.Name = "lblLonCaption";
            this.lblLonCaption.Size = new System.Drawing.Size(99, 19);
            this.lblLonCaption.TabIndex = 5;
            this.lblLonCaption.Text = "Longitude :";
            this.lblLonCaption.Click += new System.EventHandler(this.lblLonCaption_Click);
            // 
            // lblLatCaption
            // 
            this.lblLatCaption.AutoSize = true;
            this.lblLatCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLatCaption.Location = new System.Drawing.Point(17, 141);
            this.lblLatCaption.Name = "lblLatCaption";
            this.lblLatCaption.Size = new System.Drawing.Size(84, 19);
            this.lblLatCaption.TabIndex = 4;
            this.lblLatCaption.Text = "Latitude :";
            this.lblLatCaption.Click += new System.EventHandler(this.lblLat_Click);
            // 
            // lblGPSAltCaption
            // 
            this.lblGPSAltCaption.AutoSize = true;
            this.lblGPSAltCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblGPSAltCaption.Location = new System.Drawing.Point(375, 141);
            this.lblGPSAltCaption.Name = "lblGPSAltCaption";
            this.lblGPSAltCaption.Size = new System.Drawing.Size(80, 19);
            this.lblGPSAltCaption.TabIndex = 3;
            this.lblGPSAltCaption.Text = "GPS Alt :";
            this.lblGPSAltCaption.Click += new System.EventHandler(this.lblGPSAlt_Click);
            // 
            // lblBaroAltCaption
            // 
            this.lblBaroAltCaption.AutoSize = true;
            this.lblBaroAltCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblBaroAltCaption.Location = new System.Drawing.Point(213, 145);
            this.lblBaroAltCaption.Name = "lblBaroAltCaption";
            this.lblBaroAltCaption.Size = new System.Drawing.Size(72, 19);
            this.lblBaroAltCaption.TabIndex = 2;
            this.lblBaroAltCaption.Text = "Baro Alt";
            this.lblBaroAltCaption.Click += new System.EventHandler(this.lblBaroAlt_Click);
            // 
            // lblPacketCounterCaption
            // 
            this.lblPacketCounterCaption.AutoSize = true;
            this.lblPacketCounterCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPacketCounterCaption.Location = new System.Drawing.Point(214, 214);
            this.lblPacketCounterCaption.Name = "lblPacketCounterCaption";
            this.lblPacketCounterCaption.Size = new System.Drawing.Size(142, 19);
            this.lblPacketCounterCaption.TabIndex = 1;
            this.lblPacketCounterCaption.Text = "Packet Counter :";
            this.lblPacketCounterCaption.Click += new System.EventHandler(this.lblPacketCounter_Click);
            // 
            // rtbDataTerminal
            // 
            this.rtbDataTerminal.Location = new System.Drawing.Point(359, 600);
            this.rtbDataTerminal.Name = "rtbDataTerminal";
            this.rtbDataTerminal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDataTerminal.Size = new System.Drawing.Size(1066, 210);
            this.rtbDataTerminal.TabIndex = 35;
            this.rtbDataTerminal.Text = "";
            this.rtbDataTerminal.TextChanged += new System.EventHandler(this.rtbDataTerminal_TextChanged);
            // 
            // groundStation
            // 
            this.groundStation.ForeColor = System.Drawing.Color.OrangeRed;
            this.groundStation.Location = new System.Drawing.Point(66, 348);
            this.groundStation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groundStation.Name = "groundStation";
            this.groundStation.Size = new System.Drawing.Size(208, 51);
            this.groundStation.TabIndex = 3;
            this.groundStation.Text = "Ground Station ";
            this.groundStation.UseVisualStyleBackColor = true;
            this.groundStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_parachute1Active
            // 
            this.label_parachute1Active.AccessibleDescription = "label_parachute1Active";
            this.label_parachute1Active.AccessibleName = "label_parachute1Active";
            this.label_parachute1Active.AutoSize = true;
            this.label_parachute1Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute1Active.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_parachute1Active.Location = new System.Drawing.Point(450, 197);
            this.label_parachute1Active.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parachute1Active.Name = "label_parachute1Active";
            this.label_parachute1Active.Size = new System.Drawing.Size(53, 18);
            this.label_parachute1Active.TabIndex = 11;
            this.label_parachute1Active.Text = "Active";
            this.label_parachute1Active.Click += new System.EventHandler(this.label_parachute1Active_Click);
            // 
            // firstParachutePicture
            // 
            this.firstParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("firstParachutePicture.Image")));
            this.firstParachutePicture.Location = new System.Drawing.Point(409, 57);
            this.firstParachutePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstParachutePicture.Name = "firstParachutePicture";
            this.firstParachutePicture.Size = new System.Drawing.Size(133, 134);
            this.firstParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstParachutePicture.TabIndex = 6;
            this.firstParachutePicture.TabStop = false;
            this.firstParachutePicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // firstParachuteLabel
            // 
            this.firstParachuteLabel.AutoSize = true;
            this.firstParachuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstParachuteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstParachuteLabel.Location = new System.Drawing.Point(414, 29);
            this.firstParachuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstParachuteLabel.Name = "firstParachuteLabel";
            this.firstParachuteLabel.Size = new System.Drawing.Size(126, 20);
            this.firstParachuteLabel.TabIndex = 7;
            this.firstParachuteLabel.Text = "1st Parachute\r\n";
            this.firstParachuteLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondParachutePicture
            // 
            this.secondParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("secondParachutePicture.Image")));
            this.secondParachutePicture.Location = new System.Drawing.Point(681, 57);
            this.secondParachutePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.secondParachutePicture.Name = "secondParachutePicture";
            this.secondParachutePicture.Size = new System.Drawing.Size(133, 134);
            this.secondParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondParachutePicture.TabIndex = 8;
            this.secondParachutePicture.TabStop = false;
            this.secondParachutePicture.Click += new System.EventHandler(this.secondParachutePicture_Click);
            // 
            // secondParachuteLabel
            // 
            this.secondParachuteLabel.AutoSize = true;
            this.secondParachuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondParachuteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondParachuteLabel.Location = new System.Drawing.Point(684, 29);
            this.secondParachuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondParachuteLabel.Name = "secondParachuteLabel";
            this.secondParachuteLabel.Size = new System.Drawing.Size(130, 20);
            this.secondParachuteLabel.TabIndex = 9;
            this.secondParachuteLabel.Text = "2nd Parachute";
            // 
            // label_parachute1Pasif
            // 
            this.label_parachute1Pasif.AccessibleDescription = "label_parachute1Pasif";
            this.label_parachute1Pasif.AccessibleName = "label_parachute1Pasif";
            this.label_parachute1Pasif.AutoSize = true;
            this.label_parachute1Pasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute1Pasif.ForeColor = System.Drawing.Color.Crimson;
            this.label_parachute1Pasif.Location = new System.Drawing.Point(452, 197);
            this.label_parachute1Pasif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parachute1Pasif.Name = "label_parachute1Pasif";
            this.label_parachute1Pasif.Size = new System.Drawing.Size(46, 18);
            this.label_parachute1Pasif.TabIndex = 10;
            this.label_parachute1Pasif.Text = "Pasif";
            this.label_parachute1Pasif.Click += new System.EventHandler(this.label_parachute1Pasif_Click);
            // 
            // ApogeeDef
            // 
            this.ApogeeDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApogeeDef.Location = new System.Drawing.Point(410, 230);
            this.ApogeeDef.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApogeeDef.Name = "ApogeeDef";
            this.ApogeeDef.Size = new System.Drawing.Size(129, 62);
            this.ApogeeDef.TabIndex = 12;
            this.ApogeeDef.Text = "apogee";
            this.ApogeeDef.UseVisualStyleBackColor = true;
            this.ApogeeDef.Click += new System.EventHandler(this.ApogeeDef_Click);
            // 
            // AnaParasutDef
            // 
            this.AnaParasutDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnaParasutDef.Location = new System.Drawing.Point(674, 231);
            this.AnaParasutDef.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AnaParasutDef.Name = "AnaParasutDef";
            this.AnaParasutDef.Size = new System.Drawing.Size(151, 62);
            this.AnaParasutDef.TabIndex = 13;
            this.AnaParasutDef.Text = "Ana parasut\r\nyere 400-600m kala\r\n";
            this.AnaParasutDef.UseVisualStyleBackColor = true;
            this.AnaParasutDef.Click += new System.EventHandler(this.AnaParasutDef_Click);
            // 
            // label_parachute2Active
            // 
            this.label_parachute2Active.AccessibleDescription = "label_parachute2Active";
            this.label_parachute2Active.AccessibleName = "label_parachute2Active";
            this.label_parachute2Active.AutoSize = true;
            this.label_parachute2Active.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_parachute2Active.Location = new System.Drawing.Point(722, 207);
            this.label_parachute2Active.Name = "label_parachute2Active";
            this.label_parachute2Active.Size = new System.Drawing.Size(53, 18);
            this.label_parachute2Active.TabIndex = 17;
            this.label_parachute2Active.Text = "Active";
            this.label_parachute2Active.Click += new System.EventHandler(this.label_parachute2Active_Click);
            // 
            // label_parachute2Pasif
            // 
            this.label_parachute2Pasif.AccessibleDescription = "label_parachute2Pasif";
            this.label_parachute2Pasif.AccessibleName = "label_parachute2Pasif";
            this.label_parachute2Pasif.AutoSize = true;
            this.label_parachute2Pasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute2Pasif.ForeColor = System.Drawing.Color.Crimson;
            this.label_parachute2Pasif.Location = new System.Drawing.Point(725, 206);
            this.label_parachute2Pasif.Name = "label_parachute2Pasif";
            this.label_parachute2Pasif.Size = new System.Drawing.Size(46, 18);
            this.label_parachute2Pasif.TabIndex = 15;
            this.label_parachute2Pasif.Text = "Pasif";
            this.label_parachute2Pasif.Click += new System.EventHandler(this.label_parachute2Pasif_Click);
            // 
            // qoute
            // 
            this.qoute.BackColor = System.Drawing.SystemColors.MenuText;
            this.qoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qoute.Font = new System.Drawing.Font("Gabriola", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qoute.ForeColor = System.Drawing.Color.White;
            this.qoute.Location = new System.Drawing.Point(26, 225);
            this.qoute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.qoute.Multiline = true;
            this.qoute.Name = "qoute";
            this.qoute.Size = new System.Drawing.Size(330, 99);
            this.qoute.TabIndex = 2;
            this.qoute.Text = "Through precision and courage, \r\nwe reach beyond the skies.";
            this.qoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qoute.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // testStation
            // 
            this.testStation.ForeColor = System.Drawing.Color.OrangeRed;
            this.testStation.Location = new System.Drawing.Point(66, 420);
            this.testStation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.testStation.Name = "testStation";
            this.testStation.Size = new System.Drawing.Size(208, 51);
            this.testStation.TabIndex = 4;
            this.testStation.Text = "Test Station";
            this.testStation.UseVisualStyleBackColor = true;
            this.testStation.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.rtbDataTerminal);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.groupBoxTransmitter);
            this.Controls.Add(this.groupBoxReceiver);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.label_parachute2Pasif);
            this.Controls.Add(this.label_parachute2Active);
            this.Controls.Add(this.AnaParasutDef);
            this.Controls.Add(this.ApogeeDef);
            this.Controls.Add(this.label_parachute1Pasif);
            this.Controls.Add(this.secondParachuteLabel);
            this.Controls.Add(this.secondParachutePicture);
            this.Controls.Add(this.firstParachuteLabel);
            this.Controls.Add(this.firstParachutePicture);
            this.Controls.Add(this.payload);
            this.Controls.Add(this.testStation);
            this.Controls.Add(this.groundStation);
            this.Controls.Add(this.qoute);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label_parachute1Active);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GroundStation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBoxReceiver.ResumeLayout(false);
            this.groupBoxReceiver.PerformLayout();
            this.groupBoxTransmitter.ResumeLayout(false);
            this.groupBoxTransmitter.PerformLayout();
            this.DataBox.ResumeLayout(false);
            this.DataBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button payload;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxReceiver;
        private System.Windows.Forms.GroupBox groupBoxTransmitter;
        private System.Windows.Forms.Label lblHyiStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAutoSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label GyroXCaption;
        private System.Windows.Forms.Label GyroYCaption;
        private System.Windows.Forms.Label GyroZCaption;
        private System.Windows.Forms.Label lblAccelXCaption;
        private System.Windows.Forms.Label lblAccelYCaption;
        private System.Windows.Forms.Label lblAccelZCaption;
        private System.Windows.Forms.GroupBox DataBox;
        private System.Windows.Forms.Label lblGPSAltCaption;
        private System.Windows.Forms.Label lblBaroAltCaption;
        private System.Windows.Forms.Label lblPacketCounterCaption;
        private System.Windows.Forms.Label lblRollCaption;
        private System.Windows.Forms.Label lblPitchCaption;
        private System.Windows.Forms.Label lblLonCaption;
        private System.Windows.Forms.Label lblLatCaption;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbComPorts;
        private System.Windows.Forms.RichTextBox rtbDataTerminal;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblSpeedCaption;
        private System.Windows.Forms.Label lblPacketCounter;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGPSAlt;
        private System.Windows.Forms.Label lblAccelX;
        private System.Windows.Forms.Label lblAccelY;
        private System.Windows.Forms.Label lblBaroAlt;
        private System.Windows.Forms.Label lblAccelZ;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label GyroX;
        private System.Windows.Forms.Label GyroZ;
        private System.Windows.Forms.Label GyroY;
        private System.Windows.Forms.Label lblRxStatus;
        private System.Windows.Forms.Button btnHyiConnect;
        private System.Windows.Forms.ComboBox cmbHyiPorts;
        private System.Windows.Forms.Label lblAltCaption;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Button sendTeamId;
        private System.Windows.Forms.TextBox takımIdtestBox;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.Label lblYawCaption;
        private System.Windows.Forms.Button groundStation;
        private System.Windows.Forms.Label label_parachute1Active;
        private System.Windows.Forms.PictureBox firstParachutePicture;
        private System.Windows.Forms.Label firstParachuteLabel;
        private System.Windows.Forms.PictureBox secondParachutePicture;
        private System.Windows.Forms.Label secondParachuteLabel;
        private System.Windows.Forms.Label label_parachute1Pasif;
        private System.Windows.Forms.Button ApogeeDef;
        private System.Windows.Forms.Button AnaParasutDef;
        private System.Windows.Forms.Label label_parachute2Active;
        private System.Windows.Forms.Label label_parachute2Pasif;
        private System.Windows.Forms.TextBox qoute;
        private System.Windows.Forms.Button testStation;
    }
}

