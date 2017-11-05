using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    public class NoCamera : ICamera
    {
        public bool _isActive = false;
       
        public bool isActive
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ActionResult Activate()
        {
            return new ActionResult("No camera available", _isActive);
        }

        public ActionResult ChargeCamera()
        {
            return new ActionResult("No camera available", _isActive);
        }

        public ActionResult DeActivate()
        {
            return new ActionResult("No camera available", _isActive);
        }

        public ActionResult SetCamera()
        {
            return new ActionResult("No camera available", _isActive);
        }

        public ImagePhoto TakeSnap()
        {
            return new ImagePhoto("noCamera", DateTime.Now, "noFoto", false);
        }
    }
}
