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
        public ImagePhoto(string snapName, DateTime snapDate, string snapFormat)
        {
            _snapName = snapName;
            _snapDate = snapDate;
            _snapFormat = snapFormat;
        }
        //property
        public string SnapName { get {return _snapName; } set {_snapName = value; } }
        public DateTime DateSnap { get { return _snapDate; } set { _snapDate = value; } }
        public string SnapFormat { get { return _snapFormat; } set { _snapFormat = value; } }

        //methods
        public string GetSnap()
        {
           
            return $"snapTaken {_snapName}{_snapDate.ToString("dMMyyyy")}{_snapFormat}";
        }
    }
}
