using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Planes : IFlyabile
    {
        public string Canfly()
        {
            return "Planes can fly";
            //throw new NotImplementedException();
        }
    }
}
