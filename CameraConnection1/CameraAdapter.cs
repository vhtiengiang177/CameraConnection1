﻿using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    class CameraAdapter : ICamera
    {
        private readonly CameraAdaptee _cameraAdaptee;

        public CameraAdapter(CameraAdaptee cameraAdaptee)
        {
            this._cameraAdaptee = cameraAdaptee;
        }

        // Bộ chuyển đổi để interface của CameraAdaptee tương thích với ICamera 
        public void Start(VideoCaptureDevice camera)
        {
            _cameraAdaptee.Start(camera);
        }
    }
}
