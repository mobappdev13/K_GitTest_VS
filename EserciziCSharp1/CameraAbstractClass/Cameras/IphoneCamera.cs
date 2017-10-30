using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass
{
    public class IphoneCamera : CameraAbstract
    {
        //our variabiles

        //costruttore

       
        public IphoneCamera(string nameCamera, TypeCamera typeCamera, bool isActive) : base(nameCamera, typeCamera, isActive)
        {
        }

        public override bool Activate()
        {
            throw new NotImplementedException();
        }

        public override void ChargeCamera()
        {
            throw new NotImplementedException();
        }

        public override bool DeActivate()
        {
            throw new NotImplementedException();
        }

        public override void SetCamera()
        {
            throw new NotImplementedException();
        }

        public override void TakePicture()
        {
            throw new NotImplementedException();
        }
        //proprieta




        //metodi astratti

    }
}
