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
                currentCamera.Stop();
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
                SaveFileDialog savePhoto = new SaveFileDialog();
                savePhoto.Filter = "JPG | *.jpg | PNG | *.png";
                savePhoto.Title = "Save an Image File";
                if (savePhoto.ShowDialog() == DialogResult.OK)
                {
                    ptbCam.Image.Save(savePhoto.FileName);
                }
            }
            else
            {
                MessageBox.Show("No camera to take a photo!");
            }
        }
    }
}
