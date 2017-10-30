using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass
{
    //a type
    public enum TypeCamera
    { FRONT, REAR };
    public abstract class CameraAbstract
    {
        //variabili di classe
        protected string _nameCamera;
        protected bool _isActive;
        protected TypeCamera _typeCamera;
        //costruttore
        public CameraAbstract(string nameCamera, TypeCamera typeCamera, bool isActive)
        {
            _nameCamera = nameCamera;
            _typeCamera = typeCamera;
            _isActive = isActive;
        }
        //proprieta
        public string NameCamera { get { return _nameCamera; } private set { _nameCamera = value; } }
        public TypeCamera TypeCamera { get { return _typeCamera; } set { _typeCamera = value; } }

        public bool IsActive { get { return _isActive; } set { _isActive = value; } }



        // metodo non astratto
        public string GetDescription(string _nameCamera, TypeCamera _typeCamera)
        {
            Console.WriteLine(" questo " + (_nameCamera + Enum.GetName(typeof(TypeCamera), 1)));
            return "si";
        }
        // metodi astratti

        public abstract bool Activate();
        public abstract bool DeActivate();
        public abstract void SetCamera();
        public abstract void TakePicture();
        public abstract void ChargeCamera();

    }
}
