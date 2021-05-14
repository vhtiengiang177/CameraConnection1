using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    class TakeAPhotoSpecialState
    {
        // Ghi đè lên hàm TakeAPhoto ở IState chức năng chụp hình đặc biệt
        public Image TakeAPhoto(StateContext context, Image img)
        {
            // Mở rộng cho chức năng chụp hình có filter khác.
            return null;
        }
    }
}
