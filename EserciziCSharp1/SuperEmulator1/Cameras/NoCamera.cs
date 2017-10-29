using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1.Cameras
{
    internal class NoCamera : ICamera
    {
        public bool IsActive => false;

        public ActionResult Activate()
        {
            return new ActionResult(false, "No camera available");
        }

        public ActionResult Deactivate()
        {
            return new ActionResult(false, "No camera available");
        }

        public Photo TakeSnap()
        {
            throw new InvalidOperationException("Impossible to take photo, there is no camera available");
        }
    }
}
