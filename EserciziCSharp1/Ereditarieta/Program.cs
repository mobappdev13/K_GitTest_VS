using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditariea
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseclass1 = new BaseClass();
            DerivedClass derivedclass = new DerivedClass();
            //BaseClass baseClass2 = new DerivedClass();
            //DerivedClass derivedclass2 = new BaseClass(); error

            //baseclass1.Method1();
            //derivedclass.Method1();
            //derivedclass.Method2();
            //baseClass2.Method1();
            //baseClass2.Method2(); error
            derivedclass.Method1();
            //derivedclass2.Method2(); //error
            Console.ReadLine();
        }
    }
 }