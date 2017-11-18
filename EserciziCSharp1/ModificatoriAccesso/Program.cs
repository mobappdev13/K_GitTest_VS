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
           
            string myStringProgram = priv.publicString;
            //string myStringProgram2 = priv.privateString; //error private level protection
            string myStringProgram2 = priv.internalString;
            //string myStringProgram3 = priv.protectedString;//error protected level protection 
            string myStringProgram4 = priv.protectedInternal;

            //string printString = priv.myPrint();
            Console.WriteLine($"da program { priv.publicString} { priv.internalString} {priv.protectedInternal}  ");
            Console.ReadLine();

            DerivatedClass deriv = new DerivatedClass();
            string printString = deriv.MembersVarBaseClass();
            Console.WriteLine(printString);
            Console.ReadLine();

        }
    }
}