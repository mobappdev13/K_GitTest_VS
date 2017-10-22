using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte2
{
    class Cube : Solid
    {
        double _side;
        string _name;
        public Cube(double side, double specificWeigth, string name) : base(specificWeigth, "Cubo")
        {
            _side = side;
            _name = name;
        }

        public override double Surface()
        {
            return ( 6 * _side * _side);
            // throw new NotImplementedException();
        }

        public override double Volume()
        {
            return Math.Pow(_side, 3);
            //throw new NotImplementedException();
        }

        public string toString() { return "Cubo [" + _side + "]"; }
    }
}
