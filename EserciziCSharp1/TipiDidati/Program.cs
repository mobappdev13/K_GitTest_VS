using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipiDidati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("****Tipi di dati Integrali e peso in bits o bytes********");
            Console.WriteLine("**********************************************************");
            sbyte mySbyte = -126;
            byte myByte = 255;
            char myChar = 'X';
            //short
            short myIntShort = 32750;
            short myIntShortNeg = -32750;
            short myIntShortIdem = 32750;
            //ushort myIntUnShor = 64999;
            //int 32 default, 64 long
            //
            Int32 myInt = 22456890;
            Int32 myIntNeg = -22456890;
            Int32 myIntIdem = 22456890;
            //
            Int64 myInt64 = 100222456890;
            Int64 myInt64Neg = -100222456890;
            Int64 myInt64Idem = 100222456890;

            //virgola mobile
            //float	Da ±1.5e−45 e ±3.4e38	7 cifre
            //double Da ±5.0e−324 a ±1.7e308 15 - 16 cifre

            float myFloat = 4.55674F; //anche senza segno
            double myDouble = -1.734567E+3; //con segno e senza

            //DECIMAL 128 BIT
            decimal myMoney1 = 300.566666666m;
            decimal myMoney2 = 3009078904567.556712345678m;

            Console.WriteLine("");
            Console.WriteLine($"tipo sbyte Intero con segno pesa 8 bit, da 128 a -127: value ({mySbyte})");
            Console.WriteLine($"tipo Byte Intero senza segno pesa 8 bit, 0 - 255: value ({myByte})");
            Console.WriteLine($"tipo Char ' ' carattere Unicode, 16 bit: value({myChar}) e CompareTo ({myChar.CompareTo((Object)'x')}) se negativo/positivo no uguali");//non uguali menori di zero
            Console.WriteLine($"tipo Char ' ' carattere Unicode, 16 bit: value({myChar}) e CompareTo ({myChar.CompareTo((Object)'X')}) se zero Uguali");//Uguali è zero
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine($"tipo Int Short con SEGNO, 16 bit: value({myIntShort}) (risultato : {myIntShort.CompareTo((Object)myIntShortNeg)}) diversi");//maggiore o minore diversi
            Console.WriteLine($"tipo Int Short con SEGNO, 16 bit: value({myIntShort}) (risultato : {myIntShort.CompareTo((Object)myIntShortIdem)}) uguali");//zero allora uguali
            Console.WriteLine($" value {myIntShort} GetType  {myIntShort.GetType()}");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("****int 32bits default con segno********");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine(""); Console.WriteLine("");
            // int32 default
            Console.WriteLine($"tipo Int 32 con SEGNO, 32 bit: value({myInt}) (risultato : {myInt.CompareTo((Object)myIntNeg)}) diversi");//maggiore o minore diversi
            Console.WriteLine($"tipo Int 32 con SEGNO, 32 bit: value({myInt}) (risultato : {myInt.CompareTo((Object)myIntIdem)}) uguali");//zero allora uguali
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("****int 64bits default con segno********");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            //int64
            Console.WriteLine($"tipo Int 64 con SEGNO, 64 bit: value({myInt64}) (risultato : {myInt64.CompareTo((Object)myInt64Neg)}) diversi");//maggiore o minore diversi
            Console.WriteLine($"tipo Int 64 con SEGNO, 64 bit: value({myInt64}) (risultato : {myInt64.CompareTo((Object)myInt64Idem)}) uguali");//zero allora uguali
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("****Tipi di dati VIRGOLA MOBILE float e double bassa e alta precisione con segno********");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            //virgola mobile
            Console.WriteLine($"tipo float virgola mobile bassa precissione (7 cifre)- myFloat = 4.55674F- con SEGNO value: ({myFloat})");
            Console.WriteLine($"tipo double virgola mobile alta precissione (15/16 cifre) - double myDouble = -1.734567E+3 - con SEGNO value: ({myDouble})");
            //decimal dati a 128 bit.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("****Tipi dati DECIMAL dati a 128 bit alta precisione con segno (28/29 cifre)************");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine($"tipo decimal 128 BIT ALTA PRECISSIONE precissione (28/ 29 cifre) con SEGNO value: ({myMoney1})");
            Console.WriteLine($"tipo decimal 128 BIT ALTA PRECISSIONE (28/ 29 cifre) con SEGNO value: ({myMoney2})");
            Console.WriteLine("");
            Console.WriteLine("");


            //conversioni di tipo
            //implicite ed esplicite (cast)
            //Poiché non esiste alcuna conversione implicita tra altri tipi a virgola mobile
            //e il tipo decimal, è necessario usare un cast per eseguire una conversione tra questi due tipi. Ad esempio:
            decimal myMoney = 99.9345m;
            double x = (double)myMoney; // decimal to double
            //
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("****decimal to double .... double to decimal                              ************");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine($"decimal to double value: decimal ({myMoney}) (double)myMoney value        { x}        Risult Covertion GetType >>>  ({ x.GetType()})");
            Console.WriteLine($"double to decimal value: double  ({myMoney}) (decimal)x value             { myMoney}  Risult Covertion GetType >>>  ({ myMoney.GetType()})");
            Console.WriteLine("");
            myMoney = (decimal)x; // double to decimal 

            //Console.Write(caption);
            //if (resultGeneric == resultNonGeneric)
            //{
            //    if (resultGeneric < 0) relation = "less than";
            //    else if (resultGeneric > 0) relation = "greater than";
            //    else relation = "equal to";
            //    Console.WriteLine("{0} is {1} {2}", var1, relation, var2);
            //}

            Console.ReadLine();
            ////i1.CompareTo((Object)i2)

        }
    }
}
