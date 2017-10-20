using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1,"Lucia","Peres",DateTime.Parse("19/07/1947"),"Indiana",false, -1200000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name  {p1.Name}  * Lastname {p1.Lastname} * Dateofbirth {p1.DateofBirth.ToShortDateString()} * Nationality {p1.Nationality} ** be enrolled ? {p1.BeEnrrolled} *** salario {p1.Salario}");
            Console.WriteLine();
            Console.WriteLine();
            // se set e privato non riesce ad essere cambiato se set privato attenzione !!!!
                                //p1.Name = "Pippo";
                                //p1.Lastname = "";
                                // p1.DateofBirth = DateTime.Parse(""); // non well formated attenzione sollevare eccezione

            // riesce per che il set non è private
            p1.Salario = 18000;
            Console.WriteLine($"Name  {p1.Name}  * Lastname {p1.Lastname} * Dateofbirth {p1.DateofBirth.ToShortDateString()} * Nationality {p1.Nationality} ** be enrolled ? {p1.BeEnrrolled} *** salario {p1.Salario}");
            //p1.speech(p1.Nationality); se speech è privato nonè accessibile
            Console.WriteLine();
            Console.WriteLine($" greet {p1.Speech(p1.Nationality)}");
            Console.WriteLine();
            Console.WriteLine($" wage after tax {p1.CalcolateTax(p1.Salario)}");
            p1.CalcolateAge(DateTime.Parse("19/07/2000"));
            Console.WriteLine(); Console.WriteLine(); 
            Console.WriteLine($" age { p1.CalcolateAge(DateTime.Parse("19/07/1947"))}");
            Console.ReadLine();
                      
        }
        
    }
}

