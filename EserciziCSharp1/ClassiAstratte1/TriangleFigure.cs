using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte1
{

    class TriangleFigure : Figure
    {
        public int _sizeSideOne, _sizeSideTwo, _sizeSideThree;
        int _sizeBase, _sizeAltitude;

        public TriangleFigure(int sizeSideOne, int sizeSideTwo, int sizeSideThree, int sizeBase, int sizeAltitude) : base("Triangle Figure",3)
        {
            _sizeSideOne = sizeSideOne;
            _sizeSideTwo = sizeSideTwo;
            _sizeSideThree = sizeSideThree;
            _sizeBase = sizeBase;
            _sizeAltitude = sizeAltitude;
        }

        public override double Area
        {
            get
            {
                { return ((_sizeBase*_sizeAltitude)/2); }
            }
        }

        public override double Perimeter
        {
            get
            {
                {return (_sizeSideOne+ _sizeSideTwo +_sizeSideThree); } 
            }
        }

        public override void Draw()
        {
            //does not implemented
            throw new NotImplementedException();
        }
    }

}
