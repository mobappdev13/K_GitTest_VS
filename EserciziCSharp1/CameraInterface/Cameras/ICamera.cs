using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    interface ICamera
    {
        
        ActionResult Activate();
        bool isActive { get; set; }
        ActionResult DeActivate();

        ImagePhoto TakeSnap();
    }
}

