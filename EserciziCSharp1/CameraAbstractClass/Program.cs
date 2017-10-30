using CameraAbstractClass.Cameras;
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
            //instane IphoneCamera
            Console.WriteLine("_______");
           IphoneCamera iphoneCamera = new IphoneCamera("Iphone's Camera", TypeCamera.FRONT, false);
            Console.WriteLine("***IPHONE*****");
            //with getDescrption non override in IphoneCamera commented
            Console.WriteLine($"result {iphoneCamera.GetDescription("Iphone's Camera", TypeCamera.FRONT)} is activate ? {iphoneCamera.Activate()} ");
            //with getDescription override in IphoneCamera uncommented
            //Console.WriteLine($"result {iphoneCamera.GetDescription("Iphone's Camera", TypeCamera.FRONT)} is activate ? {iphoneCamera.Activate()} ");
            Console.WriteLine($"result after deactivated {iphoneCamera.GetDescription("Iphone's Camera", TypeCamera.FRONT)} is activate ? {iphoneCamera.DeActivate()} ");
            Console.WriteLine("********");
            Console.WriteLine($"result after setCamera {iphoneCamera.SetCamera()}");
            Console.WriteLine("********");
            Console.WriteLine($"result after Charge Camera {iphoneCamera.ChargeCamera()}");
            Console.WriteLine("********");
            Console.WriteLine($"result after Take Picture {iphoneCamera.TakePicture()}");
            Console.WriteLine("_______");

            //instane Samsung Camera
            Console.WriteLine("***SAMSUNG*****");
            SamsungCamera samsungCamera = new SamsungCamera("Samsung Camera", TypeCamera.REAR, false);
            //with getDescrption non override in IphoneCamera commented
            Console.WriteLine($"result {samsungCamera.GetDescription("Samsung Camera", TypeCamera.REAR)} is activate ? {samsungCamera.Activate()} ");
            //with getDescription override in samsungCamera uncommented
            //Console.WriteLine($"result {samsungCamera.GetDescription("Samsung's Camera", TypeCamera.FRONT)} is activate ? {samsungCamera.Activate()} ");
           // Console.WriteLine($"result after deactivated {samsungCamera.GetDescription("Samsung Camera", TypeCamera.REAR)} is activate ? {samsungCamera.DeActivate()} ");
           // Console.WriteLine("********");
            Console.WriteLine($"result after setCamera {samsungCamera.SetCamera()}");
            Console.WriteLine("********");
            Console.WriteLine($"result after Charge Camera {samsungCamera.ChargeCamera()}");
            Console.WriteLine("********");
            Console.WriteLine($"result after Take Picture {samsungCamera.TakePicture()}");
            Console.WriteLine("********");

            //istanziate nocamera
            Console.WriteLine("***NOKIA NO CAMERA*****");
            NoCamera nokiaNocamera = new NoCamera("Nokia no Camera", TypeCamera.NOCAMERA, false);
            //with getDescrption non override in IphoneCamera commented
            Console.WriteLine($"result {nokiaNocamera.GetDescription("Nokia no Camera", TypeCamera.NOCAMERA)} is activate ? {nokiaNocamera.Activate()} ");
            //with getDescription override in samsungCamera uncommented
            Console.ReadLine();
        }
    }
}
