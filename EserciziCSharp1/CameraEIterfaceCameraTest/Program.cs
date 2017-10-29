using System;

namespace CameraClassTest

{
    public class Program
    {
        static void Main(string[] args)
        {
          
            ActionResult result;

            Console.WriteLine("**************************************************************************************************");
            Console.WriteLine("Esercitazione Classe Base e Classe Derivata con nuove proprieta e nuovi metodi - Vargas");
            Console.WriteLine("***********************************");
            CameraClass myCamF = new CameraClass("Samsung", TypeCamera.FRONT, false);
            Console.WriteLine($"Samsung Camera Initial state: {myCamF.NameCamera} type Camera {myCamF.TypeCamera} activation state: {myCamF.IsActive.ToString()}");

            result = myCamF.Activate(TypeCamera.FRONT);
            Console.WriteLine($"after call Activate Camera message {result.Message} and Result {result.Result}");
            Console.WriteLine($"After activate: {myCamF.NameCamera} type Camera {myCamF.TypeCamera}");
            Console.WriteLine("************************************");

            // DEACTIVATE
            result = myCamF.DeActivate(TypeCamera.FRONT);
            Console.WriteLine($" after call DeActivate Camera message {result.Message} and Result activation state {result.Result}");
            Console.WriteLine($" after disactivate: {myCamF.NameCamera} type Camera {myCamF.TypeCamera}");
            Console.WriteLine("**************************************************************************************************");
            //
            //ACTIVATE deacttivate error ?
            result = myCamF.DeActivate(TypeCamera.FRONT);
            Console.WriteLine($" after call New Deactivate Camera message {result.Message} and deactivate state Result {result.Result}");
            Console.WriteLine($" after disactivate *** {myCamF.NameCamera} type Camera {myCamF.TypeCamera}");
            Console.WriteLine("**************************************");

            //CON LA CLASSE DERIVATA
            PhoneI myPhone = new PhoneI("Iphone", TypeCamera.REAR, true, 12);
            Console.WriteLine($"Iphone Camera Initial state {myPhone.NameCamera}  camera type {myPhone.TypeCamera} camera state: {myPhone.IsActive.ToString()}");
            int number = myPhone.Calcolate(12);

            Console.WriteLine($"was Calcolated brightnes ? {myPhone.Calcolate(12).ToString()} camera type {myPhone.TypeCamera} il suo stato è {myPhone.IsActive.ToString()}");
            result = myPhone.Activate(TypeCamera.REAR);
            Console.WriteLine($" after call Activate Camera message {result.Message} and Result {result.Result}");
            //Console.WriteLine($"After activate: {myPhone.NameCamera} tipo {myPhone.TypeCamera} il suo stato è {myPhone.IsActive.ToString()}");
            result = myPhone.DeActivate(TypeCamera.REAR);
            Console.WriteLine($" after disactivate IPHONE. {myPhone.NameCamera} camera type {myPhone.TypeCamera} camera state: {myPhone.IsActive.ToString()}");
            Console.ReadLine();
        }
    }
}