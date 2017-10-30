using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass
{
    class Program
    {

        static void Main(string[] args)
        {
            IphoneCamera iphoneCamera = new IphoneCamera("Iphone's Camera", TypeCamera.FRONT, false);
            //with getDescrption non override in IphoneCamera commented
           // Console.WriteLine($"result {iphoneCamera.GetDescription("Iphone's Camera", TypeCamera.FRONT)} is activate ? {iphoneCamera.Activate()} ");
            //with getDescption override in IphoneCamera uncommented
            Console.WriteLine($"result {iphoneCamera.GetDescription("Iphone's Camera", TypeCamera.FRONT)} is activate ? {iphoneCamera.Activate()} ");
            Console.ReadLine();
        }
    }
}
