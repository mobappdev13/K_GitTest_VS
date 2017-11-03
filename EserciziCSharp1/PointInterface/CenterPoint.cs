using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterface
{
    class CenterPoint : Ipoint
    {
        //fields private or protected
        private int _pointX;
        private int _pointY;

        //constructor
        public CenterPoint(int x, int y)
        {
            _pointX = x;
            _pointY = y;
        }

        //properties implementation
        public int x
        {
            get
            {
                return _pointX;
            }

            set
            {
                _pointX = value;
            }
        }

        public int y
        {
            get
            {
                return _pointY;
            }

            set
            {
                _pointY = value;
            }
        }

        public int Addition(int x, int y)
        {
            return (x + y);
        }

        public int Division(int x, int y)
        {
            if (y != 0)
            {
                return (x / y);
            }

            else
            {
                //return per invalid operation
                return -99999;
            }
        }

        public int Multiplication(int x, int y)
        {
            return (x * y);
        }

        public int Subtraction(int x, int y)
        {
            return (x - y);
        }
    }
}
