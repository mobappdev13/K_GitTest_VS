using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class Cake
    {
        public static void CakeMethod(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"la torta avrà al suo interno questo messaggio: {message}");
        }
    }
}
