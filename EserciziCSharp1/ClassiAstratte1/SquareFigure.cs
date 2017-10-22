using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte1
{
    class SquareFigure : Figure
    {
        int _sizeSide;
        

        public SquareFigure(int sizeSide) : base("Square Figure", 4)
        {
            _sizeSide = sizeSide;
        }

        public override double Area
        {
            get
            {
                {return (_sizeSide*_sizeSide); }
            }
        }

        public override double Perimeter
        {
            get
            {
                { return (_sizeSide * 4); }
            }
        }

        public override void Draw()
        {
            //does not implemented
            throw new NotImplementedException();
        }
    }


}
