using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface
{
    public class ImagePhoto
    {
        //@"C:\myTemp\myImage.jpg";
        string _snapName;
        string _snapFormat;
        DateTime _snapDate;
        bool _isCamera;
        public ImagePhoto(string snapName, DateTime snapDate, string snapFormat, bool isCamera)
        {
            _snapName = snapName;
            _snapDate = snapDate;
            _snapFormat = snapFormat;
            _isCamera = isCamera;
        }
        //property
        public string SnapName { get {return _snapName; } private set {_snapName = value; } }
        public DateTime DateSnap { get { return _snapDate; } private set { _snapDate = value; } }
        public string SnapFormat { get { return _snapFormat; } private set { _snapFormat = value; } }

        //methods
        public string GetSnap()
        {
            if (_isCamera)
            {
                return $"snapTaken {_snapName}{_snapDate.ToString("dMMyyyy")}{_snapFormat}";
            }
            else
            {
                return $"noCamera available";
            }
           
        }
    }
}
