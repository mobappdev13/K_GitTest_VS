using CameraInterface.Cameras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine(" test Action Result ");
            //text class actioResult
            ActionResult actionResult = new ActionResult("***this message ***", true); 
            Console.WriteLine($"action result {actionResult.Message} and {actionResult.Succes}");

            Console.WriteLine();
            Console.WriteLine(" test Class ImagePhoto ");
            //text class ImagePhoto
            ImagePhoto imagePhoto = new ImagePhoto(@"C:\myImages\myImage", DateTime.Now, ".jpg", true);
            string result = imagePhoto.GetSnap();
            Console.WriteLine($"ImagePhoto {result} ");
            
            //test class ImgePhoto noCamera
            imagePhoto = new ImagePhoto(@"C:\myImages\myImage", DateTime.Now, ".jpg", false);
            result = imagePhoto.GetSnap();
            Console.WriteLine($"ImagePhoto {result} ");

            //test interface per HUAWEI
            Console.WriteLine();
            Console.WriteLine(" test ICamera ");
            //test activate
            //
            HuaweiCamera huaweiCamera = new HuaweiCamera();
            ActionResult HuaweiResult = huaweiCamera.Activate();

            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive: {HuaweiResult.Succes}");
            //activate when already active
            HuaweiResult = huaweiCamera.Activate();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");
            
            //deActivate when already active
            HuaweiResult = huaweiCamera.DeActivate();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");

            //deActivate when already deactive
            HuaweiResult = huaweiCamera.DeActivate();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");
            
            //ChargeCamera
            HuaweiResult = huaweiCamera.ChargeCamera();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");

            //set Camera when non activated
            HuaweiResult = huaweiCamera.SetCamera();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");

            //test new activate
            huaweiCamera = new HuaweiCamera();
            HuaweiResult = huaweiCamera.Activate();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");

            //set Camera after activated
            HuaweiResult = huaweiCamera.SetCamera();
            Console.WriteLine($"HuaweiResult {HuaweiResult.Message} and isActive {HuaweiResult.Succes}");

            ImagePhoto HuaweiPhotoResult = huaweiCamera.TakeSnap();
            Console.WriteLine($"HuaweiPhotoResult { HuaweiPhotoResult.GetSnap()}" );

            //$"snapTaken {_snapName}{_snapDate.ToString("dMMyyyy")}{_snapFormat}
            //Console.WriteLine($"HuaweiPhotoResult {HuaweiPhotoResult.SnapName}{HuaweiPhotoResult.DateSnap.ToString("dMMyyyy")}{HuaweiPhotoResult.SnapFormat}");
            
            //test interface per IPHONE
            Console.WriteLine();
            Console.WriteLine(" test ICamera ");


            IPhoneCamera iphoneCamera = new IPhoneCamera();
            ActionResult iphoneResult = iphoneCamera.Activate();
            //
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive: {iphoneResult.Succes}");
            //activate when already active
            iphoneResult = iphoneCamera.Activate();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //deActivate when already active
            iphoneResult = iphoneCamera.DeActivate();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //deActivate when already deactive
            iphoneResult = iphoneCamera.DeActivate();
            Console.WriteLine($"IPhoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //ChargeCamera
            iphoneResult = iphoneCamera.ChargeCamera();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //set Camera when non activated
            iphoneResult = iphoneCamera.SetCamera();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //test new activate
            huaweiCamera = new HuaweiCamera();
            iphoneResult = iphoneCamera.Activate();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            //set Camera after activated
            iphoneResult = iphoneCamera.SetCamera();
            Console.WriteLine($"IphoneResult {iphoneResult.Message} and isActive {iphoneResult.Succes}");

            ImagePhoto IphonePhotoResult = iphoneCamera.TakeSnap();
            Console.WriteLine($" IphonePhotoResult {  IphonePhotoResult.GetSnap()}");

            Console.WriteLine();
            Console.WriteLine(" test noCamera ");
            // test NoCamera for Nokia
            NoCamera nokiaCamera = new NoCamera();
            ActionResult nokiaResult = nokiaCamera.Activate();
            Console.WriteLine($"NokiaResult {nokiaResult.Message} and isActive: {nokiaResult.Succes}");

            //
            ImagePhoto NokiaPhotoResult = nokiaCamera.TakeSnap();
            Console.WriteLine($" NokiaPhotoResult {  NokiaPhotoResult.GetSnap()}");


            Console.ReadLine();
        }
    }
}
