using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDoubleInterface classDoubleI = new ClassDoubleInterface();
            // call otherMethod
            string result = classDoubleI.MyOtherMethod();
            Console.WriteLine($"Method result: {result}");

            result = classDoubleI.Paint();
            Console.WriteLine($"Method result: {result}");
            //con implicit interfaces and casting

            // varibile del tipo Icontrol
            //cast redundant
            Icontrol icontrol = (Icontrol)classDoubleI;
            result = icontrol.Paint();
            Console.WriteLine($"Paint Method Result: {result}");
            ISurface isurface = classDoubleI;
            result = isurface.Paint();
            Console.WriteLine($"Paint Method Result: {result}");
            Console.ReadLine();
        }
    }
}
