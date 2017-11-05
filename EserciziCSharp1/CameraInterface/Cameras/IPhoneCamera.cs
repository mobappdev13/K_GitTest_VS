using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    class IPhoneCamera : ICamera
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
                return new ActionResult("Camera IPHONE has been activated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera IPHONE has been already active", _isActive);

            }
        }

        public ActionResult ChargeCamera()
        {
            return new ActionResult(" Camera IPHONE was completly Charged!", true);
        }

        public ActionResult DeActivate()
        {
            if (_isActive)
            {
                _isActive = false;
                return new ActionResult("Camera IPHONE has been Deactivated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera IPHONE has been already Deactived", _isActive);
            }
        }

        public ActionResult SetCamera()
        {
            if (_isActive)
            {
                return new ActionResult(" Ok all Camera's IPHONE settings has been applied ", _isActive);
            }
            else
            {
                return new ActionResult(" Error was not possible set camera IPHONE because was already Deactive ", _isActive);
            }
        }

        public ImagePhoto TakeSnap()
        {
            if (_isActive)
            {
                return new ImagePhoto(@"C:\myImagesIphone\myImage", DateTime.Now, ".jpg", true);
            }
            else
            {
                return new ImagePhoto("noActiveIPhoneCamera", DateTime.Now, "noActive", true);
            }     
           
        }
    }
}
