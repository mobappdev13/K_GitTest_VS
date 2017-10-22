using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solid solid;
            while (true)
            {
                Console.WriteLine("Vuoi una sfera o un cubo? (S/C) >  (Z) per uscire");
                var userInput = Console.ReadKey(true);
                if (userInput.Key == ConsoleKey.Z) break;
                //
                if ((userInput.Key == ConsoleKey.S) || (userInput.Key == ConsoleKey.C))
                {
                    Console.WriteLine("Peso Specifico?  (-1) per uscire");
                    string inputspecificWeigth = Console.ReadLine();
                    double specificWeigth;
                    double.TryParse(inputspecificWeigth, out specificWeigth);
                    if (specificWeigth == -1) break;
                    //    
                    if (userInput.Key == ConsoleKey.S)
                    {
                        Console.WriteLine("Raggio ?  (-1) per uscire");
                        string inputRay = Console.ReadLine();
                        double ray;
                        double.TryParse(inputRay, out ray);
                        if (ray == -1) break;
                        solid = new Sfere(ray, specificWeigth, "Sfera");
                    }
                    else if ((userInput.Key == ConsoleKey.C))
                    {
                        Console.WriteLine("Lato ?  (-1) per uscire");
                        string inputSide = Console.ReadLine();
                        double side;
                        double.TryParse(inputSide, out side);
                        solid = new Cube(side, specificWeigth,"Cubo");
                    }
                    else
                    {

                        Console.WriteLine(
                            $"Hai inserito {userInput.Key} ,inserimento invalido.Premi un tasto per continuare");
                        Console.Read();
                        break;
                    }
                    Console.WriteLine($"Ho creato un solido {solid.NameSolid()} con volume {solid.Volume()} e con peso {solid.Weight()}");
                }

            }
        }
    }
}
