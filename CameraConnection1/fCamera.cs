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
        private StateContext context;

        public fCamera()
        {
            InitializeComponent();
            // Khởi tạo context với trạng thái hiện tại là TakeAPhotoState. 
            // Nếu muốn đổi sang trạng thái khác thì gọi 
            // context.setState(new TakeAPhotoSpecialState());
            StateContext context = new StateContext();
            lstCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in lstCamera)
            {
                cbbListCamera.Items.Add(info.Name);
            }
            cbbListCamera.SelectedIndex = 0;
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

            // Khởi động camera
            CameraAdaptee cameraAdaptee = new CameraAdaptee();
            ICamera camera = new CameraAdapter(cameraAdaptee);
            camera.Start(currentCamera);

            //currentCamera.Start();
            btnTakeAPhoto.Enabled = true;
        }

        private void CurrentCamera_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            ptbCam.Image = img;
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
                // Chức năng chụp hình
                ptbPhoto.Image = context.takeAPhoto(ptbCam.Image);
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
