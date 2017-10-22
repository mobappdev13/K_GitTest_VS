using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte1
{
    // creare figure, con tipo di figura da creare (quadrato, triangolo...), nome, dimensione del lato
    //calcolare perimetro, area e disegno(futuro)
    class Program
    {
        static void Main(string[] args)
        {
            // to create an squareFigure
            //test Data
            int sidesize = 12; 
            SquareFigure square = new SquareFigure(sidesize);
            //string aux = square.FigureName;
            Console.WriteLine($" Figure Name >>> {square.FigureName} with {square.SidesNumber} sides and size by side {sidesize}");
            Console.WriteLine($" Figure Name >>> {square.FigureName} with Perimeter {square.Perimeter} and Area {square.Area}");
            Console.ReadLine();
            Console.WriteLine("**********************************************");
            // to create a TriangleFigure
            //test data
            int sizeSideOne = 12;
            int sizeSideTwo = 13;
            int sizeSideThree = 10;
            int sizeBase = 12;
            int sizeAltitude = 13;
            TriangleFigure triangle = new TriangleFigure(sizeSideOne, sizeSideTwo, sizeSideThree, sizeBase, sizeAltitude);
            Console.WriteLine($" Figure Name >>> {triangle.FigureName} with {triangle.SidesNumber} sides and size by side {sizeSideOne} {sizeSideTwo} {sizeSideThree}");
            Console.WriteLine($" Figure Name >>> {triangle.FigureName} with Base { sizeBase} and with Altitudine {sizeAltitude}");
            Console.WriteLine($" Figure Name >>> {triangle.FigureName} with Perimeter {triangle.Perimeter} and Area {triangle.Area}");
            Console.ReadLine();
            
        }
    }
}
