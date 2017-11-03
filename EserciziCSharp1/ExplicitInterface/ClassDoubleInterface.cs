using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class ClassDoubleInterface : Icontrol, ISurface
    {
        string Icontrol.Paint()
        {
            return "Paint in Icontrol interface";
        }
        

        string ISurface.Paint()
        {
            return "Paint in ISurface*** interface";
        }

       public string MyOtherMethod()
        {
            return "********this method in class";
        }
        public string Paint()
        {
            return "my paint no interfaces";
        }
    }
}
