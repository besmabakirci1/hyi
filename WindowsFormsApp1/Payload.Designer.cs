namespace WindowsFormsApp1
{
    partial class Payload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payload));
            this.payloadGMap = new GMap.NET.WindowsForms.GMapControl();
            this.pressureCaption = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.moisture = new System.Windows.Forms.Label();
            this.temperatureCaption = new System.Windows.Forms.Label();
            this.moistureCaption = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.payloadGpsCaption = new System.Windows.Forms.Label();
            this.payloadParachutePicture = new System.Windows.Forms.PictureBox();
            this.payloadLblLonCaption = new System.Windows.Forms.Label();
            this.payloadLblLatCaption = new System.Windows.Forms.Label();
            this.payloadLblParachuteStatus = new System.Windows.Forms.Label();
            this.payloadLblLat = new System.Windows.Forms.Label();
            this.payloadLblLon = new System.Windows.Forms.Label();
            this.payloadLblGpsAltCaption = new System.Windows.Forms.Label();
            this.payloadLblGpsAlt = new System.Windows.Forms.Label();
            this.faydalıyukdurumuetiketi = new System.Windows.Forms.Label();
            this.payloadLblBaroAltCaption = new System.Windows.Forms.Label();
            this.payloadLblBaroAlt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payloadParachutePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // payloadGMap
            // 
            this.payloadGMap.Bearing = 0F;
            this.payloadGMap.CanDragMap = true;
            this.payloadGMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.payloadGMap.GrayScaleMode = false;
            this.payloadGMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.payloadGMap.LevelsKeepInMemmory = 5;
            this.payloadGMap.Location = new System.Drawing.Point(62, 12);
            this.payloadGMap.MarkersEnabled = true;
            this.payloadGMap.MaxZoom = 2;
            this.payloadGMap.MinZoom = 2;
            this.payloadGMap.MouseWheelZoomEnabled = true;
            this.payloadGMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.payloadGMap.Name = "payloadGMap";
            this.payloadGMap.NegativeMode = false;
            this.payloadGMap.PolygonsEnabled = true;
            this.payloadGMap.RetryLoadTile = 0;
            this.payloadGMap.RoutesEnabled = true;
            this.payloadGMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.payloadGMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.payloadGMap.ShowTileGridLines = false;
            this.payloadGMap.Size = new System.Drawing.Size(527, 351);
            this.payloadGMap.TabIndex = 20;
            this.payloadGMap.Zoom = 0D;
            this.payloadGMap.Load += new System.EventHandler(this.payloadGMap_Load);
            // 
            // pressureCaption
            // 
            this.pressureCaption.AutoSize = true;
            this.pressureCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.pressureCaption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pressureCaption.Location = new System.Drawing.Point(393, 458);
            this.pressureCaption.Name = "pressureCaption";
            this.pressureCaption.Size = new System.Drawing.Size(69, 21);
            this.pressureCaption.TabIndex = 21;
            this.pressureCaption.Text = "Basınç";
            this.pressureCaption.Click += new System.EventHandler(this.pressureCaption_Click);
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.pressure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pressure.Location = new System.Drawing.Point(584, 458);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(20, 21);
            this.pressure.TabIndex = 22;
            this.pressure.Text = "0";
            this.pressure.Click += new System.EventHandler(this.pressure_Click);
            // 
            // moisture
            // 
            this.moisture.AutoSize = true;
            this.moisture.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.moisture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moisture.Location = new System.Drawing.Point(584, 500);
            this.moisture.Name = "moisture";
            this.moisture.Size = new System.Drawing.Size(20, 21);
            this.moisture.TabIndex = 23;
            this.moisture.Text = "0";
            this.moisture.Click += new System.EventHandler(this.moisture_Click);
            // 
            // temperatureCaption
            // 
            this.temperatureCaption.AutoSize = true;
            this.temperatureCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.temperatureCaption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.temperatureCaption.Location = new System.Drawing.Point(394, 539);
            this.temperatureCaption.Name = "temperatureCaption";
            this.temperatureCaption.Size = new System.Drawing.Size(82, 21);
            this.temperatureCaption.TabIndex = 24;
            this.temperatureCaption.Text = "Sıcaklık ";
            this.temperatureCaption.Click += new System.EventHandler(this.temperatureCaption_Click);
            // 
            // moistureCaption
            // 
            this.moistureCaption.AutoSize = true;
            this.moistureCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.moistureCaption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moistureCaption.Location = new System.Drawing.Point(394, 500);
            this.moistureCaption.Name = "moistureCaption";
            this.moistureCaption.Size = new System.Drawing.Size(51, 21);
            this.moistureCaption.TabIndex = 25;
            this.moistureCaption.Text = "Nem";
            this.moistureCaption.Click += new System.EventHandler(this.moistureCaption_Click);
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.temperature.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.temperature.Location = new System.Drawing.Point(584, 539);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(20, 21);
            this.temperature.TabIndex = 26;
            this.temperature.Text = "0";
            this.temperature.Click += new System.EventHandler(this.temperature_Click);
            // 
            // payloadGpsCaption
            // 
            this.payloadGpsCaption.AutoSize = true;
            this.payloadGpsCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadGpsCaption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payloadGpsCaption.Location = new System.Drawing.Point(90, 412);
            this.payloadGpsCaption.Name = "payloadGpsCaption";
            this.payloadGpsCaption.Size = new System.Drawing.Size(181, 24);
            this.payloadGpsCaption.TabIndex = 27;
            this.payloadGpsCaption.Text = "Görev yükü GPS :";
            // 
            // payloadParachutePicture
            // 
            this.payloadParachutePicture.BackColor = System.Drawing.Color.Black;
            this.payloadParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("payloadParachutePicture.Image")));
            this.payloadParachutePicture.Location = new System.Drawing.Point(673, 77);
            this.payloadParachutePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payloadParachutePicture.Name = "payloadParachutePicture";
            this.payloadParachutePicture.Size = new System.Drawing.Size(162, 165);
            this.payloadParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payloadParachutePicture.TabIndex = 29;
            this.payloadParachutePicture.TabStop = false;
            this.payloadParachutePicture.Click += new System.EventHandler(this.payloadParachutePicture_Click);
            // 
            // payloadLblLonCaption
            // 
            this.payloadLblLonCaption.AutoSize = true;
            this.payloadLblLonCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblLonCaption.ForeColor = System.Drawing.Color.White;
            this.payloadLblLonCaption.Location = new System.Drawing.Point(58, 501);
            this.payloadLblLonCaption.Name = "payloadLblLonCaption";
            this.payloadLblLonCaption.Size = new System.Drawing.Size(206, 21);
            this.payloadLblLonCaption.TabIndex = 32;
            this.payloadLblLonCaption.Text = "- Longitude ( boylam ) ";
            this.payloadLblLonCaption.Click += new System.EventHandler(this.payloadLblLonCaption_Click);
            // 
            // payloadLblLatCaption
            // 
            this.payloadLblLatCaption.AutoSize = true;
            this.payloadLblLatCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblLatCaption.ForeColor = System.Drawing.Color.White;
            this.payloadLblLatCaption.Location = new System.Drawing.Point(58, 462);
            this.payloadLblLatCaption.Name = "payloadLblLatCaption";
            this.payloadLblLatCaption.Size = new System.Drawing.Size(164, 21);
            this.payloadLblLatCaption.TabIndex = 31;
            this.payloadLblLatCaption.Text = "- Latitude (enlem)\r\n";
            this.payloadLblLatCaption.Click += new System.EventHandler(this.payloadLblLatCaption_Click);
            // 
            // payloadLblParachuteStatus
            // 
            this.payloadLblParachuteStatus.AutoSize = true;
            this.payloadLblParachuteStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblParachuteStatus.ForeColor = System.Drawing.Color.Red;
            this.payloadLblParachuteStatus.Location = new System.Drawing.Point(723, 260);
            this.payloadLblParachuteStatus.Name = "payloadLblParachuteStatus";
            this.payloadLblParachuteStatus.Size = new System.Drawing.Size(57, 24);
            this.payloadLblParachuteStatus.TabIndex = 30;
            this.payloadLblParachuteStatus.Text = "Pasif";
            this.payloadLblParachuteStatus.Click += new System.EventHandler(this.payloadLblParachuteStatus_Click);
            // 
            // payloadLblLat
            // 
            this.payloadLblLat.AutoSize = true;
            this.payloadLblLat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblLat.ForeColor = System.Drawing.Color.White;
            this.payloadLblLat.Location = new System.Drawing.Point(299, 462);
            this.payloadLblLat.Name = "payloadLblLat";
            this.payloadLblLat.Size = new System.Drawing.Size(20, 21);
            this.payloadLblLat.TabIndex = 33;
            this.payloadLblLat.Text = "0";
            this.payloadLblLat.Click += new System.EventHandler(this.payloadLblLat_Click);
            // 
            // payloadLblLon
            // 
            this.payloadLblLon.AutoSize = true;
            this.payloadLblLon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblLon.ForeColor = System.Drawing.Color.White;
            this.payloadLblLon.Location = new System.Drawing.Point(299, 502);
            this.payloadLblLon.Name = "payloadLblLon";
            this.payloadLblLon.Size = new System.Drawing.Size(20, 21);
            this.payloadLblLon.TabIndex = 34;
            this.payloadLblLon.Text = "0";
            this.payloadLblLon.Click += new System.EventHandler(this.payloadLblLon_Click);
            // 
            // payloadLblGpsAltCaption
            // 
            this.payloadLblGpsAltCaption.AutoSize = true;
            this.payloadLblGpsAltCaption.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblGpsAltCaption.ForeColor = System.Drawing.Color.White;
            this.payloadLblGpsAltCaption.Location = new System.Drawing.Point(58, 543);
            this.payloadLblGpsAltCaption.Name = "payloadLblGpsAltCaption";
            this.payloadLblGpsAltCaption.Size = new System.Drawing.Size(144, 21);
            this.payloadLblGpsAltCaption.TabIndex = 35;
            this.payloadLblGpsAltCaption.Text = "- Altitude (İrtifa)";
            this.payloadLblGpsAltCaption.Click += new System.EventHandler(this.payloadLblGpsAltCaption_Click);
            // 
            // payloadLblGpsAlt
            // 
            this.payloadLblGpsAlt.AutoSize = true;
            this.payloadLblGpsAlt.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblGpsAlt.ForeColor = System.Drawing.Color.White;
            this.payloadLblGpsAlt.Location = new System.Drawing.Point(299, 543);
            this.payloadLblGpsAlt.Name = "payloadLblGpsAlt";
            this.payloadLblGpsAlt.Size = new System.Drawing.Size(20, 21);
            this.payloadLblGpsAlt.TabIndex = 36;
            this.payloadLblGpsAlt.Text = "0";
            this.payloadLblGpsAlt.Click += new System.EventHandler(this.payloadLblGpsAlt_Click);
            // 
            // faydalıyukdurumuetiketi
            // 
            this.faydalıyukdurumuetiketi.AutoSize = true;
            this.faydalıyukdurumuetiketi.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faydalıyukdurumuetiketi.ForeColor = System.Drawing.Color.White;
            this.faydalıyukdurumuetiketi.Location = new System.Drawing.Point(665, 39);
            this.faydalıyukdurumuetiketi.Name = "faydalıyukdurumuetiketi";
            this.faydalıyukdurumuetiketi.Size = new System.Drawing.Size(188, 21);
            this.faydalıyukdurumuetiketi.TabIndex = 37;
            this.faydalıyukdurumuetiketi.Text = "Faydalı yük durumu ";
            // 
            // payloadLblBaroAltCaption
            // 
            this.payloadLblBaroAltCaption.AutoSize = true;
            this.payloadLblBaroAltCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblBaroAltCaption.ForeColor = System.Drawing.Color.White;
            this.payloadLblBaroAltCaption.Location = new System.Drawing.Point(669, 458);
            this.payloadLblBaroAltCaption.Name = "payloadLblBaroAltCaption";
            this.payloadLblBaroAltCaption.Size = new System.Drawing.Size(72, 19);
            this.payloadLblBaroAltCaption.TabIndex = 38;
            this.payloadLblBaroAltCaption.Text = "Baro Alt";
            this.payloadLblBaroAltCaption.Click += new System.EventHandler(this.payloadLblBaroAltCaption_Click);
            // 
            // payloadLblBaroAlt
            // 
            this.payloadLblBaroAlt.AutoSize = true;
            this.payloadLblBaroAlt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadLblBaroAlt.ForeColor = System.Drawing.Color.White;
            this.payloadLblBaroAlt.Location = new System.Drawing.Point(785, 458);
            this.payloadLblBaroAlt.Name = "payloadLblBaroAlt";
            this.payloadLblBaroAlt.Size = new System.Drawing.Size(18, 19);
            this.payloadLblBaroAlt.TabIndex = 39;
            this.payloadLblBaroAlt.Text = "0";
            this.payloadLblBaroAlt.Click += new System.EventHandler(this.payloadLblBaroAlt_Click);
            // 
            // Payload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(932, 712);
            this.Controls.Add(this.payloadLblBaroAlt);
            this.Controls.Add(this.payloadLblBaroAltCaption);
            this.Controls.Add(this.faydalıyukdurumuetiketi);
            this.Controls.Add(this.payloadLblGpsAlt);
            this.Controls.Add(this.payloadLblGpsAltCaption);
            this.Controls.Add(this.payloadLblLon);
            this.Controls.Add(this.pressureCaption);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.payloadLblLat);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.payloadLblLonCaption);
            this.Controls.Add(this.moisture);
            this.Controls.Add(this.payloadLblParachuteStatus);
            this.Controls.Add(this.moistureCaption);
            this.Controls.Add(this.payloadLblLatCaption);
            this.Controls.Add(this.temperatureCaption);
            this.Controls.Add(this.payloadParachutePicture);
            this.Controls.Add(this.payloadGMap);
            this.Controls.Add(this.payloadGpsCaption);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Payload";
            this.Text = "ac";
            this.Load += new System.EventHandler(this.Payload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payloadParachutePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl payloadGMap;
        private System.Windows.Forms.Label pressureCaption;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label moisture;
        private System.Windows.Forms.Label temperatureCaption;
        private System.Windows.Forms.Label moistureCaption;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label payloadGpsCaption;
        private System.Windows.Forms.PictureBox payloadParachutePicture;
        private System.Windows.Forms.Label payloadLblLonCaption;
        private System.Windows.Forms.Label payloadLblLatCaption;
        private System.Windows.Forms.Label payloadLblParachuteStatus;
        private System.Windows.Forms.Label payloadLblLat;
        private System.Windows.Forms.Label payloadLblLon;
        private System.Windows.Forms.Label payloadLblGpsAltCaption;
        private System.Windows.Forms.Label payloadLblGpsAlt;
        private System.Windows.Forms.Label faydalıyukdurumuetiketi;
        private System.Windows.Forms.Label payloadLblBaroAltCaption;
        private System.Windows.Forms.Label payloadLblBaroAlt;
    }
}