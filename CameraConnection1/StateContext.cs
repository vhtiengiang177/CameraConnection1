using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraConnection1
{
    class StateContext
    {
        private IState state;

        // Gán trạng thái ban đầu
        public StateContext()
        {
            state = new TakeAPhotoDefaultState();
        }
        
        // Đặt trạng thái hiện tại. 
        void setState(IState newState)
        {
            state = newState;
        }

        public Image takeAPhoto(Image img)
        {
            return state.TakeAPhoto(this, img);
        }
    }
}
