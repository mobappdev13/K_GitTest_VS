﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass
{
    //a type
    public enum TypeCamera
    { FRONT, REAR, NOCAMERA };
    public abstract class CameraAbstract
    {
        //variabili di classe ereditabili
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
        // public string GetDescription(string _nameCamera, TypeCamera _typeCamera)
       public virtual string GetDescription(string _nameCamera, TypeCamera _typeCamera)
        {
            //le classi derivate "possono" riscrivere (override)
            // Console.WriteLine(" GetDescription " + (_nameCamera + Enum.GetName(typeof(TypeCamera), 1)));
            // 0 FRONT, 1 REAR, 2 NOCAMERA
            if (_typeCamera == TypeCamera.FRONT)
            {
                return (_nameCamera + " " + Enum.GetName(typeof(TypeCamera), 0));
            }
            else if (_typeCamera == TypeCamera.REAR)
            {
                return (_nameCamera + " " + Enum.GetName(typeof(TypeCamera), 1));
            }
            else
            {
                return (_nameCamera + " " + Enum.GetName(typeof(TypeCamera), 2));
            }
        }
        // metodi astratti
        //le classi derivate "devono" RISCRIVERE !!!
        public abstract bool Activate();
        public abstract bool DeActivate();
        public abstract string SetCamera();
        public abstract string TakePicture();
        public abstract string ChargeCamera();

    }
}
