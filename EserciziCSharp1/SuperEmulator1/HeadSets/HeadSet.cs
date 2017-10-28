using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    public abstract class HeadSet
    {
        //last added
        IFrontCameraBehavior _frontCameraBehavior;
        IRearCameraBehavior _rearCameraBhavior;

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

        ////public abstract string DisplayModel(string ) 
        //{
        //}
        public void GoTakePicture()
        {
            _rearCameraBhavior.TakePicture();
           
        }
        public void GoTakeSelfie()
        {
            _frontCameraBehavior.TakeSelfie() ;
          
        }

        //public ActionResult (...)
        //{
            
        //    return true 
        //}
    }
}

