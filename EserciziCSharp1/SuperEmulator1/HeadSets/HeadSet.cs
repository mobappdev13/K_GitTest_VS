using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEmulator1.Cameras;

namespace SuperEmulator1
{

    internal abstract class HeadSet
    {  
        //per take snap
        protected ICamera _frontCamera;
        protected ICamera _rearCamera;
        //const DateTime nullValue = "1753";
        //per Call attenzione TimeSpan
        private DateTime _callTime;
        const float MAXCHARFORSMS = 160;

        internal enum CameraPosition { Front, Rear }

        internal abstract string Model { get; }

        internal ActionResult Call(string phoneNumber)
        {
            //value initial se è nulla non è partita la chiamata
            ActionResult result;
            if (_callTime != DateTime.MinValue)
            {
                _callTime = DateTime.Now;
                result = new ActionResult(true, "Call start at time " + _callTime.ToString());
                return result;
            }
            else
            {
                result = new ActionResult(false, "Call already exist");
            }
            return result;
        }

        internal ActionResult HangUp()
        {
            ActionResult result;
            DateTime _endCallTime = DateTime.Now;
            //comparo le date con
            if (_callTime != DateTime.MinValue)
            {
                //attenzione TimeSpan
                TimeSpan _callDuration = _endCallTime - _callTime;
                result = new ActionResult(true, $"Call ENDS whit duration {_callDuration.Hours} hours {_callDuration.Minutes} minutes {_callDuration.Seconds} seconds ");
                return result;
            }
            else
            {
                result = new ActionResult(false, "Impossible! call not existe");
            }
            return result;
        }

        internal ActionResult SendSMS(string phoneNumber, string textMessage)
        {
           //aattenzione float
            double messaggeNumber = textMessage.Length / MAXCHARFORSMS;
            int roundedNumber = (int)Math.Ceiling(messaggeNumber);  

            return new ActionResult(true, $"SMS send to number{phoneNumber} with {roundedNumber} messagges");
        }

        internal ActionResult ActivateCamera(CameraPosition camPosition)
        {
            ICamera camera = GetCamera(camPosition);
            return camera.Activate();
        }

        internal ActionResult DeactivateCamera(CameraPosition camPosition)
        {

            ICamera camera = GetCamera(camPosition);
;           return camera.Deactivate();
        }

        internal ActionResult TakePicture(CameraPosition camPosition)
        {
            //la interfaccia
            ICamera camera;
            camera = GetCamera(camPosition);
            //attenzione da qui in poi si usa la Interfaccia
            ActionResult result = camera.Activate();
            if (result.Success)
            {
                Photo photo = camera.TakeSnap();
                return new ActionResult(true, "Photo successfully taken");
            }
            else
            {
                return new ActionResult(false, "No photo was taken. Camera is not active");
            }
        }

        private ICamera GetCamera(CameraPosition camPosition)
        {
            ICamera camera;
            if (CameraPosition.Front == camPosition)
            {
                camera = _frontCamera;
            }
            else
            {
                camera = _rearCamera;
            }

            return camera;
        }
    }
}

