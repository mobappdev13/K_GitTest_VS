using CameraClassTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraClassTest

{

    //questo è il tipo
    public enum TypeCamera { FRONT, REAR };


    public class CameraClass
    {
        protected string _nameCamera;
        protected bool _isActive;
        protected TypeCamera _typeCamera;

        public CameraClass(string nameCamera, TypeCamera typeCamera, bool isActive)
        {
            _nameCamera = nameCamera;
            _isActive = isActive;
            _typeCamera = typeCamera;
        }

        //proprietà
        public string NameCamera { get { return _nameCamera; } private set {; } }

        public bool IsActive { get { return _isActive; } private set {; } }
        public TypeCamera TypeCamera { get { return _typeCamera; } private set {; } }

        //metodi

        public ActionResult Activate(TypeCamera typeCamera)
        {
            if ((TypeCamera.FRONT == typeCamera) || (TypeCamera.REAR == typeCamera))
            {
                if (_isActive)
                {
                    _isActive = true;
                    return new ActionResult(_isActive, "Was ALREADY Activated");
                }
                else
                {
                    _isActive = true;
                    return new ActionResult(_isActive, "Activated !");
                }

            }
            else
            {
                return new ActionResult(_isActive, "Error TypeCamera in Activate !");
            }
        }

        public ActionResult DeActivate(TypeCamera typeCamera)
        {
            if ((TypeCamera.FRONT == typeCamera) || (TypeCamera.REAR == typeCamera))
            {
                if (_isActive)
                {
                    return new ActionResult(_isActive = false, "Deactivated ! ");
                }
                else
                {
                   
                    return new ActionResult(_isActive = false, "Was already deactivated ");
                }
            }
            else
            {
                return new ActionResult(_isActive, "Error TypeCamera in DeActivate !");
            }
        }
    }
}

