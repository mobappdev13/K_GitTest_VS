using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate void myDelegate(string messaggio); 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Delegate examples ");
            myDelegate delegato = new myDelegate(Radio.RadiusMethod);
            delegato("Saluto trasmesso alla Radio, Ciao a Tutti");
            Console.WriteLine();
            Console.WriteLine();
            // referenziamo un altro Method- funzione con le stesse caratteristiche del delegato
            delegato = new myDelegate(Cake.CakeMethod);
            delegato("Ciao, buon compleanno, Lunga vita a te !");
            Console.ReadLine();
        }
    }
}
