using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoincrementoDecremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 20;
            Console.WriteLine($"1-Valore di variabile dopo l'incremento ++variabile {++variable}");
            Console.WriteLine($"variabile DEF **** {variable}");

            variable = 20;
            Console.WriteLine($"2-Valore di variabile +=1 E' {variable+=1}");
            Console.WriteLine($"variabile DEF **** {variable}");

            variable = 20;
            Console.WriteLine($"2-Valore di  variabile = variabile + 1 E' { variable = variable + 1}");
            Console.WriteLine($"variabile DEF **** {variable}");
            Console.WriteLine($"***************************************");
            variable = 20;
            Console.WriteLine($"3-Valore di  variabile++ PRIMA del incremento E' {variable++}");
            Console.WriteLine($"variabile DEF incrementata **** {variable}");

            variable = 20;
            Console.WriteLine($"4-Valore di  --variabile DOPO IL decremento E' {--variable}");
            Console.WriteLine($"variabile DEF **** {variable}");

            variable = 20;
            Console.WriteLine($"5-Valore di  variabile-- prima IL decremento E' {variable--}");
            Console.WriteLine($"variabile DEF decrementata**** {variable}");
            Console.ReadLine();
        }
    }
}
