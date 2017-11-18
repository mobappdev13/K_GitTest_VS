using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoriAccesso
{
    class Program
    {
        internal string[] a = { "Hola" };
        static void Main(string[] args)
        {
            PrivateClass priv = new PrivateClass();
           
            
            //string printString = priv.myPrint();
            Console.WriteLine($"da program { priv.publicString} { priv.internalString} {priv.protectedInternal}  ");
            Console.ReadLine();

            //da classe derivata attenzione in clase Priv campi protected
            DerivatedClass deriv = new DerivatedClass();
            string printString = deriv.MembersVarBaseClass();
            Console.WriteLine(printString);

            //classeindipendente
            IndependentClass indClass = new IndependentClass();
           
            
            printString = $" {indClass.myIntInternal} {indClass.myString} {indClass.MyProtectedInternal}";
            Console.WriteLine(printString);
            //
            Console.ReadLine();

        }
    }
}