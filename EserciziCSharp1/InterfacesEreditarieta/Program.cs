using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEreditarieta
{
    class Program
    {
        public interface IMyBaseInterface
        {
            void DoSomethingBasic();

        }

        public interface IMyInterface : IMyBaseInterface
        {
            void DoSomethingOrOther();
        }

        class MainClass : IMyInterface
        {
            public void DoSomethingBasic()
            {
                Console.WriteLine("Now doing something basic");
                Console.ReadLine();
            }

            public void DoSomethingOrOther()
            {
                Console.WriteLine("Now doing something BSIC Or OTHER");
                Console.ReadLine();
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                MainClass mainClass = new MainClass();
                mainClass.DoSomethingOrOther();
                mainClass.DoSomethingBasic();
                Console.ReadLine();
            }

            
        }
    }
}
