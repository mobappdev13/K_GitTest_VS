using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditariea
{
        class DerivedClass : BaseClass
        {
         public DerivedClass()
            {
            Console.WriteLine("2- poi viene costruttore della classe derivata - proprio ");
            }
            public void Method2()
             {
            Console.WriteLine(" chiama il Method2 - della Classe Derivata");
            }

        public void Method1()
        {
            //per togliere l'occultamento;
            //base.Method1();
            Console.WriteLine("Ocultando Method1 della classe Base -in classe derivata in Method1 -");
        }
    }
    }


