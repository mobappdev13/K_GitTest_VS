using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    interface ICamera
    {
        bool isActive { get; set; }

        ActionResult Activate();
       
        ActionResult DeActivate();

        ActionResult ChargeCamera();

        ActionResult SetCamera();
      
        ImagePhoto TakeSnap();
    }
}

