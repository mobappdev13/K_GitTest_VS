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
            ImagePhoto imagePhoto = new ImagePhoto(@"C:\myImages\myImage", DateTime.Now, ".jpg");
            string result = imagePhoto.GetSnap();
            Console.WriteLine($"ImagePhoto {result} ");

            Console.ReadLine();
        }
    }
}

