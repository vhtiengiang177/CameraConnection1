using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    interface ICamera
    {
        void Start(VideoCaptureDevice camera);
    }
}
