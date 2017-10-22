using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte2
{
    
    class Sfere : Solid
    {
        double _ray;
        string _name;

        public Sfere(double ray, double specificWeigth, string name) : base(specificWeigth, "Sfere")
        {
            _ray = ray;
            _name = name;
        }

        public override double Surface()
        {
            return (4 / 3 * Math.PI * Math.Pow(_ray, 3));

            //throw new NotImplementedException();
        }

        public override double Volume()
        {
            return (4 * Math.PI * _ray * _ray);
            //throw new NotImplementedException();
        }

        //public String toString() { return "Sfera (" + _ray + ")"; }
        
    }
}
