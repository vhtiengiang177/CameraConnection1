using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    interface ICamera
    {
        // Chức năng mở camera
        void Start(VideoCaptureDevice camera);

        // Chức năng tắt camera
        void Stop(VideoCaptureDevice camera);
    }
}
