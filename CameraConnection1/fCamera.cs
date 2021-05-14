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
        private CameraAdaptee cameraAdaptee;
        ICamera camera;

        public fCamera()
        {
            InitializeComponent();
            // Sử dụng design pattern State
            // Khởi tạo context với trạng thái hiện tại là TakeAPhotoState. 
            // Nếu muốn đổi sang trạng thái khác thì gọi 
            // context.setState(new TakeAPhotoSpecialState());
            context = new StateContext();

            // Sử dụng thư viện AForge để hiển thị camera và cho phép chụp hình
            lstCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in lstCamera)
            {
                cbbListCamera.Items.Add(info.Name);
            }
            // Chọn camera đầu tiên có trong danh sách
            if(cbbListCamera.Items.Count > 0)
            {
                cbbListCamera.SelectedIndex = 0;
            }

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

            // Khởi động camera sử dụng design pattern Adapter
            cameraAdaptee = new CameraAdaptee();
            camera = new CameraAdapter(cameraAdaptee);
            camera.Start(currentCamera);

            btnTakeAPhoto.Enabled = true;
        }

        // Kích hoạt khung hình (frame) để hiển thị 
        private void CurrentCamera_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            ptbCam.Image = img;
        }

        // Dừng camera khi tắt chương trình
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (currentCamera != null && currentCamera.IsRunning)
            {
                camera.Stop(currentCamera);
            }
        }

        // Chức năng chụp hình sử dụng theo mẫu design pattern State
        private void btnTakeAPhoto_Click(object sender, EventArgs e)
        {
            if (ptbCam != null)
            {
                ptbPhoto.Image = context.takeAPhoto(ptbCam.Image);
                btnClear.Enabled = true;
            }
        }

        // Xóa hình đã chụp
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnTakeAPhoto.Enabled = true;
            btnClear.Enabled = false;
            ptbPhoto.Image = null;
        }

        // Ngừng kết nối camera
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (currentCamera != null && currentCamera.IsRunning)
            {
                camera.Stop(currentCamera);
                ptbCam.Image = null;
                btnTakeAPhoto.Enabled = false;
            }
        }
    }
}
