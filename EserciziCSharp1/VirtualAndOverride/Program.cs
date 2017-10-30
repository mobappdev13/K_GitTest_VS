using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class SuperClass
    {
        public const int EIGHT = 8;
        public const int TEN = 10;
        public virtual int Method1()
        {
            return EIGHT;
        }
    }
    class DerivateClass : SuperClass
    {
        public override int Method1()
        {
            return base.Method1()*TEN;
        }
    }
    class Program
    {
        public static int result;
        static void Main(string[] args)
        {
            
        SuperClass sc = new SuperClass();        // create Instance type SuperClass in Variable SuperClass
           DerivateClass dc = new DerivateClass(); // create Instance type DerivateClass in Variable DerivateClass
           SuperClass sc1 = new DerivateClass();    // create Instance di DerivateClass in Variabile SuperClass
            
            //invoke Method1 and result
            result = sc.Method1(); //invoke method1 in superclass
            Console.WriteLine($"result method1 in superclass {result}");
            result = dc.Method1(); // invoke method1 in derivateclass
            Console.WriteLine($"result method1 in derivateClass {result}");
            result = sc1.Method1(); //invoke method1 in derivateclass
            Console.WriteLine($"result method1 in derivateClass {result}");
            Console.ReadLine();

        }
    }
}
