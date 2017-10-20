using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class Program
    {

        static void Main(string[] args)
        {           
           
            //creo lista
            List<Lamp> myLampList = new List<Lamp>();
            // aggiungo lampage
            myLampList.Add(new Lamp("Ingresso"));
            //myLampList.Add(new Lamp("salotto"));
            //myLampList.Add(new Lamp("sala pranzo"));            
            //myLampList.Add(new Lamp("cucina"));           
            //myLampList.Add(new Lamp("studio"));
            //myLampList.Add(new Lamp("bagno"));            
            //myLampList.Add(new Lamp("scale interne"));
            //myLampList.Add(new Lamp("tettoia"));
            //myLampList.Add(new Lamp("lavanderia"));
            //myLampList.Add(new Lamp("camera padronale"));
            //myLampList.Add(new Lamp("camera figlio"));
            //myLampList.Add(new Lamp("camera figlia"));
            //myLampList.Add(new Lamp("soffita"));
            //myLampList.Add(new Lamp("scale soffitta"));
            // chiamo menu gestione Lamps
            //ligthMenu(myLampList);

            // Display the contents of the list using the Print method.




            if (myLampList.Any() == true)
            {
                myLampList.ForEach(PrintLamp);

            }
            else
            {
                Console.WriteLine("lista vuota ");

                Console.ReadLine();
            }
        }

        private static void PrintLamp(Lamp lamp)
        {
            Console.WriteLine(lamp.Room.ToString() + " " + lamp.Status);
            Console.ReadLine();
        }

        private static void WriteStatus(Lamp lamp)
        {
            //Console.WriteLine($"questo è la lampada di {lamp.Room} ed il suo stato è {lamp.Status}");
            Console.WriteLine($"room {lamp.Room} status <{lamp.Status}>");
            Console.ReadLine();
        }

        //private static void ligthMenu(List<Lamp> listLamp)
        //{

        //    foreach (Lamp aLamp in listLamp)
        //    {
        //        Console.WriteLine("si vede ?", aLamp.Room.ToString() + " " + aLamp.Status);
        //        Console.ReadLine();
        //    }



        //}
    }
}

