using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte1
{
    public abstract class Figure
    {
        protected string _figureName;
        protected int _sidesNumber;

        //costruttore ...non si stanzia
        public Figure(string figureName, int sidesNumber)
        {
            _figureName = figureName;
           _sidesNumber = sidesNumber;
        }
        //proprieta
        public string FigureName { get { return _figureName; } private set { ; } }
        public int SidesNumber { get { return _sidesNumber; } private set {; } }

        // proprieta astratte
        public abstract double Perimeter{ get; }
        public abstract double Area { get; }

        //metodo abstratto
        public abstract void Draw();
    }
}
