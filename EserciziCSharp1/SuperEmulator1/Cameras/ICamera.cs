using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SuperEmulator1.HeadSet;

namespace SuperEmulator1.Cameras
{
    internal interface ICamera
    {
        Photo TakeSnap();
        bool IsActive { get; }
        ActionResult ActivateCamera();
    }

    
}
