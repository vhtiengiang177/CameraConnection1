using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraConnection1
{
    public partial class fCamera : Form
    {
        private FilterInfoCollection lstCamera;
        private VideoCaptureDevice currentCamera;
        public fCamera()
        {
            InitializeComponent();
            lstCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in lstCamera)
            {
                cbbListCamera.Items.Add(info.Name);
            }
            cbbListCamera.SelectedIndex = 0;
            btnDisconnect.Enabled = false;
            btnTakeAPhoto.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (currentCamera != null && currentCamera.IsRunning)
            {
                currentCamera.Stop();
            }
            currentCamera = new VideoCaptureDevice(lstCamera[cbbListCamera.SelectedIndex].MonikerString);
            currentCamera.NewFrame += CurrentCamera_NewFrame;
            currentCamera.Start();
            btnDisconnect.Enabled = true;
            btnTakeAPhoto.Enabled = true;
        }

        private void CurrentCamera_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            ptbCam.Image = img;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (currentCamera != null && currentCamera.IsRunning)
            {
                currentCamera = null;
                btnDisconnect.Enabled = false;
                btnTakeAPhoto.Enabled = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (currentCamera != null)
            {
                currentCamera.Stop();
            }
        }

        private void btnTakeAPhoto_Click(object sender, EventArgs e)
        {
            if (ptbCam != null)
            {
                ptbPhoto.Image = ptbCam.Image;
                btnTakeAPhoto.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnTakeAPhoto.Enabled = true;
            btnClear.Enabled = false;
            ptbPhoto.Image = null;
        }
    }
}
