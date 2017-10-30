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
        //proprieta

        //metodi non astratti
        public override string GetDescription(string _nameCamera, TypeCamera _typeCamera)
        {
            if (_typeCamera == TypeCamera.FRONT)
            {
                return ("this method was overrated " +_nameCamera + " " + Enum.GetName(typeof(TypeCamera), 0));
            }
            else
            {
                return ("this method was overrated" +_nameCamera + " " + Enum.GetName(typeof(TypeCamera), 1));
            }
        }
        //metodi astratti

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
           return _isActive;
        }

        public override bool ChargeCamera(TypeCamera _typeCamera)
        {
            Console.WriteLine(" Camera were Charged!");
            return true;
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
    

        public override void SetCamera()
        {
            Console.WriteLine(" ok all settings were applied ");
        }

        public override void TakePicture()
        {
            throw new NotImplementedException();
        }

    }
}
