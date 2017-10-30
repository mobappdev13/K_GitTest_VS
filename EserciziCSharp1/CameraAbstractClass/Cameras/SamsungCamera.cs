using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass.Cameras
{
    class SamsungCamera : CameraAbstract
    {
        public SamsungCamera(string nameCamera, TypeCamera typeCamera, bool isActive) : base(nameCamera, typeCamera, isActive)
        {
        }

        public override bool Activate()
        {
            if (!_isActive)
            {
                _isActive = true;
            }
            else
            {
                Console.WriteLine(" Error was already active");
            }
            return _isActive; ;
        }

        public override string ChargeCamera()
        {
            return " Camera was completly Charged!";
        }

        public override bool DeActivate()
        {
            if (_isActive)
            {
                _isActive = false;
            }
            else
            {
                Console.WriteLine(" Error was already Deactived");
            }
            return _isActive;
        }

        public override string SetCamera()
        {
            if (_isActive)
            {
                return (" Ok all Camera's settings has been applied ");
            }
            else
            {
                return (" Error Camera was not active");
            }
        }

        public override string TakePicture()
        {
            if (_isActive)
            {
                return (" The photo has been taken successfully ");
            }
            else
            {
                return (" Error taking Photo, Camera was not active");
            }
        }
    }
    }


