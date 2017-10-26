using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEmulator1.Cameras;

namespace SuperEmulator1
{
    public abstract class HeadSet
    {
        //last added
        ICamera _frontCameraBehavior;
        ICamera _rearCameraBhavior;

        public bool Call(double number)
        {
            //or void ?
            return true;
        
        }
        public bool SendSms(string Messaggio)
        {
            //or void 
            return true;
        }

       
        public void GoTakePicture()
        {
          //  _rearCameraBhavior.;
           
        }
        public void GoTakeSelfie()
        {
          //  _frontCameraBehavior. ;
          
        }

        public class ActionResult ActivateCamera()
        {
            ActionResult result = new ActionResult();
            return result;
        }

        public class ActionResult DeActivateCamera()
        {

            ActionResult result = new ActionResult();
            return result;
        }
    }
}

