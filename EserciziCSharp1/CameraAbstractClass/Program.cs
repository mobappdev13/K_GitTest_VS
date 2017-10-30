using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" questo " + ("Camera " + Enum.GetName(typeof(TypeCamera), 1)));
            Console.ReadLine();
        }
    }
}
