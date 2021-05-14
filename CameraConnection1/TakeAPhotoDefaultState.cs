using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    class TakeAPhotoDefaultState : IState
    {
        // Ghi đè lên hàm TakeAPhoto ở IState chức năng chụp hình thường
        public Image TakeAPhoto(StateContext context, Image img)
        {
            return img;
        }
    }
}
