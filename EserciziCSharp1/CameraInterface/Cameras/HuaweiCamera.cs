using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface.Cameras
{
    public class HuaweiCamera : ICamera
    {
        public bool _isActive;

        public HuaweiCamera()
        {

        }
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
                return new ActionResult("Camera Huawei has been activated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera Huawei has been already active", _isActive);
               
            }
        }

        public ActionResult DeActivate()
        {
            if (_isActive)
            {
                _isActive = false;
                return new ActionResult("Camera Huawei has been Deactivated", _isActive);
            }
            else
            {
                return new ActionResult(" Error Camera Huawei has been already Deactived", _isActive);
            }
            
        }

        public ActionResult ChargeCamera()
        {
            return new ActionResult(" Camera was completly Charged!", true);
        }
        public ActionResult SetCamera()
        {
            if (_isActive)
            {
               return new ActionResult(" Ok all Camera's Huawei settings has been applied ",_isActive);
            }
            else
            {
                return new ActionResult(" Error was not possible set camera Huawei because was already Deactive ", _isActive);
            }
        }
       

        public ImagePhoto TakeSnap()
        {
            if (_isActive)
            {
                return new ImagePhoto(@"C:\myImagesHuawei\myImage", DateTime.Now, ".jpg",true);
            }
            else
            {
                return new ImagePhoto("noActiveHuaweiCamera", DateTime.Now, "noActive",true);
            }
           
        }
    }
}


    
