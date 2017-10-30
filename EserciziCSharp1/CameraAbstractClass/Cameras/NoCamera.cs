using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass.Cameras
{
    public class NoCamera : CameraAbstract
    {
        public NoCamera(string nameCamera, TypeCamera typeCamera, bool isActive) : base(nameCamera, typeCamera, isActive)
        {
            _isActive = false;
        }

        public override bool Activate()
        {
            return false;
        }

        public override string ChargeCamera()
        {
            return "No camera available";
        }

        public override bool DeActivate()
        {
            return false;
        }

        public override string SetCamera()
        {
            return "No camera available";
        }

        public override string TakePicture()
        {
            return "No camera available";
        }
    }
}
