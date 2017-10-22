using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte2
{
    public abstract class Solid
    {
        double _specificWeight;
        string _name;

        //costruttore base non isntanziabile
        public Solid(double specificWeigth, string name)
        {
            _specificWeight = specificWeigth;
            _name = name;
        }

        public double Weight()
        {
            return Volume() * _specificWeight;
        }

        public string NameSolid()
        {
            return _name;
        }
        //metodi astratti
        public abstract double Volume(); // metodo astratto 
        public abstract double Surface(); // metodo astratto 

        
    }
}



