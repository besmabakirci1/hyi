using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsFormsApp1
{
    public partial class Payload : Form
    {
        private GMapOverlay _markersOverlay;
        private bool _mapInitialized = false;
        public Payload()
        {
            InitializeComponent();
            this.Load += Payload_Load;

        }
        private void Payload_Load(object sender, EventArgs e)
        {
            if (_mapInitialized) return;

            payloadGMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            payloadGMap.MinZoom = 2;
            payloadGMap.MaxZoom = 18;
            payloadGMap.Zoom = 5;
            payloadGMap.Position = new PointLatLng(39.96922983, 32.74309033);
            payloadGMap.ShowCenter = false;
            payloadGMap.CanDragMap = true;
            payloadGMap.DragButton = MouseButtons.Left;

            _markersOverlay = new GMapOverlay("markers");
            payloadGMap.Overlays.Add(_markersOverlay);

            var initialMarker = new GMarkerGoogle(
                new PointLatLng(39.96922983, 32.74309033),
                GMarkerGoogleType.red_pushpin
            );
            _markersOverlay.Markers.Add(initialMarker);

            _mapInitialized = true;
        }
        internal void UpdateGPS(double lat, double lon, double alt)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateGPS(lat, lon, alt)));
                return;
            }

            payloadLblLat.Text = lat.ToString("F6");
            payloadLblLon.Text = lon.ToString("F6");
            payloadLblGpsAlt.Text = alt.ToString("F1");

            _markersOverlay.Markers.Clear();
            var marker = new GMarkerGoogle(
                new PointLatLng(lat, lon),
                GMarkerGoogleType.red_pushpin
            );
            _markersOverlay.Markers.Add(marker);

            payloadGMap.Position = marker.Position;
            payloadGMap.Refresh();
        }
        internal void UpdateSensors(double pressureVal, double humidityVal, double temperatureVal, double baroAltVal)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateSensors(pressureVal, humidityVal, temperatureVal, baroAltVal)));
                return;
            }

            pressure.Text = pressureVal.ToString("F1");
            moisture.Text = humidityVal.ToString("F1");
            temperature.Text = temperatureVal.ToString("F1");
            payloadLblBaroAlt.Text = baroAltVal.ToString("F1");
        }
        internal void UpdateParachuteStatus(bool para1, bool para2)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateParachuteStatus(para1, para2)));
                return;
            }

            // Sadece apogee paraşütünü dikkate alıyoruz:
            if (para1)
            {
                payloadLblParachuteStatus.Text = "Aktif";
                payloadLblParachuteStatus.ForeColor = Color.Lime;
            }
            else
            {
                payloadLblParachuteStatus.Text = "Pasif";
                payloadLblParachuteStatus.ForeColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblLat_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblLon_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblGpsAlt_Click(object sender, EventArgs e)
        {

        }

        private void pressure_Click(object sender, EventArgs e)
        {

        }

        private void moisture_Click(object sender, EventArgs e)
        {

        }

        private void temperature_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblBaroAlt_Click(object sender, EventArgs e)
        {

        }

        private void payloadGMap_Load(object sender, EventArgs e)
        {

        }

        private void payloadLblParachuteStatus_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblLonCaption_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblGpsAltCaption_Click(object sender, EventArgs e)
        {

        }

        private void pressureCaption_Click(object sender, EventArgs e)
        {

        }

        private void moistureCaption_Click(object sender, EventArgs e)
        {

        }

        private void temperatureCaption_Click(object sender, EventArgs e)
        {

        }

        private void payloadLblBaroAltCaption_Click(object sender, EventArgs e)
        {

        }

        private void payloadParachutePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
