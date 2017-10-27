using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1.Cameras
{
    class FiveMegapixelsCamera : ICamera
    {
        private bool _activated;
        public bool IsActive => _activated;

        public ActionResult Activate()
        {
            _activated = true;
            return new ActionResult(true, "Camera is now active");
        }

        public ActionResult Deactivate()
        {
            _activated = false;
            return new ActionResult(true, "Camera is now inactive");
        }

        public Photo TakeSnap()
        {
            if (IsActive)
            {
                return new Photo();
            }
            else
            {
                throw new InvalidOperationException("Activate camera before taking a photo");
            }
        }
    }
}
}
