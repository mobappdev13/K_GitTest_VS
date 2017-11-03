using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterface
{
    //property properties
    interface Ipoint
    {
        //properties
        int x { get; set; }
        int y { get; set; }

        //operations
        int Addition(int x, int y);
        int Subtraction(int x, int y);
        int Multiplication(int x, int y);
        int Division(int x, int y);

    }
}
