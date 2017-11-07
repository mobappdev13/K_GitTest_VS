using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class Radio
    {
        public static void RadiusMethod(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("sono all'interno della classe Radio");
            Console.WriteLine($"Questo è il messaggio : {message}");
        }
    }
}
