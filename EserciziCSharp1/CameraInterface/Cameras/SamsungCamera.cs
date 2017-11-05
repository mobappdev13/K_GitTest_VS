using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    public class SamsungCamera : ICamera
    {
        public bool _isActive;
        public bool isActive
        {
            get
            {
                { return _isActive; };
            }

            set
            {
                { _isActive = value; }
            }
        }

        public ActionResult Activate()
        {
            if (!_isActive)
            {
                _isActive = true;
                return new ActionResult("Camera Samsung has been activated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera Samsung has been already active", _isActive);

            }
        }

        public ActionResult ChargeCamera()
        {
            return new ActionResult(" Camera was completly Charged!", true);
        }

        public ActionResult DeActivate()
        {
            if (_isActive)
            {
                _isActive = false;
                return new ActionResult("Camera Samsung has been Deactivated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera Samsung has been already Deactived", _isActive);
            }
        }

        public ActionResult SetCamera()
        {
            if (_isActive)
            {
                return new ActionResult(" Ok all Camera's Samsung settings has been applied ", _isActive);
            }
            else
            {
                return new ActionResult(" Error was not possible set Camera Samsung because was already Deactive ", _isActive);
            }
        }

        public ImagePhoto TakeSnap()
        {
            if (_isActive)
            {
                return new ImagePhoto(@"C:\myImagesSamsung\myImage", DateTime.Now, ".jpg", true);
            }
            else
            {
                return new ImagePhoto("noActiveSamsungCamera", DateTime.Now, "noActive",true);
            }
        }
    }
}
