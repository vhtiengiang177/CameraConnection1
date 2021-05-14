using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    class CameraAdaptee
    {
        // Hàm bật camera đã có ở camera đã thiết lập 
        public void Start(VideoCaptureDevice camera)
        {
            camera.Start();
        }
    }
}
